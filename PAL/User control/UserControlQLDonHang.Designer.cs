namespace QL_Kho.PAL.User_control
{
    partial class UserControlQLDonHang
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
            dataGridViewChitietgiaohang = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            buttonTimKiem = new Button();
            textBoxTimKiem = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateTimePickerNgayThucTe = new DateTimePicker();
            dateTimePickerNgayDuKien = new DateTimePicker();
            textBoxSoLuong = new TextBox();
            buttonUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChitietgiaohang).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewChitietgiaohang
            // 
            dataGridViewChitietgiaohang.BackgroundColor = Color.White;
            dataGridViewChitietgiaohang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChitietgiaohang.Location = new Point(23, 249);
            dataGridViewChitietgiaohang.Name = "dataGridViewChitietgiaohang";
            dataGridViewChitietgiaohang.RowHeadersWidth = 51;
            dataGridViewChitietgiaohang.Size = new Size(864, 203);
            dataGridViewChitietgiaohang.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(74, 47);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 24;
            label2.Text = "Số lượng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(369, 10);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 25;
            label1.Text = "Chi tiết giao hàng";
            // 
            // buttonTimKiem
            // 
            buttonTimKiem.Cursor = Cursors.Hand;
            buttonTimKiem.FlatAppearance.BorderSize = 0;
            buttonTimKiem.FlatStyle = FlatStyle.Flat;
            buttonTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTimKiem.Location = new Point(775, 37);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(81, 38);
            buttonTimKiem.TabIndex = 23;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = true;
            buttonTimKiem.Click += buttonTimKiem_Click;
            // 
            // textBoxTimKiem
            // 
            textBoxTimKiem.Location = new Point(583, 44);
            textBoxTimKiem.Name = "textBoxTimKiem";
            textBoxTimKiem.Size = new Size(175, 24);
            textBoxTimKiem.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(74, 117);
            label3.Name = "label3";
            label3.Size = new Size(121, 21);
            label3.TabIndex = 24;
            label3.Text = "Ngày dự kiến ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(460, 117);
            label4.Name = "label4";
            label4.Size = new Size(117, 21);
            label4.TabIndex = 24;
            label4.Text = "Ngày thực tế";
            // 
            // dateTimePickerNgayThucTe
            // 
            dateTimePickerNgayThucTe.Location = new Point(583, 114);
            dateTimePickerNgayThucTe.Name = "dateTimePickerNgayThucTe";
            dateTimePickerNgayThucTe.Size = new Size(250, 24);
            dateTimePickerNgayThucTe.TabIndex = 26;
            // 
            // dateTimePickerNgayDuKien
            // 
            dateTimePickerNgayDuKien.Location = new Point(195, 114);
            dateTimePickerNgayDuKien.Name = "dateTimePickerNgayDuKien";
            dateTimePickerNgayDuKien.Size = new Size(250, 24);
            dateTimePickerNgayDuKien.TabIndex = 26;
            // 
            // textBoxSoLuong
            // 
            textBoxSoLuong.Location = new Point(195, 44);
            textBoxSoLuong.Name = "textBoxSoLuong";
            textBoxSoLuong.Size = new Size(175, 24);
            textBoxSoLuong.TabIndex = 22;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUpdate.Location = new Point(752, 166);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(81, 38);
            buttonUpdate.TabIndex = 23;
            buttonUpdate.Text = "Cập nhật";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // UserControlQLDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dateTimePickerNgayDuKien);
            Controls.Add(dateTimePickerNgayThucTe);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonTimKiem);
            Controls.Add(textBoxSoLuong);
            Controls.Add(textBoxTimKiem);
            Controls.Add(dataGridViewChitietgiaohang);
            Font = new Font("Century Gothic", 8.25F);
            Name = "UserControlQLDonHang";
            Size = new Size(942, 476);
            ((System.ComponentModel.ISupportInitialize)dataGridViewChitietgiaohang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewChitietgiaohang;
        private Label label2;
        private Label label1;
        private Button buttonTimKiem;
        private TextBox textBoxTimKiem;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePickerNgayThucTe;
        private DateTimePicker dateTimePickerNgayDuKien;
        private TextBox textBoxSoLuong;
        private Button buttonUpdate;
    }
}
