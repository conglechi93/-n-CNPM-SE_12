﻿namespace CNPM_SE_12.View
{
    partial class FormManager
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
            this.components = new System.ComponentModel.Container();
            this.btnOut = new System.Windows.Forms.Button();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.pnl_ButtonMenu = new System.Windows.Forms.Panel();
            this.btn_QLTaiKhoan = new System.Windows.Forms.Button();
            this.btn_GopY = new System.Windows.Forms.Button();
            this.btn_DiemDanh = new System.Windows.Forms.Button();
            this.btn_QLDoanhThu = new System.Windows.Forms.Button();
            this.btn_NVManager = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btn_Main = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl_ShowForm = new System.Windows.Forms.Panel();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Menu.SuspendLayout();
            this.pnl_ButtonMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.OliveDrab;
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.ForeColor = System.Drawing.Color.White;
            this.btnOut.Location = new System.Drawing.Point(256, 0);
            this.btnOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(101, 28);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "Đăng xuất";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click_1);
            this.btnOut.MouseLeave += new System.EventHandler(this.BtnOut_MouseLeave);
            this.btnOut.MouseHover += new System.EventHandler(this.BtnOut_MouseHover);
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.White;
            this.pnl_Menu.Controls.Add(this.pnl_ButtonMenu);
            this.pnl_Menu.Controls.Add(this.panel4);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(234, 559);
            this.pnl_Menu.TabIndex = 3;
            // 
            // pnl_ButtonMenu
            // 
            this.pnl_ButtonMenu.Controls.Add(this.btn_QLTaiKhoan);
            this.pnl_ButtonMenu.Controls.Add(this.btn_GopY);
            this.pnl_ButtonMenu.Controls.Add(this.btn_DiemDanh);
            this.pnl_ButtonMenu.Controls.Add(this.btn_QLDoanhThu);
            this.pnl_ButtonMenu.Controls.Add(this.btn_NVManager);
            this.pnl_ButtonMenu.Controls.Add(this.btnSetting);
            this.pnl_ButtonMenu.Controls.Add(this.btn_Main);
            this.pnl_ButtonMenu.Location = new System.Drawing.Point(2, 212);
            this.pnl_ButtonMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_ButtonMenu.Name = "pnl_ButtonMenu";
            this.pnl_ButtonMenu.Size = new System.Drawing.Size(226, 345);
            this.pnl_ButtonMenu.TabIndex = 1;
            // 
            // btn_QLTaiKhoan
            // 
            this.btn_QLTaiKhoan.BackColor = System.Drawing.Color.Gray;
            this.btn_QLTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btn_QLTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLTaiKhoan.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btn_QLTaiKhoan.Image = global::CNPM_SE_12.Properties.Resources.Settings;
            this.btn_QLTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLTaiKhoan.Location = new System.Drawing.Point(1, 296);
            this.btn_QLTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_QLTaiKhoan.Name = "btn_QLTaiKhoan";
            this.btn_QLTaiKhoan.Size = new System.Drawing.Size(222, 45);
            this.btn_QLTaiKhoan.TabIndex = 0;
            this.btn_QLTaiKhoan.Tag = "7";
            this.btn_QLTaiKhoan.Text = "Quản lí tài khoản";
            this.btn_QLTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_QLTaiKhoan.UseVisualStyleBackColor = false;
            this.btn_QLTaiKhoan.Click += new System.EventHandler(this.MenuClick);
            // 
            // btn_GopY
            // 
            this.btn_GopY.BackColor = System.Drawing.Color.Gray;
            this.btn_GopY.FlatAppearance.BorderSize = 0;
            this.btn_GopY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GopY.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GopY.ForeColor = System.Drawing.Color.White;
            this.btn_GopY.Image = global::CNPM_SE_12.Properties.Resources.Mail;
            this.btn_GopY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GopY.Location = new System.Drawing.Point(1, 247);
            this.btn_GopY.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GopY.Name = "btn_GopY";
            this.btn_GopY.Size = new System.Drawing.Size(223, 45);
            this.btn_GopY.TabIndex = 0;
            this.btn_GopY.Tag = "6";
            this.btn_GopY.Text = "Góp ý/Phản hồi";
            this.btn_GopY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GopY.UseVisualStyleBackColor = false;
            this.btn_GopY.Click += new System.EventHandler(this.MenuClick);
            // 
            // btn_DiemDanh
            // 
            this.btn_DiemDanh.BackColor = System.Drawing.Color.Gray;
            this.btn_DiemDanh.FlatAppearance.BorderSize = 0;
            this.btn_DiemDanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DiemDanh.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DiemDanh.ForeColor = System.Drawing.Color.White;
            this.btn_DiemDanh.Image = global::CNPM_SE_12.Properties.Resources.Select;
            this.btn_DiemDanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DiemDanh.Location = new System.Drawing.Point(2, 198);
            this.btn_DiemDanh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DiemDanh.Name = "btn_DiemDanh";
            this.btn_DiemDanh.Size = new System.Drawing.Size(222, 45);
            this.btn_DiemDanh.TabIndex = 0;
            this.btn_DiemDanh.Tag = "5";
            this.btn_DiemDanh.Text = "Điểm danh";
            this.btn_DiemDanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DiemDanh.UseVisualStyleBackColor = false;
            this.btn_DiemDanh.Click += new System.EventHandler(this.MenuClick);
            // 
            // btn_QLDoanhThu
            // 
            this.btn_QLDoanhThu.BackColor = System.Drawing.Color.Gray;
            this.btn_QLDoanhThu.FlatAppearance.BorderSize = 0;
            this.btn_QLDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLDoanhThu.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btn_QLDoanhThu.Image = global::CNPM_SE_12.Properties.Resources.Stats;
            this.btn_QLDoanhThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLDoanhThu.Location = new System.Drawing.Point(2, 149);
            this.btn_QLDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_QLDoanhThu.Name = "btn_QLDoanhThu";
            this.btn_QLDoanhThu.Size = new System.Drawing.Size(222, 45);
            this.btn_QLDoanhThu.TabIndex = 0;
            this.btn_QLDoanhThu.Tag = "4";
            this.btn_QLDoanhThu.Text = "Quản lí doanh thu";
            this.btn_QLDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_QLDoanhThu.UseVisualStyleBackColor = false;
            this.btn_QLDoanhThu.Click += new System.EventHandler(this.MenuClick);
            // 
            // btn_NVManager
            // 
            this.btn_NVManager.BackColor = System.Drawing.Color.Gray;
            this.btn_NVManager.FlatAppearance.BorderSize = 0;
            this.btn_NVManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NVManager.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NVManager.ForeColor = System.Drawing.Color.White;
            this.btn_NVManager.Image = global::CNPM_SE_12.Properties.Resources.User;
            this.btn_NVManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NVManager.Location = new System.Drawing.Point(2, 100);
            this.btn_NVManager.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NVManager.Name = "btn_NVManager";
            this.btn_NVManager.Size = new System.Drawing.Size(222, 45);
            this.btn_NVManager.TabIndex = 0;
            this.btn_NVManager.Tag = "3";
            this.btn_NVManager.Text = "Quản lí nhân viên";
            this.btn_NVManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NVManager.UseVisualStyleBackColor = false;
            this.btn_NVManager.Click += new System.EventHandler(this.MenuClick);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Gray;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = global::CNPM_SE_12.Properties.Resources.Package;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(1, 51);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(223, 45);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.Tag = "2";
            this.btnSetting.Text = "Quản lí sản phẩm";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.MenuClick);
            // 
            // btn_Main
            // 
            this.btn_Main.BackColor = System.Drawing.Color.Gray;
            this.btn_Main.FlatAppearance.BorderSize = 0;
            this.btn_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Main.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Main.ForeColor = System.Drawing.Color.White;
            this.btn_Main.Image = global::CNPM_SE_12.Properties.Resources.Bookmark;
            this.btn_Main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Main.Location = new System.Drawing.Point(2, 2);
            this.btn_Main.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Main.Name = "btn_Main";
            this.btn_Main.Size = new System.Drawing.Size(222, 45);
            this.btn_Main.TabIndex = 0;
            this.btn_Main.Tag = "1";
            this.btn_Main.Text = "Order";
            this.btn_Main.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Main.UseVisualStyleBackColor = false;
            this.btn_Main.Click += new System.EventHandler(this.MenuClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 205);
            this.panel4.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 217);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CNPM_SE_12.Properties.Resources.login_logo;
            this.pictureBox2.Location = new System.Drawing.Point(14, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 187);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pnl_ShowForm
            // 
            this.pnl_ShowForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ShowForm.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ShowForm.Location = new System.Drawing.Point(252, 43);
            this.pnl_ShowForm.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_ShowForm.Name = "pnl_ShowForm";
            this.pnl_ShowForm.Size = new System.Drawing.Size(800, 500);
            this.pnl_ShowForm.TabIndex = 4;
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lbTieuDe.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.ForeColor = System.Drawing.Color.White;
            this.lbTieuDe.Location = new System.Drawing.Point(238, 3);
            this.lbTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(266, 27);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "BAKERY MANAGER";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOut);
            this.panel1.Location = new System.Drawing.Point(711, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 30);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minh Huan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome!";
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CNPM_SE_12.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1070, 559);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_ShowForm);
            this.Controls.Add(this.pnl_Menu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormManager";
            this.Text = "Quản lí tiệm bánh mỳ";
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_ButtonMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Panel pnl_ShowForm;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnl_ButtonMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_NVManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Button btn_QLDoanhThu;
        private System.Windows.Forms.Button btn_QLTaiKhoan;
        private System.Windows.Forms.Button btn_Main;
        private System.Windows.Forms.Button btn_DiemDanh;
        private System.Windows.Forms.Button btn_GopY;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}