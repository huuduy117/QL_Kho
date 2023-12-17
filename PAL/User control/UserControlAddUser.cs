using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Kho.PAL.User_control
{
    public partial class UserControlAddUser : UserControl
    {
        private string sql = "Data Source = QUANGDAT\\SQLEXPRESS; Initial Catalog = QL_Kho; Integrated Security = TRUE";


        public UserControlAddUser()
        {
            InitializeComponent();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            string userName = textBoxName.Text;
            string password = textBoxPass.Text;
            string email = textBoxEmail.Text;
            string userRole = textBoxRole.Text;

            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password) &&
                !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(userRole))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(sql))
                    {
                        connection.Open();

                        string query = "INSERT INTO ACCOUNT (TenAccount, Pass, Email, RoleID) " +
                                       "VALUES (@UserName, @Password, @Email, @UserRole)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserName", userName);
                            command.Parameters.AddWithValue("@Password", password);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@UserRole", userRole);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
