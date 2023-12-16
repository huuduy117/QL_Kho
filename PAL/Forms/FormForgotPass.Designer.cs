namespace DiemdanhSV.PAL.Forms
{
    partial class FormForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgotPass));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBoxError1 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBoxCloseFP = new PictureBox();
            buttonVerify = new Button();
            label1 = new Label();
            textBoxEmail = new TextBox();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseFP).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBoxError1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBoxCloseFP);
            panel1.Controls.Add(buttonVerify);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxEmail);
            panel1.ForeColor = Color.DarkGray;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 482);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.ForeColor = Color.LightGray;
            panel2.Location = new Point(145, 336);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 2);
            panel2.TabIndex = 0;
            // 
            // pictureBoxError1
            // 
            pictureBoxError1.Cursor = Cursors.Hand;
            pictureBoxError1.Image = (Image)resources.GetObject("pictureBoxError1.Image");
            pictureBoxError1.Location = new Point(385, 306);
            pictureBoxError1.Name = "pictureBoxError1";
            pictureBoxError1.Size = new Size(25, 24);
            pictureBoxError1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxError1.TabIndex = 4;
            pictureBoxError1.TabStop = false;
            pictureBoxError1.MouseHover += pictureBoxError1_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(199, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxCloseFP
            // 
            pictureBoxCloseFP.Cursor = Cursors.Hand;
            pictureBoxCloseFP.Image = (Image)resources.GetObject("pictureBoxCloseFP.Image");
            pictureBoxCloseFP.Location = new Point(525, 12);
            pictureBoxCloseFP.Name = "pictureBoxCloseFP";
            pictureBoxCloseFP.Size = new Size(31, 31);
            pictureBoxCloseFP.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCloseFP.TabIndex = 1;
            pictureBoxCloseFP.TabStop = false;
            pictureBoxCloseFP.Click += pictureBoxClose_Click;
            pictureBoxCloseFP.MouseHover += pictureBoxClose_MouseHover;
            // 
            // buttonVerify
            // 
            buttonVerify.Cursor = Cursors.Hand;
            buttonVerify.FlatAppearance.BorderSize = 0;
            buttonVerify.FlatStyle = FlatStyle.Flat;
            buttonVerify.Image = QL_Kho.Properties.Resources.enter;
            buttonVerify.Location = new Point(171, 384);
            buttonVerify.Name = "buttonVerify";
            buttonVerify.Size = new Size(218, 31);
            buttonVerify.TabIndex = 2;
            buttonVerify.Text = "Verify";
            buttonVerify.TextAlign = ContentAlignment.MiddleLeft;
            buttonVerify.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonVerify.UseVisualStyleBackColor = true;
            buttonVerify.Click += buttonVerify_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(142, 273);
            label1.Name = "label1";
            label1.Size = new Size(55, 19);
            label1.TabIndex = 0;
            label1.Text = "email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = SystemColors.ButtonHighlight;
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Century Gothic", 10F);
            textBoxEmail.ForeColor = Color.DarkGray;
            textBoxEmail.Location = new Point(145, 306);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(234, 21);
            textBoxEmail.TabIndex = 1;
            textBoxEmail.Text = "example@gmail.com";
            textBoxEmail.Enter += textBoxEmail_Enter;
            textBoxEmail.Leave += textBoxEmail_Leave;
            // 
            // FormForgotPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(593, 506);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormForgotPass";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormForgotPass_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseFP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxCloseFP;
        private PictureBox pictureBoxError1;
        private Button buttonVerify;
        private Label label1;
        private TextBox textBoxEmail;
        private PictureBox pictureBox1;
        private Panel panel2;
        private ToolTip toolTip1;
    }
}