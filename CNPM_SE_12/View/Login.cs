using CNPM_SE_12.BLL;
using CNPM_SE_12.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
////
namespace CNPM_SE_12
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            ReadData();
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

        public void ReadData()
        {
            string[] lines = File.ReadAllLines(@"D:\check.txt");

            if (lines[0] == "true")
            {
                txt_User.Text = lines[1];
                txt_Pass.Text = lines[2];
                cb_Rmb.Checked = true;
            }
            else cb_Rmb.Checked = false;
        }

        public void WriteData()
        {
            String filepath = "D:\\check.txt";
            FileStream fs = new FileStream(filepath, FileMode.Create);
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
            if (cb_Rmb.Checked == true)
            {
                List<string> s = new List<string>();
                s.Add("true");
                s.Add(txt_User.Text);
                s.Add(txt_Pass.Text);
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

        private string HashPass(string pass)
        {
            string s = pass;
            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes("Chuỗi cần mã hóa");
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }    
        private void txt_User_Leave(object sender, EventArgs e)
        {
            if (txt_User.Text == "")
            {
                txt_User.Text = "User name";
            }
        }
  
        private void txt_Pass_Leave(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "")
            {
                txt_Pass.Text = "User name";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {   
            if (BLL.Login_BLL.Instance.CheckAccount(txt_User.Text, txt_Pass.Text))
            {
                WriteData();
                string s = BLL.Login_BLL.Instance.getIDUser(txt_User.Text);
                FormManager f = new FormManager(s);
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

        private void txtUser_Click(object sender, EventArgs e)
        {
            if (txt_User.Text == "User name")
            {
                txt_User.Text = "";
            }
        }

        private void txt_Pass_Click(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "User name")
            {
                txt_Pass.Text = "";
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Exit_MouseHover(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.Red;
        }

        private void Btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.RosyBrown;
        }
    }
}
