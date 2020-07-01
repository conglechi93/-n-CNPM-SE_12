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
            this.lb_Adress = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.panel1.Controls.Add(this.lb_Adress);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 513);
            this.panel1.TabIndex = 0;
            // 
            // lb_Slogan
            // 
            this.lb_Slogan.AutoSize = true;
            this.lb_Slogan.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Slogan.ForeColor = System.Drawing.Color.Navy;
            this.lb_Slogan.Location = new System.Drawing.Point(293, 57);
            this.lb_Slogan.Name = "lb_Slogan";
            this.lb_Slogan.Size = new System.Drawing.Size(307, 32);
            this.lb_Slogan.TabIndex = 1;
            this.lb_Slogan.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // lb_Adress
            // 
            this.lb_Adress.AutoSize = true;
            this.lb_Adress.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Adress.ForeColor = System.Drawing.Color.Black;
            this.lb_Adress.Location = new System.Drawing.Point(456, 140);
            this.lb_Adress.Name = "lb_Adress";
            this.lb_Adress.Size = new System.Drawing.Size(323, 20);
            this.lb_Adress.TabIndex = 1;
            this.lb_Adress.Text = "Địa chỉ: Trường Đại học Bách Khoa Đà Nẵng";
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Phone.ForeColor = System.Drawing.Color.Black;
            this.lb_Phone.Location = new System.Drawing.Point(453, 44);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(198, 20);
            this.lb_Phone.TabIndex = 1;
            this.lb_Phone.Text = "Số điện thoại: 0000000abc";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 62);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CNPM_SE_12.Properties.Resources.login_logo;
            this.pictureBox1.Location = new System.Drawing.Point(31, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_ThanhToan);
            this.panel2.Controls.Add(this.lb_Phone);
            this.panel2.Controls.Add(this.DGV_Show);
            this.panel2.Controls.Add(this.lb_Time);
            this.panel2.Controls.Add(this.lb_BillID);
            this.panel2.Controls.Add(this.lb_UserID);
            this.panel2.Location = new System.Drawing.Point(3, 159);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 350);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lb_GiamGia);
            this.panel3.Controls.Add(this.lb_TongTien);
            this.panel3.Controls.Add(this.lb_ThanhTien);
            this.panel3.Location = new System.Drawing.Point(12, 250);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 91);
            this.panel3.TabIndex = 3;
            // 
            // lb_GiamGia
            // 
            this.lb_GiamGia.AutoSize = true;
            this.lb_GiamGia.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GiamGia.ForeColor = System.Drawing.Color.Black;
            this.lb_GiamGia.Location = new System.Drawing.Point(9, 38);
            this.lb_GiamGia.Name = "lb_GiamGia";
            this.lb_GiamGia.Size = new System.Drawing.Size(79, 20);
            this.lb_GiamGia.TabIndex = 0;
            this.lb_GiamGia.Text = "Giảm giá: ";
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.ForeColor = System.Drawing.Color.Black;
            this.lb_TongTien.Location = new System.Drawing.Point(9, 16);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(84, 20);
            this.lb_TongTien.TabIndex = 0;
            this.lb_TongTien.Text = "Tổng tiền: ";
            // 
            // lb_ThanhTien
            // 
            this.lb_ThanhTien.AutoSize = true;
            this.lb_ThanhTien.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThanhTien.ForeColor = System.Drawing.Color.Black;
            this.lb_ThanhTien.Location = new System.Drawing.Point(9, 59);
            this.lb_ThanhTien.Name = "lb_ThanhTien";
            this.lb_ThanhTien.Size = new System.Drawing.Size(94, 20);
            this.lb_ThanhTien.TabIndex = 0;
            this.lb_ThanhTien.Text = "Thành tiền: ";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_ThanhToan.Location = new System.Drawing.Point(575, 278);
            this.btn_ThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(188, 49);
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
            this.DGV_Show.Location = new System.Drawing.Point(25, 66);
            this.DGV_Show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_Show.Name = "DGV_Show";
            this.DGV_Show.ReadOnly = true;
            this.DGV_Show.RowHeadersWidth = 51;
            this.DGV_Show.RowTemplate.Height = 24;
            this.DGV_Show.Size = new System.Drawing.Size(760, 178);
            this.DGV_Show.TabIndex = 1;
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.ForeColor = System.Drawing.Color.Black;
            this.lb_Time.Location = new System.Drawing.Point(24, 41);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(111, 20);
            this.lb_Time.TabIndex = 0;
            this.lb_Time.Text = "Thời gian lập: ";
            // 
            // lb_BillID
            // 
            this.lb_BillID.AutoSize = true;
            this.lb_BillID.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BillID.ForeColor = System.Drawing.Color.Black;
            this.lb_BillID.Location = new System.Drawing.Point(453, 15);
            this.lb_BillID.Name = "lb_BillID";
            this.lb_BillID.Size = new System.Drawing.Size(101, 20);
            this.lb_BillID.TabIndex = 0;
            this.lb_BillID.Text = "Mã hoá đơn: ";
            // 
            // lb_UserID
            // 
            this.lb_UserID.AutoSize = true;
            this.lb_UserID.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserID.ForeColor = System.Drawing.Color.Black;
            this.lb_UserID.Location = new System.Drawing.Point(24, 15);
            this.lb_UserID.Name = "lb_UserID";
            this.lb_UserID.Size = new System.Drawing.Size(113, 20);
            this.lb_UserID.TabIndex = 0;
            this.lb_UserID.Text = "Mã nhân viên: ";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bill";
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