﻿namespace CNPM_SE_12.View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_Main = new System.Windows.Forms.TabControl();
            this.tab_Ctg = new System.Windows.Forms.TabPage();
            this.pnl_Ctg = new System.Windows.Forms.Panel();
            this.txt_IDCtg = new System.Windows.Forms.TextBox();
            this.lb_NameCtg = new System.Windows.Forms.Label();
            this.txt_NameCtg = new System.Windows.Forms.TextBox();
            this.lb_IDCtg = new System.Windows.Forms.Label();
            this.tab_Items = new System.Windows.Forms.TabPage();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.pnl_Items = new System.Windows.Forms.Panel();
            this.txt_IDItems = new System.Windows.Forms.TextBox();
            this.txt_NameItems = new System.Windows.Forms.TextBox();
            this.txt_Ctg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Values = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_State = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_IDItems = new System.Windows.Forms.Label();
            this.lb_NameItems = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.DGV_Show = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.tab_Main.SuspendLayout();
            this.tab_Ctg.SuspendLayout();
            this.pnl_Ctg.SuspendLayout();
            this.tab_Items.SuspendLayout();
            this.pnl_Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Main
            // 
            this.tab_Main.Controls.Add(this.tab_Ctg);
            this.tab_Main.Controls.Add(this.tab_Items);
            this.tab_Main.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Main.Location = new System.Drawing.Point(18, 85);
            this.tab_Main.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Main.Name = "tab_Main";
            this.tab_Main.SelectedIndex = 0;
            this.tab_Main.Size = new System.Drawing.Size(780, 355);
            this.tab_Main.TabIndex = 0;
            this.tab_Main.SelectedIndexChanged += new System.EventHandler(this.tab_Main_SelectedIndexChanged);
            // 
            // tab_Ctg
            // 
            this.tab_Ctg.Controls.Add(this.pnl_Ctg);
            this.tab_Ctg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Ctg.Location = new System.Drawing.Point(4, 28);
            this.tab_Ctg.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Ctg.Name = "tab_Ctg";
            this.tab_Ctg.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Ctg.Size = new System.Drawing.Size(772, 332);
            this.tab_Ctg.TabIndex = 0;
            this.tab_Ctg.Tag = "1";
            this.tab_Ctg.Text = "Category";
            this.tab_Ctg.UseVisualStyleBackColor = true;
            // 
            // pnl_Ctg
            // 
            this.pnl_Ctg.Controls.Add(this.txt_IDCtg);
            this.pnl_Ctg.Controls.Add(this.lb_NameCtg);
            this.pnl_Ctg.Controls.Add(this.txt_NameCtg);
            this.pnl_Ctg.Controls.Add(this.lb_IDCtg);
            this.pnl_Ctg.Location = new System.Drawing.Point(4, 79);
            this.pnl_Ctg.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Ctg.Name = "pnl_Ctg";
            this.pnl_Ctg.Size = new System.Drawing.Size(270, 81);
            this.pnl_Ctg.TabIndex = 8;
            // 
            // txt_IDCtg
            // 
            this.txt_IDCtg.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_IDCtg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IDCtg.Enabled = false;
            this.txt_IDCtg.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDCtg.ForeColor = System.Drawing.Color.Black;
            this.txt_IDCtg.Location = new System.Drawing.Point(96, 11);
            this.txt_IDCtg.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IDCtg.Name = "txt_IDCtg";
            this.txt_IDCtg.Size = new System.Drawing.Size(172, 19);
            this.txt_IDCtg.TabIndex = 5;
            // 
            // lb_NameCtg
            // 
            this.lb_NameCtg.AutoSize = true;
            this.lb_NameCtg.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameCtg.ForeColor = System.Drawing.Color.Navy;
            this.lb_NameCtg.Location = new System.Drawing.Point(-2, 45);
            this.lb_NameCtg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NameCtg.Name = "lb_NameCtg";
            this.lb_NameCtg.Size = new System.Drawing.Size(94, 17);
            this.lb_NameCtg.TabIndex = 6;
            this.lb_NameCtg.Text = "Tên loại hàng:";
            // 
            // txt_NameCtg
            // 
            this.txt_NameCtg.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_NameCtg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NameCtg.Enabled = false;
            this.txt_NameCtg.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameCtg.ForeColor = System.Drawing.Color.Black;
            this.txt_NameCtg.Location = new System.Drawing.Point(96, 42);
            this.txt_NameCtg.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NameCtg.Name = "txt_NameCtg";
            this.txt_NameCtg.Size = new System.Drawing.Size(172, 19);
            this.txt_NameCtg.TabIndex = 4;
            // 
            // lb_IDCtg
            // 
            this.lb_IDCtg.AutoSize = true;
            this.lb_IDCtg.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IDCtg.ForeColor = System.Drawing.Color.Navy;
            this.lb_IDCtg.Location = new System.Drawing.Point(0, 13);
            this.lb_IDCtg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_IDCtg.Name = "lb_IDCtg";
            this.lb_IDCtg.Size = new System.Drawing.Size(90, 17);
            this.lb_IDCtg.TabIndex = 7;
            this.lb_IDCtg.Text = "Mã loại hàng:";
            // 
            // tab_Items
            // 
            this.tab_Items.Controls.Add(this.cbbSearch);
            this.tab_Items.Controls.Add(this.txt_Search);
            this.tab_Items.Controls.Add(this.pnl_Items);
            this.tab_Items.Controls.Add(this.btn_Search);
            this.tab_Items.Location = new System.Drawing.Point(4, 28);
            this.tab_Items.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Items.Name = "tab_Items";
            this.tab_Items.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Items.Size = new System.Drawing.Size(772, 323);
            this.tab_Items.TabIndex = 1;
            this.tab_Items.Tag = "2";
            this.tab_Items.Text = "Sản phẩm";
            this.tab_Items.UseVisualStyleBackColor = true;
            // 
            // cbbSearch
            // 
            this.cbbSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbbSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Location = new System.Drawing.Point(499, 280);
            this.cbbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(140, 27);
            this.cbbSearch.TabIndex = 6;
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_Search.Location = new System.Drawing.Point(278, 280);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(189, 26);
            this.txt_Search.TabIndex = 4;
            // 
            // pnl_Items
            // 
            this.pnl_Items.Controls.Add(this.txt_IDItems);
            this.pnl_Items.Controls.Add(this.txt_NameItems);
            this.pnl_Items.Controls.Add(this.txt_Ctg);
            this.pnl_Items.Controls.Add(this.label6);
            this.pnl_Items.Controls.Add(this.txt_Values);
            this.pnl_Items.Controls.Add(this.label5);
            this.pnl_Items.Controls.Add(this.txt_Price);
            this.pnl_Items.Controls.Add(this.label4);
            this.pnl_Items.Controls.Add(this.txt_State);
            this.pnl_Items.Controls.Add(this.label3);
            this.pnl_Items.Controls.Add(this.lb_IDItems);
            this.pnl_Items.Controls.Add(this.lb_NameItems);
            this.pnl_Items.Location = new System.Drawing.Point(4, 40);
            this.pnl_Items.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Items.Name = "pnl_Items";
            this.pnl_Items.Size = new System.Drawing.Size(267, 232);
            this.pnl_Items.TabIndex = 7;
            // 
            // txt_IDItems
            // 
            this.txt_IDItems.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_IDItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IDItems.Enabled = false;
            this.txt_IDItems.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_IDItems.Location = new System.Drawing.Point(107, 8);
            this.txt_IDItems.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IDItems.Name = "txt_IDItems";
            this.txt_IDItems.Size = new System.Drawing.Size(158, 19);
            this.txt_IDItems.TabIndex = 1;
            // 
            // txt_NameItems
            // 
            this.txt_NameItems.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_NameItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NameItems.Enabled = false;
            this.txt_NameItems.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_NameItems.Location = new System.Drawing.Point(107, 40);
            this.txt_NameItems.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NameItems.Name = "txt_NameItems";
            this.txt_NameItems.Size = new System.Drawing.Size(158, 19);
            this.txt_NameItems.TabIndex = 1;
            // 
            // txt_Ctg
            // 
            this.txt_Ctg.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_Ctg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Ctg.Enabled = false;
            this.txt_Ctg.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_Ctg.Location = new System.Drawing.Point(107, 71);
            this.txt_Ctg.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Ctg.Name = "txt_Ctg";
            this.txt_Ctg.Size = new System.Drawing.Size(158, 19);
            this.txt_Ctg.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(2, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tình trạng:";
            // 
            // txt_Values
            // 
            this.txt_Values.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_Values.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Values.Enabled = false;
            this.txt_Values.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_Values.Location = new System.Drawing.Point(107, 101);
            this.txt_Values.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Values.Name = "txt_Values";
            this.txt_Values.Size = new System.Drawing.Size(158, 19);
            this.txt_Values.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(2, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giá:";
            // 
            // txt_Price
            // 
            this.txt_Price.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Price.Enabled = false;
            this.txt_Price.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_Price.Location = new System.Drawing.Point(107, 133);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(159, 19);
            this.txt_Price.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(2, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng:";
            // 
            // txt_State
            // 
            this.txt_State.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_State.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_State.Enabled = false;
            this.txt_State.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_State.Location = new System.Drawing.Point(107, 164);
            this.txt_State.Margin = new System.Windows.Forms.Padding(2);
            this.txt_State.Name = "txt_State";
            this.txt_State.Size = new System.Drawing.Size(158, 19);
            this.txt_State.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(2, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại hàng:";
            // 
            // lb_IDItems
            // 
            this.lb_IDItems.AutoSize = true;
            this.lb_IDItems.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IDItems.ForeColor = System.Drawing.Color.Navy;
            this.lb_IDItems.Location = new System.Drawing.Point(2, 11);
            this.lb_IDItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_IDItems.Name = "lb_IDItems";
            this.lb_IDItems.Size = new System.Drawing.Size(93, 17);
            this.lb_IDItems.TabIndex = 2;
            this.lb_IDItems.Text = "Mã sản phẩm:";
            // 
            // lb_NameItems
            // 
            this.lb_NameItems.AutoSize = true;
            this.lb_NameItems.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameItems.ForeColor = System.Drawing.Color.Navy;
            this.lb_NameItems.Location = new System.Drawing.Point(2, 42);
            this.lb_NameItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NameItems.Name = "lb_NameItems";
            this.lb_NameItems.Size = new System.Drawing.Size(97, 17);
            this.lb_NameItems.TabIndex = 2;
            this.lb_NameItems.Text = "Tên sản phẩm:";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Image = global::CNPM_SE_12.Properties.Resources.bullet_magnify;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(665, 272);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(98, 41);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // DGV_Show
            // 
            this.DGV_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Show.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Show.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Show.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Show.Location = new System.Drawing.Point(300, 123);
            this.DGV_Show.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_Show.Name = "DGV_Show";
            this.DGV_Show.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Show.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Show.RowHeadersWidth = 51;
            this.DGV_Show.RowTemplate.Height = 24;
            this.DGV_Show.Size = new System.Drawing.Size(485, 254);
            this.DGV_Show.TabIndex = 0;
            this.DGV_Show.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Show_RowHeaderMouseClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Show);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.btn_Edit);
            this.panel2.Controls.Add(this.btn_Del);
            this.panel2.Location = new System.Drawing.Point(300, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 55);
            this.panel2.TabIndex = 1;
            // 
            // btn_Show
            // 
            this.btn_Show.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.ForeColor = System.Drawing.Color.White;
            this.btn_Show.Image = global::CNPM_SE_12.Properties.Resources.application_osx_get;
            this.btn_Show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Show.Location = new System.Drawing.Point(8, 6);
            this.btn_Show.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(100, 41);
            this.btn_Show.TabIndex = 0;
            this.btn_Show.Text = "Show";
            this.btn_Show.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Show.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Show.UseVisualStyleBackColor = false;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Image = global::CNPM_SE_12.Properties.Resources.control_add;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(135, 6);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(98, 41);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Image = global::CNPM_SE_12.Properties.Resources.database_wrench;
            this.btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.Location = new System.Drawing.Point(258, 6);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(98, 41);
            this.btn_Edit.TabIndex = 0;
            this.btn_Edit.Text = "Cập nhật";
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.ForeColor = System.Drawing.Color.White;
            this.btn_Del.Image = global::CNPM_SE_12.Properties.Resources.decline;
            this.btn_Del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Del.Location = new System.Drawing.Point(378, 6);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(98, 41);
            this.btn_Del.TabIndex = 0;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Del.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // QL_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DGV_Show);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tab_Main);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QL_Item";
            this.Size = new System.Drawing.Size(800, 500);
            this.tab_Main.ResumeLayout(false);
            this.tab_Ctg.ResumeLayout(false);
            this.pnl_Ctg.ResumeLayout(false);
            this.pnl_Ctg.PerformLayout();
            this.tab_Items.ResumeLayout(false);
            this.tab_Items.PerformLayout();
            this.pnl_Items.ResumeLayout(false);
            this.pnl_Items.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.TextBox txt_Ctg;
        private System.Windows.Forms.Panel pnl_Ctg;
        private System.Windows.Forms.Panel pnl_Items;
    }
}
