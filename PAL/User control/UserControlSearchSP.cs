using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_Kho.PAL.User_control
{
    public partial class UserControlSearchSP : UserControl
    {
        public UserControlSearchSP()
        {
            InitializeComponent();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxTimKiem.Text, out int maKhachHang))
            {
                GetCustomerDetailsByID(maKhachHang);
            }
            else
            {
                MessageBox.Show("ID không hợp lệ.");
            }
            textBoxTimKiem.Clear();
        }

        private void GetCustomerDetailsByID(int maKhachHang)
        {
            string connectionString = "Data Source =ADUMOIMOIMOI; Initial Catalog = QL_Kho; Integrated Security = TRUE";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GetTTKhachHangByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@MaKhachHang", maKhachHang));

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
