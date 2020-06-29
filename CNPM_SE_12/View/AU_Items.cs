using CNPM_SE_12.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_SE_12.View
{
    
    public partial class AU_Items : Form
    {
        private string ID_Type;
        private string ID_Items;
        public Mydel D { get; set; }

        public delegate void Mydel();
        public AU_Items(string s)
        {
            ID_Items = s;
            InitializeComponent();
            set_cbbCtg();
            ShowData();
        }
        private void set_cbbCtg()
        {
            List<Category> ctg = BLL.QL_Items_BLL.Instance.getCtg_BLL();
            foreach (Category i in ctg)
            {
                cbb_LoaiHang.Items.Add(new CBBCtg { Text = i.Category_Name, Values = Convert.ToInt32(i.ID_Category) });
            }

        }

        private void ShowData()
        {
            SE_12Entities db = new SE_12Entities();
            this.Text = "ADD Items";

            if (ID_Items != "")
            {
                txt_IDItems.Enabled = false;
                this.Text = "EDIT Items";
                Item item = BLL.QL_Items_BLL.Instance.getItems_byID_BLL(ID_Items);
                txt_IDItems.Text = item.ID_Items;
                txt_ItemsName.Text = item.Items_Name;
                txt_Price.Text = item.Price.ToString();
                txt_Number.Text = item.Reserve.ToString();
                cbb_LoaiHang.SelectedIndex = Convert.ToInt32(item.ID_Category) - 1;

            }
        }
        public void AU()
        {
            string Name_Item = txt_ItemsName.Text;
            string Price = txt_Price.Text;
            string Number = txt_Number.Text;
            string Category = (cbb_LoaiHang.SelectedIndex + 1).ToString();
            if (ID_Items == "")
            {
                //Category ctg = new Category()
                //{
                //    ID_Category = txtCtg_ID.Text,
                //    Category_Name = txtCtg_Name.Text

                //};
                //if (BLL.QL_Items_BLL.Instance.Add_Ctg_BLL(ctg))
                //{
                //    MessageBox.Show("Add thành công !");
                //}
            }
            else
            {
                if (BLL.QL_Items_BLL.Instance.Edit_Items_BLL(ID_Items, Name_Item, Price, Number, Category))
                {
                    MessageBox.Show("Edit thành công !");
                }

            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            AU();
            if (D != null)
            {
                D();
                this.Close();
            };
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
