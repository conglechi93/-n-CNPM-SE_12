namespace CNPM_SE_12.View
{
    partial class QL_User
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
            this.grb_NhanVien = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb_Female = new System.Windows.Forms.RadioButton();
            this.rdb_Male = new System.Windows.Forms.RadioButton();
            this.txt_ShiftTime = new System.Windows.Forms.TextBox();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TenNhanVien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Del = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbb_LoaiHang = new System.Windows.Forms.ComboBox();
            this.grb_NhanVien.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_NhanVien
            // 
            this.grb_NhanVien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grb_NhanVien.Controls.Add(this.cbb_LoaiHang);
            this.grb_NhanVien.Controls.Add(this.dateTimePicker1);
            this.grb_NhanVien.Controls.Add(this.groupBox2);
            this.grb_NhanVien.Controls.Add(this.txt_ShiftTime);
            this.grb_NhanVien.Controls.Add(this.txt_CMND);
            this.grb_NhanVien.Controls.Add(this.txt_DiaChi);
            this.grb_NhanVien.Controls.Add(this.txt_SoDienThoai);
            this.grb_NhanVien.Controls.Add(this.label7);
            this.grb_NhanVien.Controls.Add(this.txt_TenNhanVien);
            this.grb_NhanVien.Controls.Add(this.label8);
            this.grb_NhanVien.Controls.Add(this.label6);
            this.grb_NhanVien.Controls.Add(this.txt_MaNhanVien);
            this.grb_NhanVien.Controls.Add(this.label4);
            this.grb_NhanVien.Controls.Add(this.label5);
            this.grb_NhanVien.Controls.Add(this.label3);
            this.grb_NhanVien.Controls.Add(this.label2);
            this.grb_NhanVien.Controls.Add(this.label1);
            this.grb_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_NhanVien.ForeColor = System.Drawing.Color.SteelBlue;
            this.grb_NhanVien.Location = new System.Drawing.Point(276, 20);
            this.grb_NhanVien.Name = "grb_NhanVien";
            this.grb_NhanVien.Size = new System.Drawing.Size(507, 148);
            this.grb_NhanVien.TabIndex = 2;
            this.grb_NhanVien.TabStop = false;
            this.grb_NhanVien.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(292, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb_Female);
            this.groupBox2.Controls.Add(this.rdb_Male);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(322, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 46);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giới tính";
            // 
            // rdb_Female
            // 
            this.rdb_Female.AutoSize = true;
            this.rdb_Female.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdb_Female.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Female.Location = new System.Drawing.Point(113, 18);
            this.rdb_Female.Name = "rdb_Female";
            this.rdb_Female.Size = new System.Drawing.Size(41, 19);
            this.rdb_Female.TabIndex = 5;
            this.rdb_Female.TabStop = true;
            this.rdb_Female.Text = "Nữ";
            this.rdb_Female.UseVisualStyleBackColor = true;
            // 
            // rdb_Male
            // 
            this.rdb_Male.AutoSize = true;
            this.rdb_Male.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdb_Male.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Male.Location = new System.Drawing.Point(33, 18);
            this.rdb_Male.Name = "rdb_Male";
            this.rdb_Male.Size = new System.Drawing.Size(50, 19);
            this.rdb_Male.TabIndex = 5;
            this.rdb_Male.TabStop = true;
            this.rdb_Male.Text = "Nam";
            this.rdb_Male.UseVisualStyleBackColor = true;
            // 
            // txt_ShiftTime
            // 
            this.txt_ShiftTime.BackColor = System.Drawing.Color.LightGray;
            this.txt_ShiftTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ShiftTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ShiftTime.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_ShiftTime.Location = new System.Drawing.Point(218, 124);
            this.txt_ShiftTime.Name = "txt_ShiftTime";
            this.txt_ShiftTime.Size = new System.Drawing.Size(128, 14);
            this.txt_ShiftTime.TabIndex = 4;
            // 
            // txt_CMND
            // 
            this.txt_CMND.BackColor = System.Drawing.Color.LightGray;
            this.txt_CMND.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CMND.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_CMND.Location = new System.Drawing.Point(155, 84);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(128, 14);
            this.txt_CMND.TabIndex = 4;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BackColor = System.Drawing.Color.LightGray;
            this.txt_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_DiaChi.Location = new System.Drawing.Point(9, 124);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(204, 14);
            this.txt_DiaChi.TabIndex = 4;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.BackColor = System.Drawing.Color.LightGray;
            this.txt_SoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDienThoai.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_SoDienThoai.Location = new System.Drawing.Point(9, 84);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(128, 14);
            this.txt_SoDienThoai.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(353, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Loại tài khoản";
            // 
            // txt_TenNhanVien
            // 
            this.txt_TenNhanVien.BackColor = System.Drawing.Color.LightGray;
            this.txt_TenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNhanVien.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_TenNhanVien.Location = new System.Drawing.Point(155, 37);
            this.txt_TenNhanVien.Name = "txt_TenNhanVien";
            this.txt_TenNhanVien.Size = new System.Drawing.Size(160, 14);
            this.txt_TenNhanVien.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(289, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Birthday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(215, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số ngày làm";
            // 
            // txt_MaNhanVien
            // 
            this.txt_MaNhanVien.BackColor = System.Drawing.Color.LightGray;
            this.txt_MaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNhanVien.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_MaNhanVien.Location = new System.Drawing.Point(9, 37);
            this.txt_MaNhanVien.Name = "txt_MaNhanVien";
            this.txt_MaNhanVien.Size = new System.Drawing.Size(128, 14);
            this.txt_MaNhanVien.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(152, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "CMND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(152, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã nhân viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(766, 298);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.btn_Del);
            this.panel1.Controls.Add(this.Reset);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Location = new System.Drawing.Point(31, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 162);
            this.panel1.TabIndex = 4;
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Del.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.ForeColor = System.Drawing.Color.White;
            this.btn_Del.Image = global::CNPM_SE_12.Properties.Resources.user_cross;
            this.btn_Del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Del.Location = new System.Drawing.Point(115, 45);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(101, 36);
            this.btn_Del.TabIndex = 1;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Del.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.SlateBlue;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.White;
            this.Reset.Image = global::CNPM_SE_12.Properties.Resources.package_white;
            this.Reset.Location = new System.Drawing.Point(3, 45);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(101, 36);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Reset";
            this.Reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Image = global::CNPM_SE_12.Properties.Resources.disk_upload;
            this.btn_Update.Location = new System.Drawing.Point(115, 3);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(101, 36);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Image = global::CNPM_SE_12.Properties.Resources.user_b;
            this.btn_Add.Location = new System.Drawing.Point(3, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(101, 36);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.LightGray;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Search.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Search.Location = new System.Drawing.Point(3, 89);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(213, 16);
            this.txt_Search.TabIndex = 4;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Image = global::CNPM_SE_12.Properties.Resources.user_magnify;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(60, 114);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(101, 36);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // cbb_LoaiHang
            // 
            this.cbb_LoaiHang.BackColor = System.Drawing.Color.LightGray;
            this.cbb_LoaiHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_LoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LoaiHang.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbb_LoaiHang.FormattingEnabled = true;
            this.cbb_LoaiHang.Location = new System.Drawing.Point(355, 120);
            this.cbb_LoaiHang.Name = "cbb_LoaiHang";
            this.cbb_LoaiHang.Size = new System.Drawing.Size(141, 23);
            this.cbb_LoaiHang.TabIndex = 10;
            // 
            // QL_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grb_NhanVien);
            this.Name = "QL_User";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.QL_User_Load);
            this.grb_NhanVien.ResumeLayout(false);
            this.grb_NhanVien.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grb_NhanVien;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.TextBox txt_TenNhanVien;
        private System.Windows.Forms.TextBox txt_MaNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdb_Female;
        private System.Windows.Forms.RadioButton rdb_Male;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_ShiftTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbb_LoaiHang;
    }
}
