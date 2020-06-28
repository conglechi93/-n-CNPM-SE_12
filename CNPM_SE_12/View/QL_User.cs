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
    public partial class QL_User : UserControl
    {
        public QL_User()
        {
            InitializeComponent();
            dataGridView1.DataSource = BLL.QL_User_BLL.Instance.getUser_BLL();
        }

        private void Add()
        {

            string ID_User = txt_MaNhanVien.Text;
            string User_Name = txt_TenNhanVien.Text;
            string Gender;
            if (rdb_Male.Checked == true)
            {
                Gender = "1";
            }
            else
            {
                Gender = "0";
            }
            string Birthday = dateTimePicker1.Value.ToString();
            string Phonenumber = txt_SoDienThoai.Text;
            string Passport = txt_CMND.Text;
            string Address = txt_DiaChi.Text;
            string ShiftTime = txt_ShiftTime.Text;
            string Salary = txt_Salary.Text;
            BLL.QL_User_BLL.Instance.Add_User_BLL(ID_User, User_Name, Gender, Birthday, Phonenumber, Passport, Address, ShiftTime, Salary);
        }
        void ShowDGV()
        {
            dataGridView1.DataSource = BLL.QL_User_BLL.Instance.getUser_BLL();
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Add();
            ShowDGV();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Fill();
            txt_MaNhanVien.Enabled = false;
        }

        private void Fill()
        {
            User user = new User();
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count == 1)
            {
                string ID = r[0].Cells["ID_User"].Value.ToString();
                user = BLL.QL_User_BLL.Instance.Get_UserByID_BLL(ID);
                txt_MaNhanVien.Text = user.ID_Account;
                txt_TenNhanVien.Text = user.User_Name;
                if (user.Gender == true)
                    rdb_Male.Checked = true;
                else
                    rdb_Female.Checked = true;
                dateTimePicker1.Value = user.Birthday;
                txt_SoDienThoai.Text = user.NumberPhone;
                txt_CMND.Text = user.Pasport;
                txt_DiaChi.Text = user.Address;
                txt_ShiftTime.Text = user.Shift_Time;
                txt_Salary.Text = user.Salary.ToString();
            }
        }


        private void Btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            foreach (TextBox i in grb_NhanVien.Controls.OfType<TextBox>())
            {
                i.Text = "";
                i.Enabled = true;
            }
        }

        private void QL_User_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.QL_User_BLL.Instance.Search_BLL(txt_Search.Text);
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (BLL.QL_User_BLL.Instance.delUser_BLL(r))
            {
                ShowDGV();
                MessageBox.Show("Xóa thành công !");
            }
            else
            {
                MessageBox.Show("Xóa thất bại !");
            }
        }
    }
}
