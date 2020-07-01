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
            string name_item = txt_ItemsName.Text;
            string price = txt_Price.Text;
            string values = txt_Number.Text;
            string ctg = (cbb_LoaiHang.SelectedIndex + 1).ToString();
            string status = "Hết hàng";
            if(check_Inf())
            {
                if (ID_Items == "")
                {
                    if (Convert.ToInt32(values) > 0) status = "Còn hàng";
                    Item item = new Item()
                    {
                        ID_Items = txt_IDItems.Text,
                        Items_Name = name_item,
                        ID_Category = ctg,
                        Price = Convert.ToInt32(price),
                        Reserve = Convert.ToInt32(values),
                        Status = status
                    };
                    if (BLL.QL_Items_BLL.Instance.Add_Items_BLL(item))
                    {
                        MessageBox.Show("Add thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Add Thất bại !");
                    }
                }
                else
                {
                    if (BLL.QL_Items_BLL.Instance.Edit_Items_BLL(ID_Items, name_item, price, values, ctg))
                    {
                        MessageBox.Show("Cập nhật thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại !");
                    }
                }
            }    
            
        }

        public bool check_Inf()
        {
            if(BLL.QL_Items_BLL.Instance.getItems_byID_BLL(ID_Items) != null)
            {
                MessageBox.Show("Sản phẩm này đã tồn tại!");
                return false;
            }    
            foreach(Control i in pnl_Inf.Controls)
            {
                if(Controls == null)
                {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin!");
                    return false;
                }    
            }
            return true;
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

        private void lb_Number_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_Subject_Click(object sender, EventArgs e)
        {

        }

        private void cbb_LoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_ItemsName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_IDItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Number_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
