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
    public partial class CreateAccount : Form
    {
        public Mydel D { get; set; }

        public delegate void Mydel();
        private string ID_Acccount;
        private string ID_Type;
        public CreateAccount(string id_account,string id_type)
        {
            this.ID_Acccount = id_account;
            this.ID_Type = id_type;
            InitializeComponent();
        }
        private bool check()
        {
            foreach (TextBox i in pnl_Show.Controls.OfType<TextBox>())
            {
                if(i.Text == "")
                {
                    MessageBox.Show("Cần nhập đầy đủ thông tin !");
                    return false;
                }    
            }    
            if(txt_Pass.Text != txt_ConfirmPass.Text)
            {
                MessageBox.Show("Xác thực mật khẩu không đúng !");
                return false;
            }    
            if(!BLL.QL_Account_BLL.Instance.checkAcccount(txt_Login.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại !");
                return false;
            }
            return true;
        }
        private void btn_Create_Click(object sender, EventArgs e)
        {
            if(check())
            {
                if (BLL.QL_Account_BLL.Instance.create_Account(ID_Acccount, txt_Login.Text, txt_Pass.Text, ID_Type))
                {
                    MessageBox.Show("Thêm mới thành công !");

                }
                else
                {
                    BLL.QL_User_BLL.Instance.del_Acc_byID(ID_Acccount);
                    MessageBox.Show("Thêm mới thất bại !");
                }
                if (D != null)
                {
                    D();
                    this.Close();
                }
            }
        }
    }
}
