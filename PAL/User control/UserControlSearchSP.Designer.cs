namespace QL_Kho.PAL.User_control
{
    partial class UserControlSearchSP
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
            buttonTimKiem = new Button();
            textBoxTimKiem = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonTimKiem
            // 
            buttonTimKiem.Cursor = Cursors.Hand;
            buttonTimKiem.FlatAppearance.BorderSize = 0;
            buttonTimKiem.FlatStyle = FlatStyle.Flat;
            buttonTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTimKiem.Location = new Point(570, 46);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(81, 38);
            buttonTimKiem.TabIndex = 20;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = true;
            buttonTimKiem.Click += buttonTimKiem_Click;
            // 
            // textBoxTimKiem
            // 
            textBoxTimKiem.Location = new Point(378, 53);
            textBoxTimKiem.Name = "textBoxTimKiem";
            textBoxTimKiem.Size = new Size(175, 24);
            textBoxTimKiem.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(362, 16);
            label1.Name = "label1";
            label1.Size = new Size(174, 21);
            label1.TabIndex = 21;
            label1.Text = "Thông tin đơn hàng ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(228, 56);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 21;
            label2.Text = "Mã khách hàng";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(862, 180);
            dataGridView1.TabIndex = 22;
            // 
            // UserControlSearchSP
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonTimKiem);
            Controls.Add(textBoxTimKiem);
            Font = new Font("Century Gothic", 8.25F);
            Name = "UserControlSearchSP";
            Size = new Size(942, 476);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTimKiem;
        private TextBox textBoxTimKiem;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
    }
}
