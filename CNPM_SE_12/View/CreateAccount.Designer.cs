namespace CNPM_SE_12.View
{
    partial class CreateAccount
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
            this.pnl_Show = new System.Windows.Forms.Panel();
            this.btn_Cancle = new System.Windows.Forms.Button();
            this.txt_ConfirmPass = new System.Windows.Forms.TextBox();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.pnl_Show.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Show
            // 
            this.pnl_Show.Controls.Add(this.label4);
            this.pnl_Show.Controls.Add(this.btn_Cancle);
            this.pnl_Show.Controls.Add(this.btn_Create);
            this.pnl_Show.Controls.Add(this.txt_ConfirmPass);
            this.pnl_Show.Controls.Add(this.txt_Login);
            this.pnl_Show.Controls.Add(this.txt_Pass);
            this.pnl_Show.Controls.Add(this.label2);
            this.pnl_Show.Controls.Add(this.label1);
            this.pnl_Show.Controls.Add(this.label3);
            this.pnl_Show.Location = new System.Drawing.Point(13, 2);
            this.pnl_Show.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Show.Name = "pnl_Show";
            this.pnl_Show.Size = new System.Drawing.Size(345, 258);
            this.pnl_Show.TabIndex = 10;
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancle.ForeColor = System.Drawing.Color.White;
            this.btn_Cancle.Image = global::CNPM_SE_12.Properties.Resources.decline;
            this.btn_Cancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancle.Location = new System.Drawing.Point(197, 197);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(132, 43);
            this.btn_Cancle.TabIndex = 8;
            this.btn_Cancle.Text = "Cancle";
            this.btn_Cancle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Cancle.UseVisualStyleBackColor = false;
            this.btn_Cancle.Click += new System.EventHandler(this.Btn_Cancle_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Create.Location = new System.Drawing.Point(59, 210);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(132, 43);
            this.btn_Create.TabIndex = 8;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // txt_ConfirmPass
            // 
            this.txt_ConfirmPass.BackColor = System.Drawing.Color.White;
            this.txt_ConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ConfirmPass.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmPass.ForeColor = System.Drawing.Color.Black;
            this.txt_ConfirmPass.Location = new System.Drawing.Point(154, 139);
            this.txt_ConfirmPass.Name = "txt_ConfirmPass";
            this.txt_ConfirmPass.Size = new System.Drawing.Size(178, 18);
            this.txt_ConfirmPass.TabIndex = 12;
            this.txt_ConfirmPass.UseSystemPasswordChar = true;
            // 
            // txt_Login
            // 
            this.txt_Login.BackColor = System.Drawing.Color.White;
            this.txt_Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Login.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Login.ForeColor = System.Drawing.Color.Black;
            this.txt_Login.Location = new System.Drawing.Point(154, 74);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(178, 18);
            this.txt_Login.TabIndex = 12;
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.Color.White;
            this.txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Pass.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.ForeColor = System.Drawing.Color.Black;
            this.txt_Pass.Location = new System.Drawing.Point(154, 106);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(178, 18);
            this.txt_Pass.TabIndex = 12;
            this.txt_Pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(14, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Xác thực mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(14, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(76, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "CREATE ACCOUNT";
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.ForeColor = System.Drawing.Color.White;
            this.btn_Create.Image = global::CNPM_SE_12.Properties.Resources.control_add;
            this.btn_Create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Create.Location = new System.Drawing.Point(60, 197);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(99, 35);
            this.btn_Create.TabIndex = 8;
            this.btn_Create.Text = "Create";
            this.btn_Create.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Create.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(367, 267);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Show);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnl_Show.ResumeLayout(false);
            this.pnl_Show.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Show;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.TextBox txt_ConfirmPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cancle;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}
