using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_Kho.PAL.User_control
{
    public partial class UserControlQLDonHang : UserControl
    {
        private string connectionString = "Data Source=ADUMOIMOIMOI;Initial Catalog=QL_Kho;Integrated Security=True";

        public UserControlQLDonHang()
        {
            InitializeComponent();
            LoadChiTietGiaoHangData();
        }

        private void LoadChiTietGiaoHangData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM ChiTietGiaoHang";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewChitietgiaohang.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxTimKiem.Text, out int maDon))
            {
                LayTTDonHang(maDon);
            }
            else
            {
                MessageBox.Show("ID không hợp lệ.");
            }
            textBoxTimKiem.Clear();
        }
        private void LayTTDonHang(int maDon)
        {
            string connectionString = "Data Source =ADUMOIMOIMOI; Initial Catalog = QL_Kho; Integrated Security = TRUE";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GetChiTietGiaoHangInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@MaChiTietGiaoHang", maDon));

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            dataGridViewChitietgiaohang.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewChitietgiaohang.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewChitietgiaohang.SelectedRows[0];

                if (int.TryParse(selectedRow.Cells["MaChiTietGiaoHang"].Value.ToString(), out int maChiTietGiaoHang))
                {
                    int soLuong = Convert.ToInt32(textBoxSoLuong.Text);
                    DateTime ngayDuKien = dateTimePickerNgayDuKien.Value;
                    DateTime ngayThucTe = dateTimePickerNgayThucTe.Value;

                    UpdateChiTietGiaoHang(maChiTietGiaoHang, soLuong, ngayDuKien, ngayThucTe);
                }
                else
                {
                    MessageBox.Show("Invalid selected row. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateChiTietGiaoHang(int maChiTietGiaoHang, int soLuong, DateTime ngayDuKien, DateTime ngayThucTe)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("UpdateChiTietGiaoHang", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaChiTietGiaoHang", maChiTietGiaoHang);
                        command.Parameters.AddWithValue("@SoLuongGiaoHang", soLuong);
                        command.Parameters.AddWithValue("@NgayDuKien", ngayDuKien);
                        command.Parameters.AddWithValue("@NgayThucTe", ngayThucTe);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Update successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
