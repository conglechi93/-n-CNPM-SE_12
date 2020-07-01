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
    public partial class FormManager : Form
    {
        private Form currentChildForm = null;
        string ID_Account;

        public FormManager(string id_account)
        {
            InitializeComponent();
            ID_Account = id_account;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void OpenChildForm(UserControl childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            childForm.BorderStyle = BorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_ShowForm.BackColor = Color.White;
            pnl_ShowForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void MenuClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lbTieuDe.Text = btn.Text;
            foreach (Control item in pnl_ButtonMenu.Controls)
            {
                // item.BackColor = pnl_ButtonMenu.BackColor;
                item.BackColor = Color.Gray;
            }
            btn.BackColor = Color.CadetBlue;
            if (btn.Tag.ToString() == "1")
            {
                pnl_ShowForm.BackColor = Color.White;
                OpenChildForm(new Main(ID_Account));
            }
            if (btn.Tag.ToString() == "2")
            {
                OpenChildForm(new QL_Item());
            }
            if (btn.Tag.ToString() == "3")
            {
                if (BLL.QL_Account_BLL.Instance.getAccount_byID_BLL(ID_Account).ID_Type == "1")
                {
                    OpenChildForm(new QL_User(ID_Account));
                }
                else
                {
                    pnl_ShowForm.Controls.Clear();
                    pnl_ShowForm.BackColor = Color.Transparent;
                }
            }
            if (btn.Tag.ToString() == "4")
            {
                if (BLL.QL_Account_BLL.Instance.getAccount_byID_BLL(ID_Account).ID_Type == "1")
                {
                    OpenChildForm(new QL_Bill(ID_Account));
                }
                else
                {
                    pnl_ShowForm.Controls.Clear();
                    pnl_ShowForm.BackColor = Color.Transparent;
                }
            }
            if (btn.Tag.ToString() == "5")
            {
                OpenChildForm(new CheckPoint());
            }
            if (btn.Tag.ToString() == "6")
            {
                if (BLL.QL_Account_BLL.Instance.getAccount_byID_BLL(ID_Account).ID_Type == "1")
                {
                    OpenChildForm(new FB_Manager());
                }
                else
                {
                    OpenChildForm(new FB_User());
                }
            }
            if (btn.Tag.ToString() == "7")
            {
                if (BLL.QL_Account_BLL.Instance.getAccount_byID_BLL(ID_Account).ID_Type == "1")
                {
                    OpenChildForm(new Account_Manager());
                }
                else
                {
                    pnl_ShowForm.Controls.Clear();
                    OpenChildForm(new ChangePass_NV(ID_Account));
                }
            }
        }
        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQ_Click(object sender, EventArgs e)
        {

        }

        private void FormManager_Load(object sender, EventArgs e)
        {

        }

        private void btnOut_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOut_MouseHover(object sender, EventArgs e)
        {
            btnOut.BackColor = Color.Lime;
        }

        private void BtnOut_MouseLeave(object sender, EventArgs e)
        {
            btnOut.BackColor = Color.OliveDrab;
        }
    }
}
