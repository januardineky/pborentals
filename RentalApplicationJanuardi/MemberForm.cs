using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RentalApplicationJanuardi
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSaveMember_Click(object sender, EventArgs e)
        {
            string idMember = textBoxIdMember.Text.Trim();
            string memberName = textBoxMemberName.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            string phoneNumber = textBoxPhoneNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(memberName) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Semua field harus diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (Connection connection = new Connection())
            {
                using (SqlConnection sqlconnection = connection.GetConnection())
                {
                    try
                    {
                        sqlconnection.Open();

                        string checkQuery = "SELECT COUNT(*) FROM MEMBER WHERE id_member = @idMember";
                        SqlCommand checkCommand = new SqlCommand(checkQuery, sqlconnection);
                        checkCommand.Parameters.AddWithValue("@idMember", idMember);

                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            string updateQuery = "UPDATE member SET member_name = @memberName, address = @address, phone_number = @phoneNumber WHERE id_member = @idMember";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlconnection);
                            updateCommand.Parameters.AddWithValue("@memberName", memberName);
                            updateCommand.Parameters.AddWithValue("@address", address);
                            updateCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                            updateCommand.Parameters.AddWithValue("@idMember", idMember);

                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            MessageBox.Show(rowsAffected > 0 ? "Data anggota berhasil diperbarui" : "Gagal memperbarui data anggota.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO member (id_member, member_name, address, phone_number) VALUES(@idMember, @memberName, @address, @phoneNumber)";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlconnection);
                            insertCommand.Parameters.AddWithValue("@idMember", idMember);
                            insertCommand.Parameters.AddWithValue("@memberName", memberName);
                            insertCommand.Parameters.AddWithValue("@address", address);
                            insertCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            MessageBox.Show(rowsAffected > 0 ? "Anggota baru berhasil ditambahkan! " : "Gagal menambahkan anggota baru", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kesalahan saat menyimpan data anggota: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        sqlconnection.Close();
                    }
                 }

              }
            this.Close();
        }
        private void btnCancelMember_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
