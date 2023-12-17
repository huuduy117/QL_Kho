namespace QL_Kho.PAL.User_control
{
    partial class UserControlAddUser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            textBoxRole = new TextBox();
            textBoxPass = new TextBox();
            textBoxEmail = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            buttonAddUser = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(297, 120);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxRole
            // 
            textBoxRole.Location = new Point(661, 189);
            textBoxRole.Name = "textBoxRole";
            textBoxRole.Size = new Size(125, 27);
            textBoxRole.TabIndex = 1;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(661, 122);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(125, 27);
            textBoxPass.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(297, 187);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(148, 124);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 9;
            label1.Text = "Tên đăng nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(148, 191);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 13;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(521, 195);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 14;
            label6.Text = "Role ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(521, 128);
            label9.Name = "label9";
            label9.Size = new Size(86, 21);
            label9.TabIndex = 17;
            label9.Text = "Mật khẩu";
            // 
            // buttonAddUser
            // 
            buttonAddUser.Cursor = Cursors.Hand;
            buttonAddUser.FlatAppearance.BorderSize = 0;
            buttonAddUser.FlatStyle = FlatStyle.Flat;
            buttonAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddUser.Location = new Point(372, 268);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(207, 53);
            buttonAddUser.TabIndex = 18;
            buttonAddUser.Text = "Submit";
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // UserControlAddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonAddUser);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxRole);
            Controls.Add(textBoxName);
            Name = "UserControlAddUser";
            Size = new Size(968, 532);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxRole;
        private TextBox textBoxPass;
        private TextBox textBoxEmail;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label9;
        private Button buttonAddUser;
    }
}
