using System;
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

namespace QL_Kho.PAL.Forms
{
    public partial class FormForgotPass : Form
    {
        private string sql = "Data Source = ADUMOIMOIMOI; Initial Catalog = QL_Kho; Integrated Security = TRUE";
        public FormForgotPass()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool IsvalidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxCloseFP, "Close");
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Trim() == "example@gmail.com")
            {
                textBoxEmail.Clear();
                textBoxEmail.ForeColor = Color.Black;
            }
            if (IsvalidEmail(textBoxEmail.Text.Trim()) || textBoxEmail.Text.Trim() == "example@gmail.com")
            {
                pictureBoxError1.Show();
            }
            else
            {
                pictureBoxError1.Hide();
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Trim() == string.Empty)
            {
                textBoxEmail.Text = "example@gmail.com";
                textBoxEmail.ForeColor = Color.DarkGray;

            }
            if (!IsvalidEmail(textBoxEmail.Text.Trim()) || textBoxEmail.Text.Trim() == "example@gmail.com")
            {
                pictureBoxError1.Show();
            }
            else
            {
                pictureBoxError1.Hide();
            }
        }

        private void pictureBoxError1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxError1, "Invalid email");

        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            if (IsvalidEmail(textBoxEmail.Text.Trim()))
            {
                string userName = Attendance.Attendance.GetUsernamePassword("Select TenAccount from ACCOUNT where Email = '" + textBoxEmail.Text.Trim() + "';", sql);
                string passWord = Attendance.Attendance.GetUsernamePassword("Select Pass from ACCOUNT where Email = '" + textBoxEmail.Text.Trim() + "';", sql);
                MessageBox.Show("Your username is: " + userName + " and your password is: " + passWord, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void FormForgotPass_Load(object sender, EventArgs e)
        {
            pictureBoxError1.Hide();
        }
    }
}
