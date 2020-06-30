namespace CNPM_SE_12.View
{
    partial class Main
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
            this.DGV_Show = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_CreateBill = new System.Windows.Forms.Button();
            this.btn_TamTinh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.lb_Total = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.cbb_Ctg = new System.Windows.Forms.ComboBox();
            this.lb_Loai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Show
            // 
            this.DGV_Show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Show.Location = new System.Drawing.Point(13, 27);
            this.DGV_Show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_Show.Name = "DGV_Show";
            this.DGV_Show.RowHeadersWidth = 51;
            this.DGV_Show.RowTemplate.Height = 24;
            this.DGV_Show.Size = new System.Drawing.Size(467, 345);
            this.DGV_Show.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Clear);
            this.panel2.Controls.Add(this.btn_CreateBill);
            this.panel2.Controls.Add(this.btn_TamTinh);
            this.panel2.Location = new System.Drawing.Point(13, 391);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 78);
            this.panel2.TabIndex = 1;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(339, 18);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(121, 46);
            this.btn_Clear.TabIndex = 0;
            this.btn_Clear.Text = "Làm mới";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_CreateBill
            // 
            this.btn_CreateBill.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_CreateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateBill.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateBill.ForeColor = System.Drawing.Color.White;
            this.btn_CreateBill.Location = new System.Drawing.Point(165, 18);
            this.btn_CreateBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CreateBill.Name = "btn_CreateBill";
            this.btn_CreateBill.Size = new System.Drawing.Size(151, 46);
            this.btn_CreateBill.TabIndex = 0;
            this.btn_CreateBill.Text = "Lập hóa đơn";
            this.btn_CreateBill.UseVisualStyleBackColor = false;
            this.btn_CreateBill.Click += new System.EventHandler(this.btn_CreateBill_Click);
            // 
            // btn_TamTinh
            // 
            this.btn_TamTinh.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_TamTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TamTinh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TamTinh.ForeColor = System.Drawing.Color.White;
            this.btn_TamTinh.Location = new System.Drawing.Point(13, 18);
            this.btn_TamTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TamTinh.Name = "btn_TamTinh";
            this.btn_TamTinh.Size = new System.Drawing.Size(125, 46);
            this.btn_TamTinh.TabIndex = 0;
            this.btn_TamTinh.Text = "Tạm tính";
            this.btn_TamTinh.UseVisualStyleBackColor = false;
            this.btn_TamTinh.Click += new System.EventHandler(this.btn_TamTinh_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_Total);
            this.panel3.Controls.Add(this.lb_Total);
            this.panel3.Location = new System.Drawing.Point(5, 391);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 86);
            this.panel3.TabIndex = 2;
            // 
            // txt_Total
            // 
            this.txt_Total.BackColor = System.Drawing.Color.LightGray;
            this.txt_Total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Total.Enabled = false;
            this.txt_Total.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Total.Location = new System.Drawing.Point(136, 23);
            this.txt_Total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(216, 22);
            this.txt_Total.TabIndex = 1;
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total.ForeColor = System.Drawing.Color.Navy;
            this.lb_Total.Location = new System.Drawing.Point(21, 22);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(101, 23);
            this.lb_Total.TabIndex = 0;
            this.lb_Total.Text = "Tổng tiền:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DGV_Show);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(511, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 506);
            this.panel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlShow);
            this.panel1.Controls.Add(this.cbb_Ctg);
            this.panel1.Controls.Add(this.lb_Loai);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 494);
            this.panel1.TabIndex = 3;
            // 
            // pnlShow
            // 
            this.pnlShow.Location = new System.Drawing.Point(12, 118);
            this.pnlShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(483, 246);
            this.pnlShow.TabIndex = 6;
            this.pnlShow.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlShow_Paint);
            // 
            // cbb_Ctg
            // 
            this.cbb_Ctg.BackColor = System.Drawing.Color.LightGray;
            this.cbb_Ctg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_Ctg.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Ctg.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbb_Ctg.FormattingEnabled = true;
            this.cbb_Ctg.Location = new System.Drawing.Point(121, 27);
            this.cbb_Ctg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_Ctg.Name = "cbb_Ctg";
            this.cbb_Ctg.Size = new System.Drawing.Size(227, 29);
            this.cbb_Ctg.TabIndex = 5;
            this.cbb_Ctg.SelectedIndexChanged += new System.EventHandler(this.cbb_Ctg_SelectedIndexChanged);
            // 
            // lb_Loai
            // 
            this.lb_Loai.AutoSize = true;
            this.lb_Loai.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Loai.ForeColor = System.Drawing.Color.Navy;
            this.lb_Loai.Location = new System.Drawing.Point(49, 27);
            this.lb_Loai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Loai.Name = "lb_Loai";
            this.lb_Loai.Size = new System.Drawing.Size(49, 23);
            this.lb_Loai.TabIndex = 4;
            this.lb_Loai.Text = "Loại";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(1011, 506);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Show;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_CreateBill;
        private System.Windows.Forms.Button btn_TamTinh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbb_Ctg;
        private System.Windows.Forms.Label lb_Loai;
        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.TextBox txt_Total;
    }
}
