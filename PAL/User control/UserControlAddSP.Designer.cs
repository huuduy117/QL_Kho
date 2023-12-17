namespace QL_Kho.PAL.User_control
{
    partial class UserControlAddSP
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_msp = new TextBox();
            txt_tsp = new TextBox();
            txt_sltt = new TextBox();
            txt_mtsp = new TextBox();
            bt_them = new Button();
            bt_xoa = new Button();
            bt_sua = new Button();
            dataGridView1 = new DataGridView();
            cbb_dmsp = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 195);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Mô tả sản phẩm ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 80);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 121);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 0;
            label3.Text = "Số lượng tối thiểu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 121);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 0;
            label4.Text = "Tên sản phẩm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(345, 83);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 0;
            label5.Text = "Danh mục sản phẩm";
            // 
            // txt_msp
            // 
            txt_msp.Location = new Point(127, 73);
            txt_msp.Name = "txt_msp";
            txt_msp.Size = new Size(212, 27);
            txt_msp.TabIndex = 1;
            // 
            // txt_tsp
            // 
            txt_tsp.Location = new Point(127, 114);
            txt_tsp.Name = "txt_tsp";
            txt_tsp.Size = new Size(212, 27);
            txt_tsp.TabIndex = 1;
            // 
            // txt_sltt
            // 
            txt_sltt.Location = new Point(501, 114);
            txt_sltt.Name = "txt_sltt";
            txt_sltt.Size = new Size(160, 27);
            txt_sltt.TabIndex = 1;
            // 
            // txt_mtsp
            // 
            txt_mtsp.Location = new Point(149, 158);
            txt_mtsp.Multiline = true;
            txt_mtsp.Name = "txt_mtsp";
            txt_mtsp.Size = new Size(512, 101);
            txt_mtsp.TabIndex = 2;
            // 
            // bt_them
            // 
            bt_them.Location = new Point(105, 25);
            bt_them.Name = "bt_them";
            bt_them.Size = new Size(94, 29);
            bt_them.TabIndex = 3;
            bt_them.Text = "Thêm";
            bt_them.UseVisualStyleBackColor = true;
            bt_them.Click += bt_them_Click;
            // 
            // bt_xoa
            // 
            bt_xoa.Location = new Point(256, 25);
            bt_xoa.Name = "bt_xoa";
            bt_xoa.Size = new Size(94, 29);
            bt_xoa.TabIndex = 4;
            bt_xoa.Text = "Xóa";
            bt_xoa.UseVisualStyleBackColor = true;
            bt_xoa.Click += bt_xoa_Click;
            // 
            // bt_sua
            // 
            bt_sua.Location = new Point(409, 25);
            bt_sua.Name = "bt_sua";
            bt_sua.Size = new Size(94, 29);
            bt_sua.TabIndex = 5;
            bt_sua.Text = "Sửa";
            bt_sua.UseVisualStyleBackColor = true;
            bt_sua.Click += bt_sua_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 277);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(638, 195);
            dataGridView1.TabIndex = 6;
            // 
            // cbb_dmsp
            // 
            cbb_dmsp.FormattingEnabled = true;
            cbb_dmsp.Location = new Point(501, 73);
            cbb_dmsp.Name = "cbb_dmsp";
            cbb_dmsp.Size = new Size(160, 28);
            cbb_dmsp.TabIndex = 7;
            // 
            // UserControlAddSP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbb_dmsp);
            Controls.Add(dataGridView1);
            Controls.Add(bt_sua);
            Controls.Add(bt_xoa);
            Controls.Add(bt_them);
            Controls.Add(txt_mtsp);
            Controls.Add(txt_sltt);
            Controls.Add(txt_tsp);
            Controls.Add(txt_msp);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControlAddSP";
            Size = new Size(766, 490);
            Load += UserControlAddSP_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_msp;
        private TextBox txt_tsp;
        private TextBox txt_sltt;
        private TextBox txt_mtsp;
        private Button bt_them;
        private Button bt_xoa;
        private Button bt_sua;
        private DataGridView dataGridView1;
        private ComboBox cbb_dmsp;
    }
}
