using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RentalApplicationJanuardi
{
    public partial class ManageItemsForm : Form
    {
        public ManageItemsForm()
        {
            InitializeComponent();
        }

        private void ManageItemsForm_Load(object sender, EventArgs e)
        {
            LoadItems();
            LoadDetails();
        }
        private void LoadItems()
        {
            using (Connection connection = new Connection())
            {
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    try
                    {
                        sqlConnection.Open();
                        string query = "SELECT id_product, product_name, description FROM product";
                        SqlCommand command = new SqlCommand(query, sqlConnection);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dataGridViewItems.DataSource = dataTable;

                            dataGridViewItems.Columns["id_product"].HeaderText = "ID";
                            dataGridViewItems.Columns["product_name"].HeaderText = "Nama Produk";
                            dataGridViewItems.Columns["description"].HeaderText = "Deskripsi";
                        }
                    }
                    catch (SqlException sqlex)
                    {
                        MessageBox.Show("Kesalahan SQL : " + sqlex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kesalahan : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void LoadDetails(string productId = null)
        {
            using (Connection connection = new Connection())
            {
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    try
                    {
                        sqlConnection.Open();
                        string query = "SELECT dp.id_detail_product, dp.product_id, p.product_name,dp.product_detail_note, dp.borrowed " + "FROM detail_product dp " + "JOIN product p ON dp.product_id = p.id_product";
                        if (!string.IsNullOrEmpty(productId))
                        {
                            query += " WHERE dp.product_id = @productId";
                        }
                        SqlCommand command = new SqlCommand(query, sqlConnection);

                        if (!string.IsNullOrEmpty(productId))
                        {
                            command.Parameters.AddWithValue("@productId", productId);
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dataGridViewDetails.DataSource = dataTable;

                            dataGridViewDetails.Columns["id_detail_product"].HeaderText = "ID";
                            dataGridViewDetails.Columns["product_id"].HeaderText = "ID_Produk";
                            dataGridViewDetails.Columns["product_name"].HeaderText = "Nama_Produk";
                            dataGridViewDetails.Columns["product_detail_note"].HeaderText = "Catatan_Detail_Produk";
                            dataGridViewDetails.Columns["borrowed"].HeaderText = "Dipinjam";
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Kesalahan SQL : " + sqlEx.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Kesalahan : " + Ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           ItemDataForm itemDataForm = new ItemDataForm
           {
               Text = "Add Item",
               labelItemForm =  { Text = "ADD ITEM" }
           };

           using (Connection connection = new Connection())
           {
               using (SqlConnection sqlConnection = connection.GetConnection())
               {
                   try
                   {
                       sqlConnection.Open();
                       string query = "SELECT ISNULL(MAX(CAST(SUBSTRING(id_product, 2, LEN(id_product) - 1)AS INT)), 0) + 1 FROM product";
                       SqlCommand command = new SqlCommand(query, sqlConnection);
                       int newItemIdNumber = (int)command.ExecuteScalar();
                       string newItemId = "P" + newItemIdNumber.ToString("D3");
                       itemDataForm.textbBoxIdProduct.Text = newItemId;
                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show("Kesalahan saat mengambil ID baru : " + ex.Message);
                   }
                   finally
                   {
                       sqlConnection.Close();
                   }
               }
           }
           itemDataForm.ShowDialog();
           LoadItems();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewItems.SelectedRows[0].Index;
                string productId = dataGridViewItems.Rows[selectedRowIndex].Cells["id_product"].Value.ToString().Trim();
                int productIdNumber = Convert.ToInt32(productId.Substring(1));

                ItemDataForm itemDataForm = new ItemDataForm
                {
                    Text = "Edit Item",
                    labelItemForm = { Text = "EDIT ITEM" }
                };

                using (Connection conection = new Connection())
                {
                    using (SqlConnection sqlConnection = conection.GetConnection())
                    {
                        try
                        {
                            sqlConnection.Open();
                            string query = "SELECT product_name, description FROM product WHERE id_product = @productId";
                            SqlCommand command = new SqlCommand(query, sqlConnection);
                            command.Parameters.AddWithValue("@productId", productId);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    itemDataForm.textbBoxIdProduct.Text = productId.Trim();
                                    itemDataForm.textbBoxProductName.Text = reader["product_name"].ToString();
                                    itemDataForm.textbBoxDescription.Text = reader["description"].ToString();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Kesalahan saat mengambil data produk : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            sqlConnection.Close();
                        }
                    }
                }
                itemDataForm.ShowDialog();
                LoadItems();
            }
            else
            {
                MessageBox.Show("Silahkan pilih item yang ingin diedit", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewItems.SelectedRows[0].Index;
                string productId = dataGridViewItems.Rows[selectedRowIndex].Cells["id_product"].Value.ToString().Trim();

                DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus item ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    using (Connection connection = new Connection())
                    {
                        using (SqlConnection sqlConnection = connection.GetConnection())
                        {
                            try
                            {
                                sqlConnection.Open();
                                string query = "DELETE FROM product WHERE id_product = @productId";
                                SqlCommand command = new SqlCommand(query, sqlConnection);
                                command.Parameters.AddWithValue("@productId", productId);

                                int rowsAffected = command.ExecuteNonQuery();
                                MessageBox.Show(rowsAffected > 0 ? "Item Berhasil dihapus!" : "Gagal menghapus item", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Kesalahan saat menghapus item : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                sqlConnection.Close();
                            }
                        }
                    }
                    LoadItems();
                }
            }
            else
            {
                MessageBox.Show("Kesalahan saat mengambil data produk : ", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string productId = dataGridViewItems.Rows[e.RowIndex].Cells["id_product"].Value.ToString();

                LoadDetails(productId);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewItems.SelectedRows[0].Index;
                string detailId = dataGridViewItems.Rows[selectedRowIndex].Cells["id_product"].Value.ToString().Trim();

                ItemDetailForm itemDetailForm = new ItemDetailForm

                {
                    Text = "Add Item Detail",
                    labelDetailForm = { Text = "ADD ITEM DETAIL" }
                };

                itemDetailForm.textBoxProductId.Text = detailId;

                using (Connection connection = new Connection())
                {
                    using (SqlConnection sqlConnection = connection.GetConnection())
                    {
                        try
                        {
                            sqlConnection.Open();
                            string query = "SELECT ISNULL(MAX(CAST(SUBSTRING(id_detail_product, 2, LEN(id_detail_product) - 1) AS INT)), 0) + 1 FROM detail_product";
                            SqlCommand command = new SqlCommand(query, sqlConnection);
                            int newDetailIdNumber = (int)command.ExecuteScalar();
                            string newDetailId = "D" + newDetailIdNumber.ToString("D3");
                            itemDetailForm.textBoxIdDetail.Text = newDetailId;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Kesalahan saat mengambil ID detail item baru : " + ex.Message);
                        }
                        finally
                        {
                            sqlConnection.Close();
                        }
                    }
                }
                itemDetailForm.ShowDialog();
                LoadDetails();
            }
            else
            {
                MessageBox.Show("Silahkan pilih item yang ingin ditambahkan detailnya.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridViewDetails.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewDetails.SelectedRows[0].Index;
                string detailId = dataGridViewDetails.Rows[selectedRowIndex].Cells["id_detail_product"].Value.ToString().Trim();

                ItemDetailForm itemDetailForm = new ItemDetailForm 
                {
                    Text = "Edit Item Detail",
                    labelDetailForm = { Text = "Edit Item Detail" }
                };

                using (Connection connection = new Connection())
                {
                    using (SqlConnection sqlConnection = connection.GetConnection())
                    {
                        try
                        {
                            sqlConnection.Open();
                            string query = "SELECT id_detail_product, product_id, product_detail_note, borrowed FROM detail_product WHERE id_detail_product = @detailId";
                            SqlCommand command = new SqlCommand(query, sqlConnection);
                            command.Parameters.AddWithValue("@detailId", detailId);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    itemDetailForm.textBoxIdDetail.Text = reader["id_detail_product"].ToString().Trim();
                                    itemDetailForm.textBoxProductId.Text = reader["product_id"].ToString().Trim();
                                    itemDetailForm.textBoxDetailNote.Text = reader["product_detail_note"].ToString().Trim();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Kesalahan saat mengambil data detail produk : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            sqlConnection.Close();
                        }
                    }
                }
                itemDetailForm.ShowDialog();
                LoadDetails();
            }
            else
            {
                MessageBox.Show("Silahkan pilih detail item yang ingin diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridViewDetails.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewDetails.SelectedRows[0].Index;
                string detailId = dataGridViewDetails.Rows[selectedRowIndex].Cells["id_detail_product"].Value.ToString().Trim();

                DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus detail item ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    using (Connection connection = new Connection())
                    {
                        using (SqlConnection sqlConnection = connection.GetConnection())
                        {
                            try
                            {
                                sqlConnection.Open();
                                string query = "DELETE FROM detail_product WHERE id_detail_product = @detailId";
                                SqlCommand command = new SqlCommand(query, sqlConnection);
                                command.Parameters.AddWithValue("@detailId", detailId);

                                int rowsAffected = command.ExecuteNonQuery();
                                MessageBox.Show(rowsAffected > 0 ? "Detail item berhasil dihapus!" : "Gagal menghapus detail item", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Kesalahan saat menghapus detail item : " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                sqlConnection.Close();
                            }
                        }
                    }
                    LoadDetails();
                }
            }
            else
            {
                MessageBox.Show("Silahkan pilih detail item yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
