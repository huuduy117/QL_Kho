namespace QL_Kho.PAL.Forms
{
    partial class FormLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBoxClose = new PictureBox();
            pictureBoxMinimize = new PictureBox();
            groupBox1 = new GroupBox();
            textBoxPass = new TextBox();
            pictureBoxError = new PictureBox();
            pictureBoxShow = new PictureBox();
            pictureBoxHide = new PictureBox();
            buttonLogin = new Button();
            labelError = new Label();
            labelFP = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(1157, 12);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(31, 31);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 0;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            pictureBoxClose.MouseHover += pictureBoxClose_MouseHover;
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Image = (Image)resources.GetObject("pictureBoxMinimize.Image");
            pictureBoxMinimize.Location = new Point(1120, 12);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(31, 31);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 0;
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            pictureBoxMinimize.MouseHover += pictureBoxMinimize_MouseHover;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(textBoxPass);
            groupBox1.Controls.Add(pictureBoxError);
            groupBox1.Controls.Add(pictureBoxShow);
            groupBox1.Controls.Add(pictureBoxHide);
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.Controls.Add(labelError);
            groupBox1.Controls.Add(labelFP);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century Gothic", 10F);
            groupBox1.Location = new Point(107, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 412);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please Login FIrst";
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(92, 182);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(227, 28);
            textBoxPass.TabIndex = 2;
            textBoxPass.UseSystemPasswordChar = true;
            textBoxPass.KeyPress += textBoxPass_KeyPress;
            textBoxPass.KeyUp += textBoxPass_KeyUp;
            // 
            // pictureBoxError
            // 
            pictureBoxError.Cursor = Cursors.Hand;
            pictureBoxError.Image = (Image)resources.GetObject("pictureBoxError.Image");
            pictureBoxError.Location = new Point(95, 231);
            pictureBoxError.Name = "pictureBoxError";
            pictureBoxError.Size = new Size(25, 24);
            pictureBoxError.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxError.TabIndex = 0;
            pictureBoxError.TabStop = false;
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxShow.Cursor = Cursors.Hand;
            pictureBoxShow.Image = (Image)resources.GetObject("pictureBoxShow.Image");
            pictureBoxShow.Location = new Point(325, 186);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Size = new Size(25, 24);
            pictureBoxShow.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxShow.TabIndex = 0;
            pictureBoxShow.TabStop = false;
            pictureBoxShow.Click += pictureBoxShow_Click;
            pictureBoxShow.MouseHover += pictureBoxShow_MouseHover;
            // 
            // pictureBoxHide
            // 
            pictureBoxHide.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHide.Cursor = Cursors.Hand;
            pictureBoxHide.Image = (Image)resources.GetObject("pictureBoxHide.Image");
            pictureBoxHide.Location = new Point(325, 186);
            pictureBoxHide.Name = "pictureBoxHide";
            pictureBoxHide.Size = new Size(25, 24);
            pictureBoxHide.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHide.TabIndex = 0;
            pictureBoxHide.TabStop = false;
            pictureBoxHide.Click += pictureBoxHide_Click;
            pictureBoxHide.MouseHover += pictureBoxHide_MouseHover;
            // 
            // buttonLogin
            // 
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Image = QL_Kho.Properties.Resources.enter;
            buttonLogin.Location = new Point(121, 328);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(218, 31);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Login";
            buttonLogin.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogin.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Century Gothic", 9F);
            labelError.ForeColor = Color.FromArgb(234, 73, 73);
            labelError.Location = new Point(121, 232);
            labelError.Name = "labelError";
            labelError.Size = new Size(229, 20);
            labelError.TabIndex = 0;
            labelError.Text = "Invalid username or password";
            // 
            // labelFP
            // 
            labelFP.AutoSize = true;
            labelFP.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            labelFP.Location = new Point(145, 290);
            labelFP.Name = "labelFP";
            labelFP.Size = new Size(153, 19);
            labelFP.TabIndex = 0;
            labelFP.Text = "Forgot password?";
            labelFP.Click += labelFP_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.Location = new Point(92, 148);
            label2.Name = "label2";
            label2.Size = new Size(88, 19);
            label2.TabIndex = 0;
            label2.Text = "password";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(95, 92);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(265, 28);
            textBoxName.TabIndex = 1;
            textBoxName.KeyPress += textBoxName_KeyPress;
            textBoxName.KeyUp += textBoxName_KeyUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label1.Location = new Point(92, 59);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 0;
            label1.Text = "username";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(696, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 408);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(818, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 331);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label3.Location = new Point(904, 518);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 0;
            label3.Text = "Quản lý kho";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBoxClose);
            Controls.Add(label3);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxMinimize;
        private GroupBox groupBox1;
        private Button buttonLogin;
        private TextBox textBoxName;
        private Label label1;
        private TextBox textBoxPass;
        private Label label2;
        private PictureBox pictureBoxHide;
        private PictureBox pictureBoxShow;
        private PictureBox pictureBoxError;
        private Label labelError;
        private Label labelFP;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private ToolTip toolTip;
    }
}