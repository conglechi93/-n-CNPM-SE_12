namespace CNPM_SE_12.View
{
    partial class QL_Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_Main = new System.Windows.Forms.TabControl();
            this.tab_Ctg = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DGV_Ctg = new System.Windows.Forms.DataGridView();
            this.tab_Items = new System.Windows.Forms.TabPage();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cbb_Ctg = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_NameItems = new System.Windows.Forms.Label();
            this.lb_IDItems = new System.Windows.Forms.Label();
            this.txt_State = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Values = new System.Windows.Forms.TextBox();
            this.txt_NameItems = new System.Windows.Forms.TextBox();
            this.txt_IDItems = new System.Windows.Forms.TextBox();
            this.DGV_Items = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.tab_Main.SuspendLayout();
            this.tab_Ctg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ctg)).BeginInit();
            this.tab_Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Items)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Main
            // 
            this.tab_Main.Controls.Add(this.tab_Ctg);
            this.tab_Main.Controls.Add(this.tab_Items);
            this.tab_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Main.Location = new System.Drawing.Point(13, 67);
            this.tab_Main.Name = "tab_Main";
            this.tab_Main.SelectedIndex = 0;
            this.tab_Main.Size = new System.Drawing.Size(1023, 412);
            this.tab_Main.TabIndex = 0;
            // 
            // tab_Ctg
            // 
            this.tab_Ctg.Controls.Add(this.label1);
            this.tab_Ctg.Controls.Add(this.label2);
            this.tab_Ctg.Controls.Add(this.textBox1);
            this.tab_Ctg.Controls.Add(this.textBox2);
            this.tab_Ctg.Controls.Add(this.DGV_Ctg);
            this.tab_Ctg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Ctg.Location = new System.Drawing.Point(4, 31);
            this.tab_Ctg.Name = "tab_Ctg";
            this.tab_Ctg.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Ctg.Size = new System.Drawing.Size(1015, 377);
            this.tab_Ctg.TabIndex = 0;
            this.tab_Ctg.Tag = "1";
            this.tab_Ctg.Text = "Category";
            this.tab_Ctg.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(657, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã sản phẩm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(810, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 30);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(810, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 30);
            this.textBox2.TabIndex = 5;
            // 
            // DGV_Ctg
            // 
            this.DGV_Ctg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Ctg.Location = new System.Drawing.Point(7, 7);
            this.DGV_Ctg.Name = "DGV_Ctg";
            this.DGV_Ctg.ReadOnly = true;
            this.DGV_Ctg.RowHeadersWidth = 51;
            this.DGV_Ctg.RowTemplate.Height = 24;
            this.DGV_Ctg.Size = new System.Drawing.Size(622, 312);
            this.DGV_Ctg.TabIndex = 0;
            // 
            // tab_Items
            // 
            this.tab_Items.Controls.Add(this.btn_Search);
            this.tab_Items.Controls.Add(this.txt_Search);
            this.tab_Items.Controls.Add(this.cbb_Ctg);
            this.tab_Items.Controls.Add(this.label6);
            this.tab_Items.Controls.Add(this.label5);
            this.tab_Items.Controls.Add(this.label4);
            this.tab_Items.Controls.Add(this.label3);
            this.tab_Items.Controls.Add(this.lb_NameItems);
            this.tab_Items.Controls.Add(this.lb_IDItems);
            this.tab_Items.Controls.Add(this.txt_State);
            this.tab_Items.Controls.Add(this.txt_Price);
            this.tab_Items.Controls.Add(this.txt_Values);
            this.tab_Items.Controls.Add(this.txt_NameItems);
            this.tab_Items.Controls.Add(this.txt_IDItems);
            this.tab_Items.Controls.Add(this.DGV_Items);
            this.tab_Items.Location = new System.Drawing.Point(4, 31);
            this.tab_Items.Name = "tab_Items";
            this.tab_Items.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Items.Size = new System.Drawing.Size(1015, 377);
            this.tab_Items.TabIndex = 1;
            this.tab_Items.Tag = "2";
            this.tab_Items.Text = "Sản phẩm";
            this.tab_Items.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(494, 325);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(143, 29);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(7, 326);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(467, 28);
            this.txt_Search.TabIndex = 4;
            // 
            // cbb_Ctg
            // 
            this.cbb_Ctg.FormattingEnabled = true;
            this.cbb_Ctg.Location = new System.Drawing.Point(824, 124);
            this.cbb_Ctg.Name = "cbb_Ctg";
            this.cbb_Ctg.Size = new System.Drawing.Size(178, 30);
            this.cbb_Ctg.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(665, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại hàng";
            // 
            // lb_NameItems
            // 
            this.lb_NameItems.AutoSize = true;
            this.lb_NameItems.Location = new System.Drawing.Point(665, 78);
            this.lb_NameItems.Name = "lb_NameItems";
            this.lb_NameItems.Size = new System.Drawing.Size(132, 24);
            this.lb_NameItems.TabIndex = 2;
            this.lb_NameItems.Text = "Tên sản phẩm";
            // 
            // lb_IDItems
            // 
            this.lb_IDItems.AutoSize = true;
            this.lb_IDItems.Location = new System.Drawing.Point(665, 33);
            this.lb_IDItems.Name = "lb_IDItems";
            this.lb_IDItems.Size = new System.Drawing.Size(124, 24);
            this.lb_IDItems.TabIndex = 2;
            this.lb_IDItems.Text = "Mã sản phẩm";
            // 
            // txt_State
            // 
            this.txt_State.Location = new System.Drawing.Point(824, 266);
            this.txt_State.Name = "txt_State";
            this.txt_State.Size = new System.Drawing.Size(178, 28);
            this.txt_State.TabIndex = 1;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(824, 221);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(178, 28);
            this.txt_Price.TabIndex = 1;
            // 
            // txt_Values
            // 
            this.txt_Values.Location = new System.Drawing.Point(824, 168);
            this.txt_Values.Name = "txt_Values";
            this.txt_Values.Size = new System.Drawing.Size(178, 28);
            this.txt_Values.TabIndex = 1;
            // 
            // txt_NameItems
            // 
            this.txt_NameItems.Location = new System.Drawing.Point(824, 75);
            this.txt_NameItems.Name = "txt_NameItems";
            this.txt_NameItems.Size = new System.Drawing.Size(178, 28);
            this.txt_NameItems.TabIndex = 1;
            // 
            // txt_IDItems
            // 
            this.txt_IDItems.Location = new System.Drawing.Point(824, 30);
            this.txt_IDItems.Name = "txt_IDItems";
            this.txt_IDItems.Size = new System.Drawing.Size(178, 28);
            this.txt_IDItems.TabIndex = 1;
            // 
            // DGV_Items
            // 
            this.DGV_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Items.Location = new System.Drawing.Point(6, 3);
            this.DGV_Items.Name = "DGV_Items";
            this.DGV_Items.ReadOnly = true;
            this.DGV_Items.RowHeadersWidth = 51;
            this.DGV_Items.RowTemplate.Height = 24;
            this.DGV_Items.Size = new System.Drawing.Size(631, 316);
            this.DGV_Items.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tab_Main);
            this.panel1.Location = new System.Drawing.Point(4, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 498);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Show);
            this.panel2.Controls.Add(this.btn_Del);
            this.panel2.Controls.Add(this.btn_Edit);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Location = new System.Drawing.Point(17, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 57);
            this.panel2.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(4, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(101, 51);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(157, 3);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(101, 51);
            this.btn_Edit.TabIndex = 0;
            this.btn_Edit.Text = "Cập nhật";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(301, 3);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(101, 51);
            this.btn_Del.TabIndex = 0;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.UseVisualStyleBackColor = true;
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(457, 3);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(101, 51);
            this.btn_Show.TabIndex = 0;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            // 
            // QL_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "QL_Item";
            this.Size = new System.Drawing.Size(1061, 563);
            this.tab_Main.ResumeLayout(false);
            this.tab_Ctg.ResumeLayout(false);
            this.tab_Ctg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ctg)).EndInit();
            this.tab_Items.ResumeLayout(false);
            this.tab_Items.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Items)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Main;
        private System.Windows.Forms.TabPage tab_Ctg;
        private System.Windows.Forms.TabPage tab_Items;
        private System.Windows.Forms.DataGridView DGV_Ctg;
        private System.Windows.Forms.DataGridView DGV_Items;
        private System.Windows.Forms.Label lb_NameItems;
        private System.Windows.Forms.Label lb_IDItems;
        private System.Windows.Forms.TextBox txt_State;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Values;
        private System.Windows.Forms.TextBox txt_NameItems;
        private System.Windows.Forms.TextBox txt_IDItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_Ctg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Show;
    }
}
