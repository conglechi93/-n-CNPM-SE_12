namespace CNPM_SE_12.View
{
    partial class FB_Manager
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
            this.DGV_Show = new System.Windows.Forms.DataGridView();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.lb_Message = new System.Windows.Forms.Label();
            this.lb_Subject = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lb_ID_FB = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Show
            // 
            this.DGV_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Show.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Show.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Show.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Show.Location = new System.Drawing.Point(26, 101);
            this.DGV_Show.Name = "DGV_Show";
            this.DGV_Show.RowHeadersWidth = 51;
            this.DGV_Show.Size = new System.Drawing.Size(264, 340);
            this.DGV_Show.TabIndex = 0;
            // 
            // txt_Message
            // 
            this.txt_Message.BackColor = System.Drawing.Color.White;
            this.txt_Message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Message.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Message.ForeColor = System.Drawing.Color.Black;
            this.txt_Message.Location = new System.Drawing.Point(311, 123);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(467, 261);
            this.txt_Message.TabIndex = 8;
            // 
            // txt_Subject
            // 
            this.txt_Subject.BackColor = System.Drawing.Color.LightGray;
            this.txt_Subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Subject.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subject.ForeColor = System.Drawing.Color.Black;
            this.txt_Subject.Location = new System.Drawing.Point(311, 69);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(281, 18);
            this.txt_Subject.TabIndex = 9;
            // 
            // lb_Message
            // 
            this.lb_Message.AutoSize = true;
            this.lb_Message.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Message.ForeColor = System.Drawing.Color.Navy;
            this.lb_Message.Location = new System.Drawing.Point(307, 101);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(72, 19);
            this.lb_Message.TabIndex = 6;
            this.lb_Message.Text = "Message:";
            // 
            // lb_Subject
            // 
            this.lb_Subject.AutoSize = true;
            this.lb_Subject.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Subject.ForeColor = System.Drawing.Color.Navy;
            this.lb_Subject.Location = new System.Drawing.Point(307, 47);
            this.lb_Subject.Name = "lb_Subject";
            this.lb_Subject.Size = new System.Drawing.Size(63, 19);
            this.lb_Subject.TabIndex = 7;
            this.lb_Subject.Text = "Subject:";
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.LightGray;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Search.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.Color.Black;
            this.txt_Search.Location = new System.Drawing.Point(26, 69);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(153, 18);
            this.txt_Search.TabIndex = 10;
            // 
            // lb_ID_FB
            // 
            this.lb_ID_FB.AutoSize = true;
            this.lb_ID_FB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID_FB.ForeColor = System.Drawing.Color.Navy;
            this.lb_ID_FB.Location = new System.Drawing.Point(22, 47);
            this.lb_ID_FB.Name = "lb_ID_FB";
            this.lb_ID_FB.Size = new System.Drawing.Size(107, 19);
            this.lb_ID_FB.TabIndex = 7;
            this.lb_ID_FB.Text = "Mã Feed back:";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Search.Image = global::CNPM_SE_12.Properties.Resources.bullet_magnify;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(183, 61);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(107, 35);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // btn_Read
            // 
            this.btn_Read.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Read.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Read.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Read.Image = global::CNPM_SE_12.Properties.Resources.script_start;
            this.btn_Read.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Read.Location = new System.Drawing.Point(392, 406);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(125, 35);
            this.btn_Read.TabIndex = 5;
            this.btn_Read.Text = "Read";
            this.btn_Read.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Read.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Read.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Delete.Image = global::CNPM_SE_12.Properties.Resources.script_stop;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(587, 406);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(125, 35);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // FB_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.txt_Subject);
            this.Controls.Add(this.lb_Message);
            this.Controls.Add(this.lb_ID_FB);
            this.Controls.Add(this.lb_Subject);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.DGV_Show);
            this.Name = "FB_Manager";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.FB_Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Show;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Label lb_Message;
        private System.Windows.Forms.Label lb_Subject;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lb_ID_FB;
    }
}
