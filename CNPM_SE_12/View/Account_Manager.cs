using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNPM_SE_12.DTO;

namespace CNPM_SE_12.View
{
    public partial class Account_Manager : UserControl
    {
        private string ID_Type;
        public Account_Manager(string id_type)
        {
            if(id_type == "1")
            {
                ID_Type = id_type;
                InitializeComponent();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền hạn này !");
            }

        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            dtg.DataSource = BLL.QL_Account_BLL.Instance.Search_BLL(txt_MaNhanVien.Text).Select(p => new { p.ID_Account, p.Login, p.PassWord, p.ID_Type }).ToList();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            txt_MaNhanVien.Text = "";
            txt_NewPass.Text = "";
            txt_IDAccount.Enabled = true;
            txt_IDAccount.Text = "";
            txt_IDAccount.Enabled = false;
            Show();
        }
        private void Fill()
        {
            Account account = new Account();
            DataGridViewSelectedRowCollection r = dtg.SelectedRows;
            if (r.Count == 1)
            {
                string ID = r[0].Cells["ID_Account"].Value.ToString();
                account = BLL.QL_Account_BLL.Instance.getAccount_byID_BLL(ID);
                txt_IDAccount.Text = account.ID_Account;
            }
        }

        private void Dtg_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_IDAccount.Enabled = true;
            Fill();
            txt_IDAccount.Enabled = false;
        }


        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (BLL.QL_Account_BLL.Instance.Update_Pass_BLL(txt_IDAccount.Text, txt_NewPass.Text))
            {
                MessageBox.Show("Update PassWord thành công!");
            }
            else
            {
                MessageBox.Show("Update PassWord thất bại!");
            }
        }
    }
}
