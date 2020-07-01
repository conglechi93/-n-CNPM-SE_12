namespace CNPM_SE_12.View
{
    partial class CheckPoint
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnToDay = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMatrix = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSunday = new System.Windows.Forms.Button();
            this.btnSaturday = new System.Windows.Forms.Button();
            this.btnFriday = new System.Windows.Forms.Button();
            this.btnThusday = new System.Windows.Forms.Button();
            this.btnWednesday = new System.Windows.Forms.Button();
            this.btnTuesday = new System.Windows.Forms.Button();
            this.btnMonday = new System.Windows.Forms.Button();
            this.btnPreviours = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(18, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 404);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnToDay);
            this.panel3.Controls.Add(this.dtpkDate);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 65);
            this.panel3.TabIndex = 1;
            // 
            // btnToDay
            // 
            this.btnToDay.BackColor = System.Drawing.Color.SlateBlue;
            this.btnToDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToDay.ForeColor = System.Drawing.Color.White;
            this.btnToDay.Location = new System.Drawing.Point(464, 24);
            this.btnToDay.Name = "btnToDay";
            this.btnToDay.Size = new System.Drawing.Size(103, 33);
            this.btnToDay.TabIndex = 1;
            this.btnToDay.Text = "Hôm nay";
            this.btnToDay.UseVisualStyleBackColor = false;
            this.btnToDay.Click += new System.EventHandler(this.btnToDay_Click);
            // 
            // dtpkDate
            // 
            this.dtpkDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.Location = new System.Drawing.Point(202, 30);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(240, 22);
            this.dtpkDate.TabIndex = 0;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlMatrix);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 314);
            this.panel2.TabIndex = 0;
            // 
            // pnlMatrix
            // 
            this.pnlMatrix.BackColor = System.Drawing.Color.White;
            this.pnlMatrix.Location = new System.Drawing.Point(102, 55);
            this.pnlMatrix.Name = "pnlMatrix";
            this.pnlMatrix.Size = new System.Drawing.Size(561, 239);
            this.pnlMatrix.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnNext);
            this.panel4.Controls.Add(this.btnPreviours);
            this.panel4.Controls.Add(this.btnSunday);
            this.panel4.Controls.Add(this.btnSaturday);
            this.panel4.Controls.Add(this.btnFriday);
            this.panel4.Controls.Add(this.btnThusday);
            this.panel4.Controls.Add(this.btnWednesday);
            this.panel4.Controls.Add(this.btnTuesday);
            this.panel4.Controls.Add(this.btnMonday);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(755, 46);
            this.panel4.TabIndex = 0;
            // 
            // btnSunday
            // 
            this.btnSunday.BackColor = System.Drawing.Color.Brown;
            this.btnSunday.ForeColor = System.Drawing.Color.White;
            this.btnSunday.Location = new System.Drawing.Point(585, 3);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(75, 40);
            this.btnSunday.TabIndex = 6;
            this.btnSunday.Text = "Chủ nhật";
            this.btnSunday.UseVisualStyleBackColor = false;
            // 
            // btnSaturday
            // 
            this.btnSaturday.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaturday.ForeColor = System.Drawing.Color.White;
            this.btnSaturday.Location = new System.Drawing.Point(504, 3);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(75, 40);
            this.btnSaturday.TabIndex = 5;
            this.btnSaturday.Text = "Thứ 7";
            this.btnSaturday.UseVisualStyleBackColor = false;
            // 
            // btnFriday
            // 
            this.btnFriday.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFriday.ForeColor = System.Drawing.Color.White;
            this.btnFriday.Location = new System.Drawing.Point(423, 3);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(75, 40);
            this.btnFriday.TabIndex = 4;
            this.btnFriday.Text = "Thứ 6";
            this.btnFriday.UseVisualStyleBackColor = false;
            // 
            // btnThusday
            // 
            this.btnThusday.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThusday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThusday.ForeColor = System.Drawing.Color.White;
            this.btnThusday.Location = new System.Drawing.Point(342, 3);
            this.btnThusday.Name = "btnThusday";
            this.btnThusday.Size = new System.Drawing.Size(75, 40);
            this.btnThusday.TabIndex = 3;
            this.btnThusday.Text = "Thứ 5";
            this.btnThusday.UseVisualStyleBackColor = false;
            // 
            // btnWednesday
            // 
            this.btnWednesday.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWednesday.ForeColor = System.Drawing.Color.White;
            this.btnWednesday.Location = new System.Drawing.Point(261, 3);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(75, 40);
            this.btnWednesday.TabIndex = 2;
            this.btnWednesday.Text = "Thứ 4";
            this.btnWednesday.UseVisualStyleBackColor = false;
            // 
            // btnTuesday
            // 
            this.btnTuesday.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuesday.ForeColor = System.Drawing.Color.White;
            this.btnTuesday.Location = new System.Drawing.Point(180, 3);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(75, 40);
            this.btnTuesday.TabIndex = 1;
            this.btnTuesday.Text = "Thứ 3";
            this.btnTuesday.UseVisualStyleBackColor = false;
            // 
            // btnMonday
            // 
            this.btnMonday.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonday.ForeColor = System.Drawing.Color.White;
            this.btnMonday.Location = new System.Drawing.Point(99, 3);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(75, 40);
            this.btnMonday.TabIndex = 0;
            this.btnMonday.Text = "Thứ 2";
            this.btnMonday.UseVisualStyleBackColor = false;
            // 
            // btnPreviours
            // 
            this.btnPreviours.BackColor = System.Drawing.Color.White;
            this.btnPreviours.Image = global::CNPM_SE_12.Properties.Resources.previous_green;
            this.btnPreviours.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreviours.Location = new System.Drawing.Point(3, 3);
            this.btnPreviours.Name = "btnPreviours";
            this.btnPreviours.Size = new System.Drawing.Size(90, 40);
            this.btnPreviours.TabIndex = 7;
            this.btnPreviours.Text = "Tháng trước";
            this.btnPreviours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreviours.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreviours.UseVisualStyleBackColor = false;
            this.btnPreviours.Click += new System.EventHandler(this.btnPreviours_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Image = global::CNPM_SE_12.Properties.Resources.next_green;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(665, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 40);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Tháng sau";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // CheckPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CheckPoint";
            this.Size = new System.Drawing.Size(800, 500);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnToDay;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMatrix;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPreviours;
        private System.Windows.Forms.Button btnSunday;
        private System.Windows.Forms.Button btnSaturday;
        private System.Windows.Forms.Button btnFriday;
        private System.Windows.Forms.Button btnThusday;
        private System.Windows.Forms.Button btnWednesday;
        private System.Windows.Forms.Button btnTuesday;
        private System.Windows.Forms.Button btnMonday;
    }
}
