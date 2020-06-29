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
using System.Collections;

namespace CNPM_SE_12.View
{
    public partial class QL_User : UserControl
    {
        private string ID_Type;
        public QL_User(string id_account)

        {
            this.ID_Type = BLL.QL_Account_BLL.Instance.getTypeAccount_BLL(id_account);
            if (ID_Type != "3")
            {
                InitializeComponent();
                List<User> user = BLL.QL_User_BLL.Instance.getUser_BLL();
                ShowDGV(user);
            }
            else
            {
                MessageBox.Show(" Bạn không có quyền hạn này !");
            }

        }

        private void ShowDGV(List<User> user)
        {

            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "Mã nhân viên";
            dataGridView1.Columns[1].Name = "Tên nhân viên";
            dataGridView1.Columns[2].Name = "Giới tính";
            dataGridView1.Columns[3].Name = "Ngày sinh";
            dataGridView1.Columns[4].Name = "SĐT";
            dataGridView1.Columns[5].Name = "Ca làm";
            dataGridView1.Columns[6].Name = "Địa chỉ";
            dataGridView1.Columns[7].Name = "CMND";
            dataGridView1.Columns[8].Name = "Lương";


            while (dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            foreach (User i in user)
            {
                ArrayList a = new ArrayList();
                a.Add(i.ID_Account);
                a.Add(i.User_Name);
                a.Add(i.Gender);
                a.Add(i.Birthday.ToShortDateString());
                a.Add(i.NumberPhone);
                a.Add(i.Shift_Time);
                a.Add(i.Address);
                a.Add(i.Pasport);
                a.Add(i.Salary);
                dataGridView1.Rows.Add(a.ToArray());
            }
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Add();
            List<User> user = BLL.QL_User_BLL.Instance.getUser_BLL();
            ShowDGV(user);
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
                string ID = r[0].Cells["Mã nhân viên"].Value.ToString();
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

        private void Add()
        {
            string ID_User = txt_MaNhanVien.Text;
            string User_Name = txt_TenNhanVien.Text;
            string Gender = "0";
            if (rdb_Male.Checked == true) Gender = "1";
            string Birthday = Convert.ToDateTime(dateTimePicker1.Value).ToString();
            string Phonenumber = txt_SoDienThoai.Text;
            string Passport = txt_CMND.Text;
            string Address = txt_DiaChi.Text;
            string ShiftTime = txt_ShiftTime.Text;
            string Salary = txt_Salary.Text;
            if (BLL.QL_User_BLL.Instance.Add_User_BLL(ID_User, User_Name, Gender, Birthday, Phonenumber, Passport, Address, ShiftTime, Salary))
                MessageBox.Show("Add thành công!");
            else MessageBox.Show("Add thất bại");
            
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            string ID_User = txt_MaNhanVien.Text;
            string User_Name = txt_TenNhanVien.Text;
            string Gender = "0";
            if (rdb_Male.Checked == true) Gender = "1";
            string Birthday = dateTimePicker1.Value.ToString();
            string Phonenumber = txt_SoDienThoai.Text;
            string Passport = txt_CMND.Text;
            string Address = txt_DiaChi.Text;
            string ShiftTime = txt_ShiftTime.Text;
            string Salary = txt_Salary.Text;
            if (BLL.QL_User_BLL.Instance.Edit_User_BLL(ID_User, User_Name, Gender, Birthday, Phonenumber, Passport, Address, ShiftTime, Salary))
                MessageBox.Show("Add thành công!");
            else MessageBox.Show("Add thất bại");
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
            List<User> user = BLL.QL_User_BLL.Instance.Search_BLL(txt_Search.Text);
            ShowDGV(user);
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (BLL.QL_User_BLL.Instance.delUser_BLL(r))
            {
                List<User> user = BLL.QL_User_BLL.Instance.getUser_BLL();
                ShowDGV(user);
                MessageBox.Show("Xóa thành công !");
            }
            else
            {
                MessageBox.Show("Xóa thất bại !");
            }
        }
    }
}
