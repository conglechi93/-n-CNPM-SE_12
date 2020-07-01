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
        private void btn_Reset_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Chart_Payment c = new Chart_Payment();
            c.Show();
        }
    }
}
