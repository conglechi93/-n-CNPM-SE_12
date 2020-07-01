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
        private string ID_Type;
        public FormManager(string id_user)
        {
            InitializeComponent();
            this.ID_Type = id_user;
            this.Text = string.Empty;
            //this.ControlBox = false;
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
                OpenChildForm(new Main(""));
            }
            if (btn.Tag.ToString() == "2")
            {
                OpenChildForm(new QL_Items(ID_Type));
            }
            if (btn.Tag.ToString() == "3")
            {
                OpenChildForm(new QL_User(ID_Type));
            }
            if (btn.Tag.ToString() == "4")
            {
                OpenChildForm(new QuanLyBill(ID_Type));
            }
            if (btn.Tag.ToString() == "5")
            {
                OpenChildForm(new CheckPoint());
            }
            if (btn.Tag.ToString() == "6")
            {
                if (BLL.QL_Account_BLL.Instance.getAccount_byID_BLL(ID_Type).ID_Type == "1")
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
                OpenChildForm(new Account_Manager(ID_Type));
            }
        }
        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQ_Click(object sender, EventArgs e)
        {

        }
    }
}
