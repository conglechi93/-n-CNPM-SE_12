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
            this.lb_NameCtg = new System.Windows.Forms.Label();
            this.lb_IDCtg = new System.Windows.Forms.Label();
            this.txt_NameCtg = new System.Windows.Forms.TextBox();
            this.txt_IDCtg = new System.Windows.Forms.TextBox();
            this.DGV_Show = new System.Windows.Forms.DataGridView();
            this.tab_Items = new System.Windows.Forms.TabPage();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.txt_Ctg = new System.Windows.Forms.TextBox();
            this.tab_Main.SuspendLayout();
            this.tab_Ctg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).BeginInit();
            this.tab_Items.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Main
            // 
            this.tab_Main.Controls.Add(this.tab_Ctg);
            this.tab_Main.Controls.Add(this.tab_Items);
            this.tab_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Main.Location = new System.Drawing.Point(13, 63);
            this.tab_Main.Name = "tab_Main";
            this.tab_Main.SelectedIndex = 0;
            this.tab_Main.Size = new System.Drawing.Size(1040, 416);
            this.tab_Main.TabIndex = 0;
            this.tab_Main.SelectedIndexChanged += new System.EventHandler(this.tab_Main_SelectedIndexChanged);
            // 
            // tab_Ctg
            // 
            this.tab_Ctg.Controls.Add(this.lb_NameCtg);
            this.tab_Ctg.Controls.Add(this.lb_IDCtg);
            this.tab_Ctg.Controls.Add(this.txt_NameCtg);
            this.tab_Ctg.Controls.Add(this.txt_IDCtg);
            this.tab_Ctg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Ctg.Location = new System.Drawing.Point(4, 31);
            this.tab_Ctg.Name = "tab_Ctg";
            this.tab_Ctg.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Ctg.Size = new System.Drawing.Size(1032, 381);
            this.tab_Ctg.TabIndex = 0;
            this.tab_Ctg.Tag = "1";
            this.tab_Ctg.Text = "Category";
            this.tab_Ctg.UseVisualStyleBackColor = true;
            // 
            // lb_NameCtg
            // 
            this.lb_NameCtg.AutoSize = true;
            this.lb_NameCtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameCtg.Location = new System.Drawing.Point(17, 167);
            this.lb_NameCtg.Name = "lb_NameCtg";
            this.lb_NameCtg.Size = new System.Drawing.Size(126, 24);
            this.lb_NameCtg.TabIndex = 6;
            this.lb_NameCtg.Text = "Tên loại hàng";
            // 
            // lb_IDCtg
            // 
            this.lb_IDCtg.AutoSize = true;
            this.lb_IDCtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IDCtg.Location = new System.Drawing.Point(17, 122);
            this.lb_IDCtg.Name = "lb_IDCtg";
            this.lb_IDCtg.Size = new System.Drawing.Size(118, 24);
            this.lb_IDCtg.TabIndex = 7;
            this.lb_IDCtg.Text = "Mã loại hàng";
            // 
            // txt_NameCtg
            // 
            this.txt_NameCtg.Enabled = false;
            this.txt_NameCtg.Location = new System.Drawing.Point(170, 164);
            this.txt_NameCtg.Name = "txt_NameCtg";
            this.txt_NameCtg.Size = new System.Drawing.Size(180, 30);
            this.txt_NameCtg.TabIndex = 4;
            // 
            // txt_IDCtg
            // 
            this.txt_IDCtg.Enabled = false;
            this.txt_IDCtg.Location = new System.Drawing.Point(170, 119);
            this.txt_IDCtg.Name = "txt_IDCtg";
            this.txt_IDCtg.Size = new System.Drawing.Size(180, 30);
            this.txt_IDCtg.TabIndex = 5;
            // 
            // DGV_Show
            // 
            this.DGV_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Show.Location = new System.Drawing.Point(389, 98);
            this.DGV_Show.Name = "DGV_Show";
            this.DGV_Show.ReadOnly = true;
            this.DGV_Show.RowHeadersWidth = 51;
            this.DGV_Show.RowTemplate.Height = 24;
            this.DGV_Show.Size = new System.Drawing.Size(647, 312);
            this.DGV_Show.TabIndex = 0;
            this.DGV_Show.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Show_RowHeaderMouseClick);
            // 
            // tab_Items
            // 
            this.tab_Items.Controls.Add(this.cbbSearch);
            this.tab_Items.Controls.Add(this.btn_Search);
            this.tab_Items.Controls.Add(this.txt_Search);
            this.tab_Items.Controls.Add(this.label6);
            this.tab_Items.Controls.Add(this.label5);
            this.tab_Items.Controls.Add(this.label4);
            this.tab_Items.Controls.Add(this.label3);
            this.tab_Items.Controls.Add(this.lb_NameItems);
            this.tab_Items.Controls.Add(this.lb_IDItems);
            this.tab_Items.Controls.Add(this.txt_State);
            this.tab_Items.Controls.Add(this.txt_Price);
            this.tab_Items.Controls.Add(this.txt_Values);
            this.tab_Items.Controls.Add(this.txt_Ctg);
            this.tab_Items.Controls.Add(this.txt_NameItems);
            this.tab_Items.Controls.Add(this.txt_IDItems);
            this.tab_Items.Location = new System.Drawing.Point(4, 31);
            this.tab_Items.Name = "tab_Items";
            this.tab_Items.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Items.Size = new System.Drawing.Size(1032, 381);
            this.tab_Items.TabIndex = 1;
            this.tab_Items.Tag = "2";
            this.tab_Items.Text = "Sản phẩm";
            this.tab_Items.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(504, 325);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(143, 29);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(7, 328);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(251, 28);
            this.txt_Search.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại hàng";
            // 
            // lb_NameItems
            // 
            this.lb_NameItems.AutoSize = true;
            this.lb_NameItems.Location = new System.Drawing.Point(6, 76);
            this.lb_NameItems.Name = "lb_NameItems";
            this.lb_NameItems.Size = new System.Drawing.Size(132, 24);
            this.lb_NameItems.TabIndex = 2;
            this.lb_NameItems.Text = "Tên sản phẩm";
            // 
            // lb_IDItems
            // 
            this.lb_IDItems.AutoSize = true;
            this.lb_IDItems.Location = new System.Drawing.Point(6, 31);
            this.lb_IDItems.Name = "lb_IDItems";
            this.lb_IDItems.Size = new System.Drawing.Size(124, 24);
            this.lb_IDItems.TabIndex = 2;
            this.lb_IDItems.Text = "Mã sản phẩm";
            // 
            // txt_State
            // 
            this.txt_State.Enabled = false;
            this.txt_State.Location = new System.Drawing.Point(165, 264);
            this.txt_State.Name = "txt_State";
            this.txt_State.Size = new System.Drawing.Size(178, 28);
            this.txt_State.TabIndex = 1;
            // 
            // txt_Price
            // 
            this.txt_Price.Enabled = false;
            this.txt_Price.Location = new System.Drawing.Point(165, 219);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(178, 28);
            this.txt_Price.TabIndex = 1;
            // 
            // txt_Values
            // 
            this.txt_Values.Enabled = false;
            this.txt_Values.Location = new System.Drawing.Point(165, 166);
            this.txt_Values.Name = "txt_Values";
            this.txt_Values.Size = new System.Drawing.Size(178, 28);
            this.txt_Values.TabIndex = 1;
            // 
            // txt_NameItems
            // 
            this.txt_NameItems.Enabled = false;
            this.txt_NameItems.Location = new System.Drawing.Point(165, 73);
            this.txt_NameItems.Name = "txt_NameItems";
            this.txt_NameItems.Size = new System.Drawing.Size(178, 28);
            this.txt_NameItems.TabIndex = 1;
            // 
            // txt_IDItems
            // 
            this.txt_IDItems.Enabled = false;
            this.txt_IDItems.Location = new System.Drawing.Point(165, 28);
            this.txt_IDItems.Name = "txt_IDItems";
            this.txt_IDItems.Size = new System.Drawing.Size(178, 28);
            this.txt_IDItems.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DGV_Show);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tab_Main);
            this.panel1.Location = new System.Drawing.Point(4, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 497);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Show);
            this.panel2.Controls.Add(this.btn_Del);
            this.panel2.Controls.Add(this.btn_Edit);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Location = new System.Drawing.Point(389, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 57);
            this.panel2.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(46, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(101, 51);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(199, 3);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(101, 51);
            this.btn_Edit.TabIndex = 0;
            this.btn_Edit.Text = "Cập nhật";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(343, 3);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(101, 51);
            this.btn_Del.TabIndex = 0;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.UseVisualStyleBackColor = true;
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(499, 3);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(101, 51);
            this.btn_Show.TabIndex = 0;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // cbbSearch
            // 
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Location = new System.Drawing.Point(301, 327);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(186, 30);
            this.cbbSearch.TabIndex = 6;
            // 
            // txt_Ctg
            // 
            this.txt_Ctg.Enabled = false;
            this.txt_Ctg.Location = new System.Drawing.Point(165, 120);
            this.txt_Ctg.Name = "txt_Ctg";
            this.txt_Ctg.Size = new System.Drawing.Size(178, 28);
            this.txt_Ctg.TabIndex = 1;
            // 
            // QL_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "QL_Item";
            this.Size = new System.Drawing.Size(1102, 568);
            this.tab_Main.ResumeLayout(false);
            this.tab_Ctg.ResumeLayout(false);
            this.tab_Ctg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).EndInit();
            this.tab_Items.ResumeLayout(false);
            this.tab_Items.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Main;
        private System.Windows.Forms.TabPage tab_Ctg;
        private System.Windows.Forms.TabPage tab_Items;
        private System.Windows.Forms.DataGridView DGV_Show;
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
        private System.Windows.Forms.Label lb_NameCtg;
        private System.Windows.Forms.Label lb_IDCtg;
        private System.Windows.Forms.TextBox txt_NameCtg;
        private System.Windows.Forms.TextBox txt_IDCtg;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.TextBox txt_Ctg;
    }
}
