namespace CNPM_SE_12.View
{
    partial class Bill
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
            this.lb_Slogan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Adress = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_GiamGia = new System.Windows.Forms.Label();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.lb_ThanhTien = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.DGV_Show = new System.Windows.Forms.DataGridView();
            this.lb_Time = new System.Windows.Forms.Label();
            this.lb_BillID = new System.Windows.Forms.Label();
            this.lb_UserID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_Slogan);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 417);
            this.panel1.TabIndex = 0;
            // 
            // lb_Slogan
            // 
            this.lb_Slogan.AutoSize = true;
            this.lb_Slogan.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Slogan.ForeColor = System.Drawing.Color.Navy;
            this.lb_Slogan.Location = new System.Drawing.Point(214, 46);
            this.lb_Slogan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Slogan.Name = "lb_Slogan";
            this.lb_Slogan.Size = new System.Drawing.Size(271, 28);
            this.lb_Slogan.TabIndex = 1;
            this.lb_Slogan.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // button1
            // 
            this.button1.Image = global::CNPM_SE_12.Properties.Resources.Documents;
            this.button1.Location = new System.Drawing.Point(535, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 50);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CNPM_SE_12.Properties.Resources.login_logo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Adress
            // 
            this.lb_Adress.AutoSize = true;
            this.lb_Adress.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Adress.ForeColor = System.Drawing.Color.Black;
            this.lb_Adress.Location = new System.Drawing.Point(310, 5);
            this.lb_Adress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Adress.Name = "lb_Adress";
            this.lb_Adress.Size = new System.Drawing.Size(279, 17);
            this.lb_Adress.TabIndex = 1;
            this.lb_Adress.Text = "Địa chỉ: Trường Đại học Bách Khoa Đà Nẵng";
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Phone.ForeColor = System.Drawing.Color.Black;
            this.lb_Phone.Location = new System.Drawing.Point(310, 39);
            this.lb_Phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(173, 17);
            this.lb_Phone.TabIndex = 1;
            this.lb_Phone.Text = "Số điện thoại: 0000000abc";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lb_Adress);
            this.panel2.Controls.Add(this.btn_ThanhToan);
            this.panel2.Controls.Add(this.lb_Phone);
            this.panel2.Controls.Add(this.DGV_Show);
            this.panel2.Controls.Add(this.lb_Time);
            this.panel2.Controls.Add(this.lb_BillID);
            this.panel2.Controls.Add(this.lb_UserID);
            this.panel2.Location = new System.Drawing.Point(2, 122);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 291);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lb_GiamGia);
            this.panel3.Controls.Add(this.lb_TongTien);
            this.panel3.Controls.Add(this.lb_ThanhTien);
            this.panel3.Location = new System.Drawing.Point(9, 213);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 74);
            this.panel3.TabIndex = 3;
            // 
            // lb_GiamGia
            // 
            this.lb_GiamGia.AutoSize = true;
            this.lb_GiamGia.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GiamGia.ForeColor = System.Drawing.Color.Black;
            this.lb_GiamGia.Location = new System.Drawing.Point(7, 31);
            this.lb_GiamGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_GiamGia.Name = "lb_GiamGia";
            this.lb_GiamGia.Size = new System.Drawing.Size(68, 17);
            this.lb_GiamGia.TabIndex = 0;
            this.lb_GiamGia.Text = "Giảm giá: ";
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.ForeColor = System.Drawing.Color.Black;
            this.lb_TongTien.Location = new System.Drawing.Point(7, 14);
            this.lb_TongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(73, 17);
            this.lb_TongTien.TabIndex = 0;
            this.lb_TongTien.Text = "Tổng tiền: ";
            // 
            // lb_ThanhTien
            // 
            this.lb_ThanhTien.AutoSize = true;
            this.lb_ThanhTien.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThanhTien.ForeColor = System.Drawing.Color.Black;
            this.lb_ThanhTien.Location = new System.Drawing.Point(7, 48);
            this.lb_ThanhTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ThanhTien.Name = "lb_ThanhTien";
            this.lb_ThanhTien.Size = new System.Drawing.Size(82, 17);
            this.lb_ThanhTien.TabIndex = 0;
            this.lb_ThanhTien.Text = "Thành tiền: ";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_ThanhToan.Location = new System.Drawing.Point(431, 236);
            this.btn_ThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(141, 40);
            this.btn_ThanhToan.TabIndex = 2;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // DGV_Show
            // 
            this.DGV_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Show.Enabled = false;
            this.DGV_Show.Location = new System.Drawing.Point(19, 64);
            this.DGV_Show.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_Show.Name = "DGV_Show";
            this.DGV_Show.ReadOnly = true;
            this.DGV_Show.RowHeadersWidth = 51;
            this.DGV_Show.RowTemplate.Height = 24;
            this.DGV_Show.Size = new System.Drawing.Size(570, 145);
            this.DGV_Show.TabIndex = 1;
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.ForeColor = System.Drawing.Color.Black;
            this.lb_Time.Location = new System.Drawing.Point(16, 39);
            this.lb_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(96, 17);
            this.lb_Time.TabIndex = 0;
            this.lb_Time.Text = "Thời gian lập: ";
            // 
            // lb_BillID
            // 
            this.lb_BillID.AutoSize = true;
            this.lb_BillID.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BillID.ForeColor = System.Drawing.Color.Black;
            this.lb_BillID.Location = new System.Drawing.Point(310, 22);
            this.lb_BillID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_BillID.Name = "lb_BillID";
            this.lb_BillID.Size = new System.Drawing.Size(88, 17);
            this.lb_BillID.TabIndex = 0;
            this.lb_BillID.Text = "Mã hoá đơn: ";
            // 
            // lb_UserID
            // 
            this.lb_UserID.AutoSize = true;
            this.lb_UserID.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserID.ForeColor = System.Drawing.Color.Black;
            this.lb_UserID.Location = new System.Drawing.Point(16, 22);
            this.lb_UserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_UserID.Name = "lb_UserID";
            this.lb_UserID.Size = new System.Drawing.Size(98, 17);
            this.lb_UserID.TabIndex = 0;
            this.lb_UserID.Text = "Mã nhân viên: ";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(600, 417);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_Slogan;
        private System.Windows.Forms.Label lb_Adress;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGV_Show;
        private System.Windows.Forms.Label lb_ThanhTien;
        private System.Windows.Forms.Label lb_GiamGia;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Label lb_UserID;
        private System.Windows.Forms.Label lb_BillID;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Panel panel3;
    }
}