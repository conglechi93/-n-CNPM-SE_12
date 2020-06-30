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
            ReadData();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BLL.Login_BLL.Instance.CheckAccount(txt_User.Text, txt_Pass.Text))
            {
                WriteData(txt_User.Text, txt_Pass.Text);
                ID_Account = Login_BLL.Instance.getIDUser(txt_User.Text);
                FormManager f = new FormManager(ID_Account);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản !");
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
        }
        public void ReadData()
        {
            string[] lines = File.ReadAllLines(@"K:\check.txt");

            if (lines[0] == "true")
            {
                txt_User.Text = lines[1];
                txt_Pass.Text = lines[2];
                cb_Rmb.Checked = true;
            }
            else cb_Rmb.Checked = false;
        }

        public void WriteData(string us,string pass)
        {
            String filepath = "K:\\check.txt";
            FileStream fs = new FileStream(filepath, FileMode.Create);
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
            if (cb_Rmb.Checked == true)
            {
                List<string> s = new List<string>();
                s.Add("true");
                s.Add(us);
                s.Add(pass);
                foreach (string i in s)
                {
                    sWriter.WriteLine(i);
                    sWriter.Flush();
                }
            }
            else
            {
                sWriter.WriteLine("false");
            }
            fs.Close();
        }
    }
}
