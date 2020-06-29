namespace CNPM_SE_12.View
{
    partial class QuanLyBill
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_IdNhanVien = new System.Windows.Forms.TextBox();
            this.txt_IDItems = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.dtpk = new System.Windows.Forms.DateTimePicker();
            this.lb_ID = new System.Windows.Forms.Label();
            this.lb_IDItems = new System.Windows.Forms.Label();
            this.lb_IDNhanVien = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Reset);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 206);
            this.panel1.TabIndex = 0;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(635, 129);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(104, 41);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Làm mới";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(438, 129);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(104, 41);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_IdNhanVien);
            this.panel3.Controls.Add(this.txt_IDItems);
            this.panel3.Controls.Add(this.txt_ID);
            this.panel3.Controls.Add(this.dtpk);
            this.panel3.Controls.Add(this.lb_ID);
            this.panel3.Controls.Add(this.lb_IDItems);
            this.panel3.Controls.Add(this.lb_IDNhanVien);
            this.panel3.Controls.Add(this.lbTime);
            this.panel3.Location = new System.Drawing.Point(11, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 153);
            this.panel3.TabIndex = 4;
            // 
            // txt_IdNhanVien
            // 
            this.txt_IdNhanVien.Location = new System.Drawing.Point(134, 80);
            this.txt_IdNhanVien.Name = "txt_IdNhanVien";
            this.txt_IdNhanVien.Size = new System.Drawing.Size(200, 22);
            this.txt_IdNhanVien.TabIndex = 3;
            this.txt_IdNhanVien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_IDItems
            // 
            this.txt_IDItems.Location = new System.Drawing.Point(134, 47);
            this.txt_IDItems.Name = "txt_IDItems";
            this.txt_IDItems.Size = new System.Drawing.Size(200, 22);
            this.txt_IDItems.TabIndex = 3;
            this.txt_IDItems.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(134, 12);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(200, 22);
            this.txt_ID.TabIndex = 3;
            this.txt_ID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtpk
            // 
            this.dtpk.Location = new System.Drawing.Point(134, 114);
            this.dtpk.Name = "dtpk";
            this.dtpk.Size = new System.Drawing.Size(200, 22);
            this.dtpk.TabIndex = 2;
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(16, 12);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(99, 17);
            this.lb_ID.TabIndex = 0;
            this.lb_ID.Text = "Mã đơn hàng: ";
            // 
            // lb_IDItems
            // 
            this.lb_IDItems.AutoSize = true;
            this.lb_IDItems.Location = new System.Drawing.Point(16, 47);
            this.lb_IDItems.Name = "lb_IDItems";
            this.lb_IDItems.Size = new System.Drawing.Size(101, 17);
            this.lb_IDItems.TabIndex = 0;
            this.lb_IDItems.Text = "Mã sản phẩm: ";
            // 
            // lb_IDNhanVien
            // 
            this.lb_IDNhanVien.AutoSize = true;
            this.lb_IDNhanVien.Location = new System.Drawing.Point(16, 83);
            this.lb_IDNhanVien.Name = "lb_IDNhanVien";
            this.lb_IDNhanVien.Size = new System.Drawing.Size(101, 17);
            this.lb_IDNhanVien.TabIndex = 0;
            this.lb_IDNhanVien.Text = "Mã nhân viên: ";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(16, 120);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(75, 17);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Thời gian: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(1, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 241);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(797, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // QuanLyBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyBill";
            this.Size = new System.Drawing.Size(810, 466);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_IDNhanVien;
        private System.Windows.Forms.Label lb_IDItems;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpk;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_IdNhanVien;
        private System.Windows.Forms.TextBox txt_IDItems;
    }
}
