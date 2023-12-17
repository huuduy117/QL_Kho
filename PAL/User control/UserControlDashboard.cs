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

namespace DiemdanhSV.PAL.User_control
{
    public partial class UserControlDashboard : UserControl
    {
        private string connectionString = "Data Source=ADUMOIMOIMOI;Initial Catalog=QL_Kho;Integrated Security=True";

        public UserControlDashboard()
        {
            InitializeComponent();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string countLopQuery = "SELECT COUNT(*) FROM SanPham";
                    using (SqlCommand command = new SqlCommand(countLopQuery, connection))
                    {
                        int sp = Convert.ToInt32(command.ExecuteScalar());
                        labelsp.Text = $"{sp}";
                    }

                    string countSinhVienQuery = "SELECT COUNT(*) FROM DonDatHang";
                    using (SqlCommand command = new SqlCommand(countSinhVienQuery, connection))
                    {
                        int siSo = Convert.ToInt32(command.ExecuteScalar());
                        labelSiSo.Text = $"{siSo}";
                    }

                    string countMonHocQuery = "SELECT COUNT(*) FROM NhaCungCap";
                    using (SqlCommand command = new SqlCommand(countMonHocQuery, connection))
                    {
                        int soMonHoc = Convert.ToInt32(command.ExecuteScalar());
                        labelMonHoc.Text = $"{soMonHoc}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}