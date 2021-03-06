﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNPM_SE_12.DTO;
using System.IO;
using System.Collections;

namespace CNPM_SE_12.View
{
    public partial class Main : UserControl
    {

        private string ID_Account;
        private int total = 0;
        private List<List<Button>> matrix;
        private List<data_Order> tb_Order;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        internal List<data_Order> Tb_Order { get => tb_Order; set => tb_Order = value; }

        public Main(string id_account)
        {
            ID_Account = id_account;
            tb_Order = new List<data_Order>();
            InitializeComponent();
            //setColumn_DGV();
            setCbb_Ctg();
            LoadMatrix();
            cbb_Ctg.SelectedIndex = 0;
        }

        //public void LoadMatrix(int cbb_index)
        public void LoadMatrix()
        {
            Matrix = new List<List<Button>>();
            //int dem = 0;
            //int value;
            //if(cbb_index == 0)
            //{
            //    value = BLL.QL_Items_BLL.Instance.CountItems_byIDCtg_BLL(0);
            //}    
            //else
            //{
            //    value = BLL.QL_Items_BLL.Instance.CountItems_byIDCtg_BLL(cbb_index);
            //}    
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < 4; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < 4; j++)
                {
                    //if (dem == value) break;
                    //else dem++;
                    Button btn = new Button() { Width = 80, Height = 40 };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    pnlShow.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    btn.Click += btn_Click;
                    oldBtn = btn;
                }

                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight) };
            }
        }

        public void setName_btn(int cbb_index)
        {
            ClearMatrix();
            int index = 0;
            List<Item> item = BLL.QL_Items_BLL.Instance.getItems_byIDCtg_BLL(cbb_index);
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    if (item.Count != index)
                    {
                        Button btn = Matrix[i][j];
                        btn.Name = "abc";
                        btn.Text = item[index].Items_Name;
                        btn.Tag = item[index].ID_Items;
                        btn.ForeColor = Color.Black;
                        btn.BackColor = Color.LightGray;
                        btn.Font = new Font("Cambria", 8);
                        //btn.FlatStyle = FlatStyle.Flat;
                        index++;
                    }
                    else break;
                }
            }
        }

        public void setCbb_Ctg()
        {
            if (cbb_Ctg.Items != null)
            {
                cbb_Ctg.Items.Clear();
            }
            cbb_Ctg.Items.Add(new CBBCtg { Text = "All", Values = 0 });
            foreach (Category i in BLL.QL_Items_BLL.Instance.getCtg_BLL())
            {
                cbb_Ctg.Items.Add(new CBBCtg
                {
                    Values = Convert.ToInt32(i.ID_Category),
                    Text = i.Category_Name,
                    
                });
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text != "")
            {
                string id_item = btn.Tag.ToString();
                ShowOrder(id_item);
            }
        }

        //private void ShowOrder(string id_item)
        //{
        //    DGV_Show.DataSource = null;   
        //    Item item = BLL.QL_Items_BLL.Instance.getItems_byID_BLL(id_item);
        //    int dem = Convert.ToInt32(item.Reserve);
        //    bool check = true;
        //    foreach (data_Order i in tb_Order)
        //    {
        //        if (i.Items_ID == id_item)
        //        {
        //            if(dem < i .Values + 1)
        //            {
        //                MessageBox.Show(" Hết hàng!");
        //            }
        //            else i.Values++;
        //            check = false;
        //            break;
        //        }
        //    }
        //    if (check) tb_Order.Add(new data_Order { Items_ID = item.ID_Items, Items_Name = item.Items_Name, Price = item.Price, Values = 1 });
        //    DGV_Show.DataSource = tb_Order;
        //}

        private void ShowOrder(string id_item)
        {
            DGV_Show.DataSource = null;
            Item item = BLL.QL_Items_BLL.Instance.getItems_byID_BLL(id_item);
            int dem = Convert.ToInt32(item.Reserve);
            bool check = true;
            foreach (data_Order i in tb_Order)
            {
                if (i.Items_ID == id_item)
                {
                    if (dem < i.Values + 1)
                    {
                        MessageBox.Show(" Hết hàng!");
                    }
                    else i.Values++;
                    check = false;
                    break;
                }
            }
            if (check) tb_Order.Add(new data_Order { Items_ID = item.ID_Items, Items_Name = item.Items_Name, Price = item.Price, Values = 1 });
            ShowDGV(tb_Order);
        }
        private void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                }
            }
        }
        private void cbb_Ctg_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cbb_index = ((CBBCtg)cbb_Ctg.SelectedItem).Values;
            string cbb_string = cbb_Ctg.SelectedItem.ToString();
            setName_btn(cbb_index);
        }

        private void pnlShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DGV_Show.DataSource = null;
        }

        private void btn_TamTinh_Click(object sender, EventArgs e)
        {
            getToTal();
            txt_Total.Text = total.ToString();
        }
        private void getToTal()
        {
            foreach (DataGridViewRow i in DGV_Show.Rows)
            {
                if(i.Cells[3].Value != null)
                {
                    int price = Convert.ToInt32(i.Cells[2].Value.ToString());
                    int value = Convert.ToInt32(i.Cells[3].Value.ToString());
                    total += price * value;
                }  
            }
        }
        private void btn_CreateBill_Click(object sender, EventArgs e)
        {
            getToTal();
            Bill f = new Bill(ID_Account, total, tb_Order);
            f.D += new Bill.mydel(clear_DGV);
            f.ShowDialog();
        }

        private void clear_DGV()
        {
            DGV_Show.DataSource = null;
            while (DGV_Show.Columns.Count > 0)
            {
                DGV_Show.Columns.RemoveAt(0);
            }
            while (DGV_Show.Rows.Count > 1)
            {
                DGV_Show.Rows.RemoveAt(0);
            }
        }    
        private void ShowDGV(List<data_Order> da_O)
        {

            DGV_Show.ColumnCount = 4;
            DGV_Show.Columns[0].Name = "Mã sản phẩm";
            DGV_Show.Columns[1].Name = "Tên sản phẩm";
            DGV_Show.Columns[2].Name = "Đơn giá";
            DGV_Show.Columns[3].Name = "Số lượng";
            while (DGV_Show.Rows.Count > 1)
            {
                DGV_Show.Rows.RemoveAt(0);
            }
            foreach (data_Order i in da_O)
            {
                ArrayList a = new ArrayList();
                a.Add(i.Items_ID);
                a.Add(i.Items_Name);
                a.Add(i.Price);
                a.Add(i.Values);
                DGV_Show.Rows.Add(a.ToArray());
            }
        }
        public void ReadData()
        {
            string[] lines = File.ReadAllLines(@"E:\Lich.txt");

            foreach (string s in lines)
            {

            }
            Console.ReadLine();
        }

        public void WriteData()
        {
            string giatri = Console.ReadLine();
            String filepath = "E:\\Lich.txt";
            FileStream fs = new FileStream(filepath, FileMode.Create);
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
            sWriter.WriteLine();
            sWriter.Flush();
            fs.Close();
        }

        private void DGV_Show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
