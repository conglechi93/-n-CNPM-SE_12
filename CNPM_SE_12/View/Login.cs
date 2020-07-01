using CNPM_SE_12.BLL;
using CNPM_SE_12.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
////
namespace CNPM_SE_12
{
    public partial class fLogin : Form
    {
        private string ID_Account;
        private string ID_Type;
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BLL.Login_BLL.Instance.CheckAccount(txt_User.Text, txt_Pass.Text))
            {
                ID_Account = Login_BLL.Instance.getIDUser(txt_User.Text);
                ID_Type = BLL.QL_Account_BLL.Instance.getTypeAccount_BLL(ID_Account);
                FormManager f = new FormManager(ID_Type);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản !");
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
            {
                sWriter.WriteLine(giatri);
                sWriter.Flush();
                fs.Close();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?",
                "Thông báo",
                MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void MousClick(object sender, MouseEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = "";
            //vcgncntg
        }

}
