namespace QL_Kho.PAL.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonCn1 = new Button();
            panel3 = new Panel();
            buttonReport = new Button();
            buttonCn4 = new Button();
            buttonCn3 = new Button();
            buttonCn2 = new Button();
            buttonDashboard = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelBack = new Panel();
            panelExpand = new Panel();
            buttonLogOut = new Button();
            buttonMinimize = new Button();
            pictureBoxExpand = new PictureBox();
            pictureBox2 = new PictureBox();
            labelTime = new Label();
            panelTop = new Panel();
            labelRole = new Label();
            labelUsername = new Label();
            label5 = new Label();
            label3 = new Label();
            timerDateTime = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBack.SuspendLayout();
            panelExpand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(buttonCn1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(buttonReport);
            panel1.Controls.Add(buttonCn4);
            panel1.Controls.Add(buttonCn3);
            panel1.Controls.Add(buttonCn2);
            panel1.Controls.Add(buttonDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 720);
            panel1.TabIndex = 0;
            // 
            // buttonCn1
            // 
            buttonCn1.Cursor = Cursors.Hand;
            buttonCn1.FlatAppearance.BorderSize = 0;
            buttonCn1.FlatStyle = FlatStyle.Flat;
            buttonCn1.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCn1.Location = new Point(29, 315);
            buttonCn1.Name = "buttonCn1";
            buttonCn1.Size = new Size(207, 53);
            buttonCn1.TabIndex = 0;
            buttonCn1.Text = "Tìm kiếm sản phẩm";
            buttonCn1.UseVisualStyleBackColor = true;
            buttonCn1.Click += buttonCn1_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 207);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 513);
            panel3.TabIndex = 1;
            // 
            // buttonReport
            // 
            buttonReport.Cursor = Cursors.Hand;
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReport.Location = new Point(29, 551);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(207, 53);
            buttonReport.TabIndex = 0;
            buttonReport.Text = "Tạo mới User";
            buttonReport.UseVisualStyleBackColor = true;
            buttonReport.Click += buttonReport_Click;
            // 
            // buttonCn4
            // 
            buttonCn4.Cursor = Cursors.Hand;
            buttonCn4.FlatAppearance.BorderSize = 0;
            buttonCn4.FlatStyle = FlatStyle.Flat;
            buttonCn4.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCn4.Location = new Point(29, 492);
            buttonCn4.Name = "buttonCn4";
            buttonCn4.Size = new Size(207, 53);
            buttonCn4.TabIndex = 0;
            buttonCn4.Text = "Chức năng 4";
            buttonCn4.UseVisualStyleBackColor = true;
            // 
            // buttonCn3
            // 
            buttonCn3.Cursor = Cursors.Hand;
            buttonCn3.FlatAppearance.BorderSize = 0;
            buttonCn3.FlatStyle = FlatStyle.Flat;
            buttonCn3.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCn3.Location = new Point(29, 433);
            buttonCn3.Name = "buttonCn3";
            buttonCn3.Size = new Size(207, 53);
            buttonCn3.TabIndex = 0;
            buttonCn3.Text = "Chức năng 3";
            buttonCn3.UseVisualStyleBackColor = true;
            // 
            // buttonCn2
            // 
            buttonCn2.Cursor = Cursors.Hand;
            buttonCn2.FlatAppearance.BorderSize = 0;
            buttonCn2.FlatStyle = FlatStyle.Flat;
            buttonCn2.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCn2.Location = new Point(29, 374);
            buttonCn2.Name = "buttonCn2";
            buttonCn2.Size = new Size(207, 53);
            buttonCn2.TabIndex = 0;
            buttonCn2.Text = "Add Sản Phẩm ";
            buttonCn2.UseVisualStyleBackColor = true;
            buttonCn2.Click += buttonCn2_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.Cursor = Cursors.Hand;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(29, 256);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(207, 53);
            buttonDashboard.TabIndex = 0;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.UseVisualStyleBackColor = true;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 207);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 157);
            label1.Name = "label1";
            label1.Size = new Size(107, 19);
            label1.TabIndex = 1;
            label1.Text = "Quản lý kho";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.management1;
            pictureBox1.Location = new Point(80, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelBack
            // 
            panelBack.Controls.Add(panelExpand);
            panelBack.Controls.Add(pictureBoxExpand);
            panelBack.Controls.Add(pictureBox2);
            panelBack.Controls.Add(labelTime);
            panelBack.Controls.Add(panelTop);
            panelBack.Dock = DockStyle.Top;
            panelBack.Location = new Point(256, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(944, 176);
            panelBack.TabIndex = 0;
            // 
            // panelExpand
            // 
            panelExpand.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelExpand.BackColor = Color.WhiteSmoke;
            panelExpand.BorderStyle = BorderStyle.FixedSingle;
            panelExpand.Controls.Add(buttonLogOut);
            panelExpand.Controls.Add(buttonMinimize);
            panelExpand.Location = new Point(699, 55);
            panelExpand.Name = "panelExpand";
            panelExpand.Size = new Size(233, 121);
            panelExpand.TabIndex = 0;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Cursor = Cursors.Hand;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogOut.Location = new Point(0, 62);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(231, 58);
            buttonLogOut.TabIndex = 0;
            buttonLogOut.Text = "Logout";
            buttonLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonMinimize
            // 
            buttonMinimize.Cursor = Cursors.Hand;
            buttonMinimize.Dock = DockStyle.Top;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.ImageAlign = ContentAlignment.MiddleLeft;
            buttonMinimize.Location = new Point(0, 0);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(231, 56);
            buttonMinimize.TabIndex = 0;
            buttonMinimize.Text = "Thu nhỏ";
            buttonMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMinimize.UseVisualStyleBackColor = true;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxExpand.Cursor = Cursors.Hand;
            pictureBoxExpand.Image = (Image)resources.GetObject("pictureBoxExpand.Image");
            pictureBoxExpand.Location = new Point(789, 34);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(27, 24);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 2;
            pictureBoxExpand.TabStop = false;
            pictureBoxExpand.Click += pictureBoxExpand_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.graduated;
            pictureBox2.Location = new Point(723, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.ForeColor = SystemColors.ControlDark;
            labelTime.Location = new Point(50, 21);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(31, 19);
            labelTime.TabIndex = 0;
            labelTime.Text = "{?}";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.WhiteSmoke;
            panelTop.Controls.Add(labelRole);
            panelTop.Controls.Add(labelUsername);
            panelTop.Controls.Add(label5);
            panelTop.Controls.Add(label3);
            panelTop.Dock = DockStyle.Bottom;
            panelTop.Location = new Point(0, 67);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(944, 109);
            panelTop.TabIndex = 0;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.ForeColor = Color.Black;
            labelRole.Location = new Point(154, 57);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(31, 19);
            labelRole.TabIndex = 0;
            labelRole.Text = "{?}";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.ForeColor = Color.Black;
            labelUsername.Location = new Point(154, 22);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(31, 19);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "{?}";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(50, 57);
            label5.Name = "label5";
            label5.Size = new Size(45, 19);
            label5.TabIndex = 0;
            label5.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(50, 22);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 0;
            label3.Text = "Hello";
            // 
            // timerDateTime
            // 
            timerDateTime.Tick += timerDateTime_Tick;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(256, 173);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(944, 547);
            panelContainer.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(panelContainer);
            Controls.Add(panelBack);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance Studen System";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            panelExpand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panelBack;
        private Label labelTime;
        private Panel panelTop;
        private Label labelRole;
        private Label labelUsername;
        private Label label5;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxExpand;
        private Panel panelExpand;
        private Button buttonMinimize;
        private Button buttonLogOut;
        private Button buttonDashboard;
        private Button buttonReport;
        private Button buttonCn4;
        private Button buttonCn3;
        private Button buttonCn2;
        private System.Windows.Forms.Timer timerDateTime;
        private Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panelContainer;
        private Button buttonCn1;
    }
}