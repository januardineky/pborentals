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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadMembersData();
        }

        private void LoadMembersData()
        {
            using (Connection connection = new Connection())
            {
                using (SqlConnection sqlconnection = connection.GetConnection())
                {
                    try
                    {
                        sqlconnection.Open();

                        string query = "SELECT id_member, member_name, address, phone_number FROM member";

                        SqlCommand command = new SqlCommand(query, sqlconnection);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();

                            dataTable.Load(reader);

                            dataGridViewMember.DataSource = dataTable;

                            dataGridViewMember.Columns["id_member"].HeaderText = "ID";
                            dataGridViewMember.Columns["member_name"].HeaderText = "Nama Anggota";
                            dataGridViewMember.Columns["address"].HeaderText = "Alamat";
                            dataGridViewMember.Columns["phone_number"].HeaderText = "Nomor Telpon";

                            dataGridViewMember.Columns["id_member"].Width = 100;
                            dataGridViewMember.Columns["member_name"].Width = 175;
                            dataGridViewMember.Columns["address"].Width = 200;
                            dataGridViewMember.Columns["phone_number"].Width = 125;
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Kesalahan SQL: " + sqlEx.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Kesalahan: " + Ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlconnection.Close();
                    }
                }
            }
        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            MemberForm memberDataForm = new MemberForm
            {
                Text = "Add Member",

                labelMemberForm = { Text = "ADD MEMBER" }
            };
            using (Connection connection = new Connection())
            {
                using (SqlConnection sqlconnection = connection.GetConnection())
                {
                    try
                    {
                        sqlconnection.Open();

                        string query = "SELECT ISNULL(MAX(CAST(SUBSTRING(id_member, 2, LEN(id_member) - 1)AS INT)), 0) + 1 FROM member";

                        SqlCommand command = new SqlCommand(query, sqlconnection);

                        int newMemberIdNumber = (int)command.ExecuteScalar();

                        string newMemberId = "M" + newMemberIdNumber.ToString("D3");

                        memberDataForm.textBoxIdMember.Text = newMemberId;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kesalahan saat mengambil ID anggota baru: " + ex.Message);
                    }
                    finally
                    {
                        sqlconnection.Close();
                    }
                }
            }

            memberDataForm.ShowDialog();

            LoadMembersData();
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            if (dataGridViewMember.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewMember.SelectedRows[0].Index;

                string memberId = dataGridViewMember.Rows[selectedRowIndex].Cells["id_member"].Value.ToString().Trim();

                MemberForm memberDataForm = new MemberForm
                {
                    Text = "Edit Member",

                    labelMemberForm = { Text = "EDIT MEMBER" }
                };

                using (Connection connection = new Connection())
                {
                    using (SqlConnection sqlConnection = connection.GetConnection())
                    {
                        try
                        {
                            sqlConnection.Open();

                            string query = "SELECT member_name, address, phone_number FROM member WHERE id_member = @member_id";

                            SqlCommand command = new SqlCommand(query, sqlConnection);

                            command.Parameters.AddWithValue("@member_id", memberId);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    memberDataForm.textBoxIdMember.Text = memberId.Trim();
                                    memberDataForm.textBoxMemberName.Text = reader["member_name"].ToString();
                                    memberDataForm.textBoxAddress.Text = reader["address"].ToString();
                                    memberDataForm.textBoxPhoneNumber.Text = reader["phone_number"].ToString();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Kesalahan saat mengambil data anggota: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            sqlConnection.Close();
                        }
                    }
                }

                memberDataForm.ShowDialog();

                LoadMembersData();
            }
            else
            {
                MessageBox.Show("Silahkan pilih anggota yang ingin diedit. ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (dataGridViewMember.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewMember.SelectedRows[0].Index;

                string memberId = dataGridViewMember.Rows[selectedRowIndex].Cells["id_member"].Value.ToString().Trim();

                DialogResult dialogresult = MessageBox.Show("Apakah anda yakin ingin menghapus anggota ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogresult == DialogResult.Yes)
                {
                    using (Connection connection = new Connection())
                    {
                        using (SqlConnection sqlconnection = connection.GetConnection())
                        {
                            try
                            {
                                sqlconnection.Open();

                                string query = "DELETE FROM member WHERE id_member = @memberId";

                                SqlCommand command = new SqlCommand(query, sqlconnection);

                                command.Parameters.AddWithValue("@memberId", memberId);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Anggota berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Gagal menghapus anggota", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Kesalahan saat menghapus anggota: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                sqlconnection.Close();
                            }
                        }
                    }
                    LoadMembersData();
                }
            }
            else
            {
                MessageBox.Show("Kesalahan saat menghapus anggota: ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnManageItems_Click(object sender, EventArgs e)
        {
            ManageItemsForm manageItemsForm = new ManageItemsForm();
            manageItemsForm.Show();
        }

        private void btnRentalNewItems_Click(object sender, EventArgs e)
        {
            if (dataGridViewMember.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewMember.SelectedRows[0].Index;
                string memberId = dataGridViewMember.Rows[selectedRowIndex].Cells["id_member"].Value.ToString().Trim();
                string memberName = dataGridViewMember.Rows[selectedRowIndex].Cells["member_name"].Value.ToString().Trim();

                RentalItemsForm rentalItemsForm = new RentalItemsForm();

                rentalItemsForm.textBoxMemberId.Text = memberId;
                rentalItemsForm.textBoxMemberName.Text = memberName;

                rentalItemsForm.Show();
            }
            else
            {
                MessageBox.Show("Pilih anggota terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMember.Rows[e.RowIndex];
                var cellValue = row.Cells["id_member"].Value;

                if (cellValue != null && cellValue != DBNull.Value)
                {
                    string memberId = cellValue.ToString().Trim();

                    LoadRentalItems(memberId);
                }
                else
                {
                    MessageBox.Show("ID anggota tidak valid atau tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void LoadRentalItems(string memberId)
        {
            using (Connection connection = new Connection())
            {
                using (SqlConnection sqlconnection = connection.GetConnection())
                {
                    try
                    {
                        sqlconnection.Open();

                        string query = @"SELECT
                                            r.id_rental,
                                            p.product_name,
                                            dp.id_detail_product,
                                            r.rental_date,
                                            r.rental_return_date
                                         FROM rental r
                                         INNER JOIN detail_product dp ON r.detail_product_id = dp.id_detail_product
                                         INNER JOIN product p ON dp.product_id = p.id_product
                                         WHERE r.member_id = @memberId ORDER BY r.id_rental DESC";
                        SqlCommand command = new SqlCommand(query, sqlconnection);
                        command.Parameters.AddWithValue("@memberId", memberId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            dataGridViewRental.DataSource = dataTable;

                            dataGridViewRental.Columns["id_rental"].HeaderText = "ID";
                            dataGridViewRental.Columns["product_name"].HeaderText = "Nama_Produk";
                            dataGridViewRental.Columns["id_detail_product"].HeaderText = "ID_detail_produk";
                            dataGridViewRental.Columns["rental_date"].HeaderText = "Tgl_Rental";
                            dataGridViewRental.Columns["rental_return_date"].HeaderText = "Tgl_Kembali";
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Kesalahan SQL : " + sqlEx.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Kesalahan SQL : " + Ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        sqlconnection.Close();
                    }
                }
            }
        }

        private void btnReturnRentalItems_Click(object sender, EventArgs e)
        {
            if (dataGridViewRental.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewRental.SelectedRows[0].Index;
                string rentalId = dataGridViewRental.Rows[selectedRowIndex].Cells["id_rental"].Value.ToString().Trim();
                string detailProductId = dataGridViewRental.Rows[selectedRowIndex].Cells["id_detail_product"].Value.ToString().Trim();

                using (Connection connection = new Connection())
                {
                    using (SqlConnection sqlconnection = connection.GetConnection())
                    {
                        try
                        {
                            sqlconnection.Open();
                            DateTime currentDate = DateTime.Now;

                            string updateRentalQuery = "UPDATE rental SET rental_return_date = @currentDate WHERE id_rental = @rentalId";
                            string updateDetailProductQuery = "UPDATE detail_product SET borrowed = 'No' WHERE id_detail_product = @detailProductlId";

                            SqlCommand updateRentalCommand = new SqlCommand(updateRentalQuery, sqlconnection);
                            updateRentalCommand.Parameters.AddWithValue("@currentDate", currentDate);
                            updateRentalCommand.Parameters.AddWithValue("@rentalId", rentalId);

                            SqlCommand updateDetailProductCommand = new SqlCommand(updateDetailProductQuery, sqlconnection);
                            updateDetailProductCommand.Parameters.AddWithValue("@detailProductId", detailProductId);

                            updateRentalCommand.ExecuteNonQuery();
                            updateDetailProductCommand.ExecuteNonQuery();

                            MessageBox.Show("Item Berhasil Dikembalikan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show("Kesalahan SQL : " + sqlEx.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch (Exception Ex)
                        {
                            MessageBox.Show("Kesalahan SQL : " + Ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        finally
                        {
                            sqlconnection.Close();
                        }
                    }
                }
                if (dataGridViewMember.SelectedRows.Count > 0)
                {
                    string memberId = dataGridViewMember.SelectedRows[0].Cells["id_member"].Value.ToString().Trim();
                    LoadRentalItems(memberId);
                }
            }
            else
            {
                MessageBox.Show("Pilih item rental yang ingin dikembalikan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
