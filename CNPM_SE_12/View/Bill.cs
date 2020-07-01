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
        private string ID_Account;
        private int Total;
        private List<data_Order> li_O;
        public mydel D { get; set; }

        public delegate void mydel();
        public Bill(string id_account, int total, List<data_Order> list)
        {
            this.ID_Account = id_account;
            this.Total = total;
            li_O = list;
            InitializeComponent();
            SetData();

        }

        private void SetData()
        {
            lb_UserID.Text = lb_UserID.Text + "   " + ID_Account;
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

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            savePayment();
        }

        private void savePayment()
        {
            List<string> str = new List<string>();
            int total = 0;
            foreach (DataGridViewRow i in DGV_Show.Rows)
            {
                if (i.Cells[3].Value != null)
                {
                    string id_item = i.Cells[0].Value.ToString();
                    Item item = BLL.QL_Items_BLL.Instance.getItems_byID_BLL(id_item);
                    int price = Convert.ToInt32(i.Cells[2].Value.ToString());
                    int value = Convert.ToInt32(i.Cells[3].Value.ToString());
                    BLL.QL_Items_BLL.Instance.Edit_Items_BLL(id_item, item.Items_Name, item.Price.ToString(), (item.Reserve - value).ToString(), item.ID_Category);
                    total += price * value;
                }
            }
            if (BLL.QL_Payment.Instance.Add_Payment_BLL(ID_Account, Convert.ToDateTime(DateTime.Now.ToShortTimeString()), total))
            {
                MessageBox.Show("Đã thanh toán !");
                if (D != null)
                {
                    D();
                    this.Close();
                };
            }
        }
    }
}
