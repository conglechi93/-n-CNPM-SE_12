namespace CNPM_SE_12.View
{
    partial class QL_Bill
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.DGV_Show = new System.Windows.Forms.DataGridView();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Chart = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Reset);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Chart);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(88, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 188);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::CNPM_SE_12.Properties.Resources.book_magnify;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(441, 141);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Chi tiết";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_DetailOrd_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_IdNhanVien);
            this.panel3.Controls.Add(this.txt_IDItems);
            this.panel3.Controls.Add(this.txt_ID);
            this.panel3.Controls.Add(this.dtpk);
            this.panel3.Controls.Add(this.lb_ID);
            this.panel3.Controls.Add(this.lb_IDItems);
            this.panel3.Controls.Add(this.lb_IDNhanVien);
            this.panel3.Controls.Add(this.lbTime);
            this.panel3.Location = new System.Drawing.Point(33, 26);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 132);
            this.panel3.TabIndex = 4;
            // 
            // txt_IdNhanVien
            // 
            this.txt_IdNhanVien.BackColor = System.Drawing.Color.LightGray;
            this.txt_IdNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IdNhanVien.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdNhanVien.ForeColor = System.Drawing.Color.Black;
            this.txt_IdNhanVien.Location = new System.Drawing.Point(135, 65);
            this.txt_IdNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_IdNhanVien.Name = "txt_IdNhanVien";
            this.txt_IdNhanVien.Size = new System.Drawing.Size(224, 18);
            this.txt_IdNhanVien.TabIndex = 3;
            // 
            // txt_IDItems
            // 
            this.txt_IDItems.BackColor = System.Drawing.Color.LightGray;
            this.txt_IDItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IDItems.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDItems.ForeColor = System.Drawing.Color.Black;
            this.txt_IDItems.Location = new System.Drawing.Point(135, 38);
            this.txt_IDItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_IDItems.Name = "txt_IDItems";
            this.txt_IDItems.Size = new System.Drawing.Size(224, 18);
            this.txt_IDItems.TabIndex = 3;
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.LightGray;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ID.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.ForeColor = System.Drawing.Color.Black;
            this.txt_ID.Location = new System.Drawing.Point(135, 11);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(224, 18);
            this.txt_ID.TabIndex = 3;
            // 
            // dtpk
            // 
            this.dtpk.CalendarFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk.CalendarForeColor = System.Drawing.Color.Navy;
            this.dtpk.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.dtpk.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpk.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk.Location = new System.Drawing.Point(135, 93);
            this.dtpk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpk.Name = "dtpk";
            this.dtpk.Size = new System.Drawing.Size(224, 25);
            this.dtpk.TabIndex = 2;
            this.dtpk.TabStop = false;
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.ForeColor = System.Drawing.Color.Navy;
            this.lb_ID.Location = new System.Drawing.Point(12, 10);
            this.lb_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(108, 19);
            this.lb_ID.TabIndex = 0;
            this.lb_ID.Text = "Mã đơn hàng: ";
            // 
            // lb_IDItems
            // 
            this.lb_IDItems.AutoSize = true;
            this.lb_IDItems.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IDItems.ForeColor = System.Drawing.Color.Navy;
            this.lb_IDItems.Location = new System.Drawing.Point(12, 38);
            this.lb_IDItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_IDItems.Name = "lb_IDItems";
            this.lb_IDItems.Size = new System.Drawing.Size(109, 19);
            this.lb_IDItems.TabIndex = 0;
            this.lb_IDItems.Text = "Mã sản phẩm: ";
            // 
            // lb_IDNhanVien
            // 
            this.lb_IDNhanVien.AutoSize = true;
            this.lb_IDNhanVien.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IDNhanVien.ForeColor = System.Drawing.Color.Navy;
            this.lb_IDNhanVien.Location = new System.Drawing.Point(12, 67);
            this.lb_IDNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_IDNhanVien.Name = "lb_IDNhanVien";
            this.lb_IDNhanVien.Size = new System.Drawing.Size(110, 19);
            this.lb_IDNhanVien.TabIndex = 0;
            this.lb_IDNhanVien.Text = "Mã nhân viên: ";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Navy;
            this.lbTime.Location = new System.Drawing.Point(12, 98);
            this.lbTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(82, 19);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Thời gian: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGV_Show);
            this.panel2.Location = new System.Drawing.Point(88, 238);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 228);
            this.panel2.TabIndex = 1;
            // 
            // DGV_Show
            // 
            this.DGV_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Show.Location = new System.Drawing.Point(0, 2);
            this.DGV_Show.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGV_Show.Name = "DGV_Show";
            this.DGV_Show.ReadOnly = true;
            this.DGV_Show.RowHeadersWidth = 51;
            this.DGV_Show.RowTemplate.Height = 24;
            this.DGV_Show.Size = new System.Drawing.Size(583, 214);
            this.DGV_Show.TabIndex = 0;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Image = global::CNPM_SE_12.Properties.Resources.reload;
            this.btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reset.Location = new System.Drawing.Point(441, 49);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(118, 38);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Chart
            // 
            this.btn_Chart.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Chart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Chart.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chart.ForeColor = System.Drawing.Color.White;
            this.btn_Chart.Image = global::CNPM_SE_12.Properties.Resources.chart_pie_lightning;
            this.btn_Chart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Chart.Location = new System.Drawing.Point(441, 95);
            this.btn_Chart.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Chart.Name = "btn_Chart";
            this.btn_Chart.Size = new System.Drawing.Size(118, 38);
            this.btn_Chart.TabIndex = 3;
            this.btn_Chart.Text = "Vẽ biểu đồ";
            this.btn_Chart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Chart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Chart.UseVisualStyleBackColor = false;
            this.btn_Chart.Click += new System.EventHandler(this.btn_DrawChart_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Image = global::CNPM_SE_12.Properties.Resources.bullet_magnify;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(441, 2);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(118, 38);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // QL_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QL_Bill";
            this.Size = new System.Drawing.Size(800, 500);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_IDNhanVien;
        private System.Windows.Forms.Label lb_IDItems;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGV_Show;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpk;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_IdNhanVien;
        private System.Windows.Forms.TextBox txt_IDItems;
        private System.Windows.Forms.Button btn_Chart;
        private System.Windows.Forms.Button button1;
    }
}
