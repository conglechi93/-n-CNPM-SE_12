using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_SE_12.View
{
    public partial class QuanLyBill : UserControl
    {
        private string ID_Type;
        public QuanLyBill(string id_account)
        {
            this.ID_Type = BLL.QL_Account_BLL.Instance.getTypeAccount_BLL(id_account);
            if(ID_Type!="3")
            {
                InitializeComponent();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền hạn này !");
            }

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {

        }
    }
}
