namespace CNPM_SE_12.View
{
    partial class FB_User
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
            this.pnl = new System.Windows.Forms.Panel();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.lb_Message = new System.Windows.Forms.Label();
            this.lb_Subject = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.txt_Message);
            this.pnl.Controls.Add(this.txt_Subject);
            this.pnl.Controls.Add(this.btn_Exit);
            this.pnl.Controls.Add(this.lb_Message);
            this.pnl.Controls.Add(this.btn_Send);
            this.pnl.Controls.Add(this.lb_Subject);
            this.pnl.Location = new System.Drawing.Point(12, 12);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(776, 469);
            this.pnl.TabIndex = 1;
            // 
            // txt_Message
            // 
            this.txt_Message.BackColor = System.Drawing.Color.LightGray;
            this.txt_Message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Message.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Message.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Message.Location = new System.Drawing.Point(86, 92);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(627, 245);
            this.txt_Message.TabIndex = 5;
            // 
            // txt_Subject
            // 
            this.txt_Subject.BackColor = System.Drawing.Color.LightGray;
            this.txt_Subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Subject.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subject.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Subject.Location = new System.Drawing.Point(86, 48);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(281, 18);
            this.txt_Subject.TabIndex = 5;
            // 
            // lb_Message
            // 
            this.lb_Message.AutoSize = true;
            this.lb_Message.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Message.ForeColor = System.Drawing.Color.Navy;
            this.lb_Message.Location = new System.Drawing.Point(82, 70);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(72, 19);
            this.lb_Message.TabIndex = 4;
            this.lb_Message.Text = "Message:";
            // 
            // lb_Subject
            // 
            this.lb_Subject.AutoSize = true;
            this.lb_Subject.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Subject.ForeColor = System.Drawing.Color.Navy;
            this.lb_Subject.Location = new System.Drawing.Point(82, 26);
            this.lb_Subject.Name = "lb_Subject";
            this.lb_Subject.Size = new System.Drawing.Size(63, 19);
            this.lb_Subject.TabIndex = 4;
            this.lb_Subject.Text = "Subject:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Exit.Image = global::CNPM_SE_12.Properties.Resources.email_stop;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(469, 372);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(125, 35);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Exit.UseVisualStyleBackColor = false;
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Send.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Send.Image = global::CNPM_SE_12.Properties.Resources.email_start;
            this.btn_Send.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Send.Location = new System.Drawing.Point(214, 372);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(125, 35);
            this.btn_Send.TabIndex = 4;
            this.btn_Send.Text = "Send";
            this.btn_Send.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Send.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Send.UseVisualStyleBackColor = false;
            // 
            // FB_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl);
            this.Name = "FB_User";
            this.Size = new System.Drawing.Size(800, 500);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lb_Subject;
        private System.Windows.Forms.Label lb_Message;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.TextBox txt_Subject;
    }
}
