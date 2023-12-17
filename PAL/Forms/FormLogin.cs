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
using System.Runtime.CompilerServices;

namespace QL_Kho.PAL.Forms
{
    public partial class FormLogin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = ADUMOIMOIMOI; Initial Catalog = QL_Kho; Integrated Security = TRUE");
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxShow, "Show password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxHide, "Hide password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = false;
            pictureBoxShow.Hide();
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
            pictureBoxHide.Hide();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            pictureBoxError.Hide();
            labelError.Hide();
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username, password;

            username = textBoxName.Text;
            password= textBoxPass.Text;

            try
            {
                String querry = "Select * from ACCOUNT where TenAccount = '"+textBoxName.Text+ "' and Pass = '"+textBoxPass.Text+"' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = textBoxName.Text;
                    password = textBoxPass.Text;
                    FormMain formMain = new FormMain();
                    this.Hide();
                    textBoxName.Clear();
                    textBoxPass.Clear();
                    pictureBoxHide_Click(sender, e);
                    textBoxName.Focus();
                    pictureBoxError.Hide();
                    labelError.Hide();
                    formMain.ShowDialog();
                    this.Show();
                }
                else
                {
                    pictureBoxError.Show();
                    labelError.Show();
                    textBoxName.Clear();
                    textBoxPass.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void textBoxPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar != (char)Keys.Enter)
            //{
            //    buttonLogin.PerformClick();
            //    e.Handled = true;
            //}
        }

        private void labelFP_Click(object sender, EventArgs e)
        {
            FormForgotPass formForgotPass = new FormForgotPass();
            formForgotPass.ShowDialog();
        }
    }

}