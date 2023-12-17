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
    public partial class UserControlAddSP : UserControl
    {
        private string sql = "Data Source =QUANGDAT\\SQLEXPRESS; Initial Catalog = QL_Kho; Integrated Security = TRUE";
        public UserControlAddSP()
        {
            InitializeComponent();
        }
        public void LoadDuLieuDGV()
        {
            string query = "SELECT * FROM SanPham";

            using (SqlConnection connection = new SqlConnection(sql))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "SanPham");


                    dataGridView1.DataSource = dataSet.Tables["SanPham"];
                }
            }
        }
        private void LoadDataToComboBox()
        {

            using (SqlConnection connection = new SqlConnection(sql))
            {
                connection.Open();

                string query = "SELECT DanhMucSanPham FROM SanPham";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        cbb_dmsp.Items.Add(reader["DanhMucSanPham"].ToString());
                    }
                }
            }
        }
        private void UserControlAddSP_Load(object sender, EventArgs e)
        {
            LoadDuLieuDGV();
            LoadDataToComboBox();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            string masanpham = txt_msp.Text;
            string tensanpham = txt_tsp.Text;
            string mota = txt_mtsp.Text;
            string danhmuc = cbb_dmsp.Text;
            int sltoithieu = int.Parse(txt_sltt.Text);

            if (!string.IsNullOrEmpty(masanpham) && !string.IsNullOrEmpty(tensanpham) &&
                !string.IsNullOrEmpty(mota) && !string.IsNullOrEmpty(danhmuc) && sltoithieu >= 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(sql))
                    {
                        connection.Open();

                        string query = "INSERT INTO SanPham (MaSanPham,TenSanPham,MoTaSanPham, DanhMucSanPham,SoLuongToiThieu) " +
                                       "VALUES (@MaSanPham, @TenSanPham, @MoTaSanPham, @DanhMucSanPham,@SoLuongToiThieu)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@MaSanPham", masanpham);
                            command.Parameters.AddWithValue("@TenSanPham", tensanpham);
                            command.Parameters.AddWithValue("@MoTaSanPham", mota);
                            command.Parameters.AddWithValue("@DanhMucSanPham", danhmuc);
                            command.Parameters.AddWithValue("@SoLuongToiThieu", sltoithieu);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDuLieuDGV();
                    txt_msp.Clear();
                    txt_tsp.Clear();
                    txt_mtsp.Clear();
                    txt_sltt.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string masanpham = txt_msp.Text;
            if (!string.IsNullOrEmpty(masanpham))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(sql))
                    {
                        connection.Open();

                        string query = "DELETE FROM SanPham where MaSanPham=@MaSanPham";


                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@MaSanPham", masanpham);

                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Product delete successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDuLieuDGV();
                    txt_msp.Clear();
                    txt_tsp.Clear();
                    txt_mtsp.Clear();
                    txt_sltt.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            string masanpham = txt_msp.Text;
            string tensanpham = txt_tsp.Text;
            string mota = txt_mtsp.Text;
            string danhmuc = cbb_dmsp.Text;
            int sltoithieu = int.Parse(txt_sltt.Text);

            if (!string.IsNullOrEmpty(masanpham) && !string.IsNullOrEmpty(tensanpham) &&
                !string.IsNullOrEmpty(mota) && !string.IsNullOrEmpty(danhmuc) && sltoithieu >= 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(sql))
                    {
                        connection.Open();

                        string query = "UPDATE SanPham set TenSanPham=@TenSanPham,MoTaSanPham=@MoTa,DanhMucSanPham=@DanhMuc,SoLuongToiThieu=@SoLuongTT where MaSanPham=@MaSanPham";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@MaSanPham", masanpham);
                            command.Parameters.AddWithValue("@TenSanPham", tensanpham);
                            command.Parameters.AddWithValue("@MoTa", mota);
                            command.Parameters.AddWithValue("@DanhMuc", danhmuc);
                            command.Parameters.AddWithValue("@SoLuongTT", sltoithieu);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Product update successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDuLieuDGV();
                    txt_msp.Clear();
                    txt_tsp.Clear();
                    txt_mtsp.Clear();
                    txt_sltt.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
