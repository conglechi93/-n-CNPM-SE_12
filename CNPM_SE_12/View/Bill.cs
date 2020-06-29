using CNPM_SE_12.DTO;
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
    public partial class Bill : Form
    {
        private string ID_Type;
        private string ID_User;
        private int Total;
        private List<data_Order> list;
        public Bill(string id_user, int total, List<data_Order> l)
        {
            this.ID_User = id_user;
            this.Total = total;
            list = l;
            InitializeComponent();
            SetData();

        }

        private void SetData()
        {
            DGV_Show.DataSource = list;
            lb_UserID.Text = lb_UserID.Text + "   " + ID_User;
            lb_TongTien.Text = lb_TongTien.Text + "   " + Total.ToString();
            lb_GiamGia.Text = lb_GiamGia.Text + "   " + (Total / 10).ToString();
            lb_ThanhTien.Text = lb_ThanhTien.Text + "   " + (Total - (Total / 10)).ToString();
            lb_Time.Text = lb_Time.Text + Convert.ToDateTime(DateTime.Now.ToString()).ToString();


        }
        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("abca");
        }

        private void lb_Phone_Click(object sender, EventArgs e)
        {

        }

        private void lb_TongTien_Click(object sender, EventArgs e)
        {

        }
    }
}
