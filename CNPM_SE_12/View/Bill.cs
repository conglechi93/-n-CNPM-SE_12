using CNPM_SE_12.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//ádgas
namespace CNPM_SE_12.View
{
    public partial class Bill : Form
    {
        private string ID_User;
        private int Total;
        private List<data_Order> li_O;
        public Bill(string id_user, int total, List<data_Order> list)
        {
            this.ID_User = id_user;
            this.Total = total;
            li_O = list;
            InitializeComponent();
            SetData();

        }

        private void SetData()
        {
            lb_UserID.Text = lb_UserID.Text + "   " + ID_User;
            lb_TongTien.Text = lb_TongTien.Text + "   " + Total.ToString();
            lb_GiamGia.Text = lb_GiamGia.Text + "   " + (Total / 10).ToString();
            lb_ThanhTien.Text = lb_ThanhTien.Text + "   " + (Total - (Total / 10)).ToString();
            lb_Time.Text = lb_Time.Text + Convert.ToDateTime(DateTime.Now.ToString()).ToString();
            DGV_Show.ColumnCount = 4;
            DGV_Show.Columns[0].Name = "Mã sản phẩm";
            DGV_Show.Columns[1].Name = "Tên sản phẩm";
            DGV_Show.Columns[2].Name = "Đơn giá";
            DGV_Show.Columns[3].Name = "Số lượng";
            while (DGV_Show.Rows.Count > 1)
            {
                DGV_Show.Rows.RemoveAt(0);
            }
            foreach (data_Order i in li_O)
            {
                ArrayList a = new ArrayList();
                a.Add(i.Items_ID);
                a.Add(i.Items_Name);
                a.Add(i.Price);
                a.Add(i.Values);
                DGV_Show.Rows.Add(a.ToArray());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("abca");
        }
    }
}
