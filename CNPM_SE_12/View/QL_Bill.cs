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
using System.Runtime.InteropServices;

namespace CNPM_SE_12.View
{
    public partial class QL_Bill : UserControl
    {
        public QL_Bill(string id_account)
        {
            InitializeComponent();
            setData();
        }


        private void setData()
        {
            DGV_Show.ColumnCount = 4;
            DGV_Show.Columns[0].Name = "Mã hóa đơn";
            DGV_Show.Columns[1].Name = "Mã nhân viên";
            DGV_Show.Columns[2].Name = "Thời gian thanh toán";
            DGV_Show.Columns[3].Name = "Tổng tiền";
            while (DGV_Show.Rows.Count > 1)
            {
                DGV_Show.Rows.RemoveAt(0);
            }
            List<Order> ord = BLL.QL_Payment.Instance.getOrder();
            foreach (Order i in ord)
            {
                ArrayList a = new ArrayList();
                a.Add(i.ID_Order);
                a.Add(i.ID_Account);
                a.Add(Convert.ToDateTime(i.Time_Order).ToShortDateString());
                a.Add(i.Proceeds);
                DGV_Show.Rows.Add(a.ToArray());
            }

        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            List<int> data = getData();
            Chart_Payment c = new Chart_Payment(data);
            c.Show();
        }
        private List<int> getData()
        {
            List<Order> ord = BLL.QL_Payment.Instance.getOrder();
            List<int> total = new List<int>();
            for (int i = 1; i <= 12; i++)
            {
                int values = 0;
                foreach (Order o in ord)
                {
                    if (Convert.ToDateTime(o.Time_Order).Month == i )   
                        values += Convert.ToInt32(o.Proceeds);
                }
                total.Add(values);
            }
            return total;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //CreateAccount f = new CreateAccount();
            //f.ShowDialog();
        }
    }
}
