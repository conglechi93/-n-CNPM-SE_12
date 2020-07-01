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
            this.btn_Cancle = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_idCtg
            // 
            this.lb_idCtg.AutoSize = true;
            this.lb_idCtg.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idCtg.ForeColor = System.Drawing.Color.Navy;
            this.lb_idCtg.Location = new System.Drawing.Point(28, 60);
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
            this.lb_NameCtg.Location = new System.Drawing.Point(28, 90);
            this.lb_NameCtg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NameCtg.Name = "lb_NameCtg";
            this.lb_NameCtg.Size = new System.Drawing.Size(104, 19);
            this.lb_NameCtg.TabIndex = 0;
            this.lb_NameCtg.Text = "Tên Category:";
            // 
            // txtCtg_ID
            // 
            this.txtCtg_ID.BackColor = System.Drawing.Color.White;
            this.txtCtg_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCtg_ID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtg_ID.ForeColor = System.Drawing.Color.Black;
            this.txtCtg_ID.Location = new System.Drawing.Point(143, 60);
            this.txtCtg_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCtg_ID.Name = "txtCtg_ID";
            this.txtCtg_ID.Size = new System.Drawing.Size(176, 19);
            this.txtCtg_ID.TabIndex = 1;
            // 
            // txtCtg_Name
            // 
            this.txtCtg_Name.BackColor = System.Drawing.Color.White;
            this.txtCtg_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCtg_Name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtg_Name.ForeColor = System.Drawing.Color.Black;
            this.txtCtg_Name.Location = new System.Drawing.Point(143, 91);
            this.txtCtg_Name.Margin = new System.Windows.Forms.Padding(2);
            this.txtCtg_Name.Name = "txtCtg_Name";
            this.txtCtg_Name.Size = new System.Drawing.Size(176, 19);
            this.txtCtg_Name.TabIndex = 2;
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancle.ForeColor = System.Drawing.Color.White;
            this.btn_Cancle.Image = global::CNPM_SE_12.Properties.Resources.page_cancel;
            this.btn_Cancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancle.Location = new System.Drawing.Point(192, 123);
            this.btn_Cancle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(106, 36);
            this.btn_Cancle.TabIndex = 4;
            this.btn_Cancle.Text = "Cancle";
            this.btn_Cancle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Cancle.UseVisualStyleBackColor = false;
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_OK.Image = global::CNPM_SE_12.Properties.Resources.bullet_tick;
            this.btn_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OK.Location = new System.Drawing.Point(48, 123);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(106, 36);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "OK";
            this.btn_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(92, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thêm Category";
            // 
            // AU_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(339, 179);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancle);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txtCtg_Name);
            this.Controls.Add(this.txtCtg_ID);
            this.Controls.Add(this.lb_NameCtg);
            this.Controls.Add(this.lb_idCtg);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AU_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Label label1;
    }
}