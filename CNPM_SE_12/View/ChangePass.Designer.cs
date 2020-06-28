namespace CNPM_SE_12.View
{
    partial class ChangePass
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_NewPass = new System.Windows.Forms.TextBox();
            this.lb_NewPass = new System.Windows.Forms.Label();
            this.txt_OldPass = new System.Windows.Forms.TextBox();
            this.lb_OldPass = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.txt_NewPass);
            this.panel1.Controls.Add(this.lb_NewPass);
            this.panel1.Controls.Add(this.txt_OldPass);
            this.panel1.Controls.Add(this.lb_OldPass);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 271);
            this.panel1.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Save.Location = new System.Drawing.Point(29, 176);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(167, 43);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // txt_NewPass
            // 
            this.txt_NewPass.BackColor = System.Drawing.Color.LightGray;
            this.txt_NewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NewPass.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_NewPass.Location = new System.Drawing.Point(29, 124);
            this.txt_NewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NewPass.Name = "txt_NewPass";
            this.txt_NewPass.Size = new System.Drawing.Size(199, 20);
            this.txt_NewPass.TabIndex = 6;
            // 
            // lb_NewPass
            // 
            this.lb_NewPass.AutoSize = true;
            this.lb_NewPass.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NewPass.ForeColor = System.Drawing.Color.Navy;
            this.lb_NewPass.Location = new System.Drawing.Point(25, 90);
            this.lb_NewPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_NewPass.Name = "lb_NewPass";
            this.lb_NewPass.Size = new System.Drawing.Size(113, 20);
            this.lb_NewPass.TabIndex = 5;
            this.lb_NewPass.Text = "Mật khẩu mới:";
            // 
            // txt_OldPass
            // 
            this.txt_OldPass.BackColor = System.Drawing.Color.LightGray;
            this.txt_OldPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_OldPass.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OldPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_OldPass.Location = new System.Drawing.Point(29, 53);
            this.txt_OldPass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_OldPass.Name = "txt_OldPass";
            this.txt_OldPass.Size = new System.Drawing.Size(199, 20);
            this.txt_OldPass.TabIndex = 6;
            // 
            // lb_OldPass
            // 
            this.lb_OldPass.AutoSize = true;
            this.lb_OldPass.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_OldPass.ForeColor = System.Drawing.Color.Navy;
            this.lb_OldPass.Location = new System.Drawing.Point(25, 18);
            this.lb_OldPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_OldPass.Name = "lb_OldPass";
            this.lb_OldPass.Size = new System.Drawing.Size(118, 23);
            this.lb_OldPass.TabIndex = 5;
            this.lb_OldPass.Text = "Mật khẩu cũ:";
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 302);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChangePass";
            this.Text = "Setting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_OldPass;
        private System.Windows.Forms.Label lb_OldPass;
        private System.Windows.Forms.TextBox txt_NewPass;
        private System.Windows.Forms.Label lb_NewPass;
        private System.Windows.Forms.Button btn_Save;
    }
}