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
    public partial class AU_Category : Form
    {
        private string ID_Category;
        public Mydel D { get; set; }

        public delegate void Mydel();
        public AU_Category(string s)
        {
            ID_Category = s;
            InitializeComponent();
            ShowData();
        }

        private void ShowData()
        {
            SE_12Entities db = new SE_12Entities();
            this.Text = "ADD Category";

            if (ID_Category != "")
            {
                txtCtg_ID.Enabled = false;
                this.Text = "EDIT Category";
                Category ctg = BLL.QL_Items_BLL.Instance.getCtg_byID_BLL(ID_Category);
                txtCtg_ID.Text = ctg.ID_Category;
                txtCtg_Name.Text = ctg.Category_Name;
            }
        }
        private void AUCategory_Load(object sender, EventArgs e)
        {

        }

        public void AU()
        {
            if (ID_Category == "")
            {
                Category ctg = new Category()
                {
                    ID_Category = txtCtg_ID.Text,
                    Category_Name = txtCtg_Name.Text

                };
                if (BLL.QL_Items_BLL.Instance.Add_Ctg_BLL(ctg))
                {
                    MessageBox.Show("Add thành công !");
                }
                else
                {
                    MessageBox.Show("Add thất bại !");
                }
            }
            else
            {
                if (BLL.QL_Items_BLL.Instance.Edit_Ctg_BLL(txtCtg_ID.Text, txtCtg_Name.Text))
                {
                    MessageBox.Show("Edit thành công !");
                }
                else
                {
                    MessageBox.Show("Edit thất bại !");
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
