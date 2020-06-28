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
            this.lb_idCtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idCtg.Location = new System.Drawing.Point(49, 36);
            this.lb_idCtg.Name = "lb_idCtg";
            this.lb_idCtg.Size = new System.Drawing.Size(121, 20);
            this.lb_idCtg.TabIndex = 0;
            this.lb_idCtg.Text = "Mã Category:";
            // 
            // lb_NameCtg
            // 
            this.lb_NameCtg.AutoSize = true;
            this.lb_NameCtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameCtg.Location = new System.Drawing.Point(49, 71);
            this.lb_NameCtg.Name = "lb_NameCtg";
            this.lb_NameCtg.Size = new System.Drawing.Size(127, 20);
            this.lb_NameCtg.TabIndex = 0;
            this.lb_NameCtg.Text = "Tên Category:";
            // 
            // txtCtg_ID
            // 
            this.txtCtg_ID.Location = new System.Drawing.Point(203, 34);
            this.txtCtg_ID.Name = "txtCtg_ID";
            this.txtCtg_ID.Size = new System.Drawing.Size(154, 22);
            this.txtCtg_ID.TabIndex = 1;
            // 
            // txtCtg_Name
            // 
            this.txtCtg_Name.Location = new System.Drawing.Point(203, 71);
            this.txtCtg_Name.Name = "txtCtg_Name";
            this.txtCtg_Name.Size = new System.Drawing.Size(154, 22);
            this.txtCtg_Name.TabIndex = 2;
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(95, 117);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(88, 30);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancle.Location = new System.Drawing.Point(237, 117);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(85, 30);
            this.btn_Cancle.TabIndex = 4;
            this.btn_Cancle.Text = "Cancle";
            this.btn_Cancle.UseVisualStyleBackColor = true;
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // AU_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 181);
            this.Controls.Add(this.btn_Cancle);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txtCtg_Name);
            this.Controls.Add(this.txtCtg_ID);
            this.Controls.Add(this.lb_NameCtg);
            this.Controls.Add(this.lb_idCtg);
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