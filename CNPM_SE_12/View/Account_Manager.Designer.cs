namespace CNPM_SE_12.View
{
    partial class Account_Manager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtg = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_NewPass = new System.Windows.Forms.TextBox();
            this.txt_IDAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_MaNhanVien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Reset.Location = new System.Drawing.Point(145, 186);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(98, 35);
            this.btn_Reset.TabIndex = 8;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Search.Location = new System.Drawing.Point(13, 56);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(99, 31);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // dtg
            // 
            this.dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg.Location = new System.Drawing.Point(277, 12);
            this.dtg.Name = "dtg";
            this.dtg.RowHeadersWidth = 51;
            this.dtg.Size = new System.Drawing.Size(479, 238);
            this.dtg.TabIndex = 9;
            this.dtg.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dtg_RowHeaderMouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.btn_Search);
            this.panel2.Controls.Add(this.txt_NewPass);
            this.panel2.Controls.Add(this.txt_IDAccount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_MaNhanVien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_Reset);
            this.panel2.Controls.Add(this.lb_MaNhanVien);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 238);
            this.panel2.TabIndex = 10;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Save.Location = new System.Drawing.Point(13, 186);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(99, 35);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // txt_NewPass
            // 
            this.txt_NewPass.BackColor = System.Drawing.Color.LightGray;
            this.txt_NewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NewPass.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_NewPass.Location = new System.Drawing.Point(13, 164);
            this.txt_NewPass.Name = "txt_NewPass";
            this.txt_NewPass.Size = new System.Drawing.Size(149, 18);
            this.txt_NewPass.TabIndex = 12;
            // 
            // txt_IDAccount
            // 
            this.txt_IDAccount.BackColor = System.Drawing.Color.LightGray;
            this.txt_IDAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IDAccount.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDAccount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_IDAccount.Location = new System.Drawing.Point(13, 120);
            this.txt_IDAccount.Name = "txt_IDAccount";
            this.txt_IDAccount.Size = new System.Drawing.Size(149, 18);
            this.txt_IDAccount.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(10, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txt_MaNhanVien
            // 
            this.txt_MaNhanVien.BackColor = System.Drawing.Color.LightGray;
            this.txt_MaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MaNhanVien.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNhanVien.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_MaNhanVien.Location = new System.Drawing.Point(13, 31);
            this.txt_MaNhanVien.Name = "txt_MaNhanVien";
            this.txt_MaNhanVien.Size = new System.Drawing.Size(149, 18);
            this.txt_MaNhanVien.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(10, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID_Account";
            // 
            // lb_MaNhanVien
            // 
            this.lb_MaNhanVien.AutoSize = true;
            this.lb_MaNhanVien.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaNhanVien.ForeColor = System.Drawing.Color.Navy;
            this.lb_MaNhanVien.Location = new System.Drawing.Point(10, 9);
            this.lb_MaNhanVien.Name = "lb_MaNhanVien";
            this.lb_MaNhanVien.Size = new System.Drawing.Size(102, 19);
            this.lb_MaNhanVien.TabIndex = 11;
            this.lb_MaNhanVien.Text = "Mã nhân viên";
            // 
            // Account_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtg);
            this.Name = "Account_Manager";
            this.Size = new System.Drawing.Size(782, 268);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_MaNhanVien;
        private System.Windows.Forms.Label lb_MaNhanVien;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_NewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IDAccount;
        private System.Windows.Forms.Label label3;
    }
}
