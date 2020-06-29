namespace CNPM_SE_12.View
{
    partial class AU_Category
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
            this.lb_idCtg = new System.Windows.Forms.Label();
            this.lb_NameCtg = new System.Windows.Forms.Label();
            this.txtCtg_ID = new System.Windows.Forms.TextBox();
            this.txtCtg_Name = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_idCtg
            // 
            this.lb_idCtg.AutoSize = true;
            this.lb_idCtg.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idCtg.ForeColor = System.Drawing.Color.Navy;
            this.lb_idCtg.Location = new System.Drawing.Point(28, 25);
            this.lb_idCtg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_idCtg.Name = "lb_idCtg";
            this.lb_idCtg.Size = new System.Drawing.Size(100, 19);
            this.lb_idCtg.TabIndex = 0;
            this.lb_idCtg.Text = "Mã Category:";
            // 
            // lb_NameCtg
            // 
            this.lb_NameCtg.AutoSize = true;
            this.lb_NameCtg.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameCtg.ForeColor = System.Drawing.Color.Navy;
            this.lb_NameCtg.Location = new System.Drawing.Point(28, 55);
            this.lb_NameCtg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NameCtg.Name = "lb_NameCtg";
            this.lb_NameCtg.Size = new System.Drawing.Size(104, 19);
            this.lb_NameCtg.TabIndex = 0;
            this.lb_NameCtg.Text = "Tên Category:";
            // 
            // txtCtg_ID
            // 
            this.txtCtg_ID.BackColor = System.Drawing.Color.LightGray;
            this.txtCtg_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCtg_ID.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtg_ID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCtg_ID.Location = new System.Drawing.Point(143, 25);
            this.txtCtg_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCtg_ID.Name = "txtCtg_ID";
            this.txtCtg_ID.Size = new System.Drawing.Size(176, 18);
            this.txtCtg_ID.TabIndex = 1;
            // 
            // txtCtg_Name
            // 
            this.txtCtg_Name.BackColor = System.Drawing.Color.LightGray;
            this.txtCtg_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCtg_Name.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtg_Name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCtg_Name.Location = new System.Drawing.Point(143, 56);
            this.txtCtg_Name.Margin = new System.Windows.Forms.Padding(2);
            this.txtCtg_Name.Name = "txtCtg_Name";
            this.txtCtg_Name.Size = new System.Drawing.Size(176, 18);
            this.txtCtg_Name.TabIndex = 2;
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_OK.Location = new System.Drawing.Point(48, 88);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(106, 36);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancle.ForeColor = System.Drawing.Color.White;
            this.btn_Cancle.Location = new System.Drawing.Point(192, 88);
            this.btn_Cancle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(106, 36);
            this.btn_Cancle.TabIndex = 4;
            this.btn_Cancle.Text = "Cancle";
            this.btn_Cancle.UseVisualStyleBackColor = false;
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // AU_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 147);
            this.Controls.Add(this.btn_Cancle);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txtCtg_Name);
            this.Controls.Add(this.txtCtg_ID);
            this.Controls.Add(this.lb_NameCtg);
            this.Controls.Add(this.lb_idCtg);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AU_Category";
            this.Text = "AUCategory";
            this.Load += new System.EventHandler(this.AUCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_idCtg;
        private System.Windows.Forms.Label lb_NameCtg;
        private System.Windows.Forms.TextBox txtCtg_ID;
        private System.Windows.Forms.TextBox txtCtg_Name;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancle;
    }
}