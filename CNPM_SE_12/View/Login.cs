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
        private string ID_User;
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BLL.Login_BLL.Instance.CheckAccount(txt_User.Text, txt_Pass.Text))
            {
                ID_User = Login_BLL.Instance.getIDUser(txt_User.Text);
                FormManager f = new FormManager(ID_User);
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
            //vcgncntg
        }

        public void ReadData()
        {
            string[] lines = File.ReadAllLines(@"E:\Lich.txt");
            Console.ReadLine();
            //
        }

        public void WriteData()
        {
            //giatri = Console.ReadLine();
            String filepath = "E:\\Lich.txt";
            FileStream fs = new FileStream(filepath, FileMode.Create);
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                sWriter.WriteLine();
                sWriter.Flush();

            fs.Close();
        }
        public testc()
            {
            //khdaskjdhasdjah
            }
    }
}
