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
            ShowData();
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
                txt_CtgName.Text = item.ID_Category;
                txt_Price.Text = item.Price.ToString();
                txt_State.Text = item.Status;

            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

        }
    }
}
