using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using QL_Kho.PAL.User_control;

namespace QL_Kho.PAL.Forms
{
    public partial class FormMain : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = ADUMOIMOIMOI; Initial Catalog = QL_Kho; Integrated Security = TRUE");
        public string Username, Role;

        public FormMain()
        {
            InitializeComponent();
            timerDateTime.Start();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you wanna exit?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateTime.Stop();

                Close();

            }
            else
            {
                panelExpand.Hide();

            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelExpand.Hide();
            labelUsername.Text = Username;
            labelRole.Text = Role;
            //UserControlDashboard dshb = new UserControlDashboard();
            //addUserControl(dshb);
            if (Role == "user")
            {
                buttonDashboard.Hide();
                buttonCn3.Hide();
                buttonReport.Hide();
                buttonCn2.Hide();
                buttonCn4.Hide();
            }

        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("F");
        }


        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            UserControlDashboard dshb = new UserControlDashboard();
            addUserControl(dshb);
        }



        private void buttonReport_Click(object sender, EventArgs e)
        {
            UserControlAddUser addUser = new UserControlAddUser();
            addUserControl(addUser);
        }



        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (panelExpand.Visible)
            {
                panelExpand.Visible = false;
            }
            else
            { panelExpand.Visible = true; }
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void buttonCn2_Click(object sender, EventArgs e)
        {
            UserControlAddSP addSP = new UserControlAddSP();
            addUserControl(addSP);
        }

        private void buttonCn1_Click(object sender, EventArgs e)
        {
            UserControlSearchSP searchSP = new UserControlSearchSP();
            addUserControl(searchSP);
        }

        private void buttonCn3_Click(object sender, EventArgs e)
        {
            UserControlQLDonHang qlgh = new UserControlQLDonHang();
            addUserControl(qlgh);
        }
    }
}
