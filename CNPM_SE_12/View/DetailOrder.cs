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

namespace CNPM_SE_12.View
{
    public partial class DetailOrder : Form
    {
        private string ID_Ord;
        public DetailOrder(string ID)
        {
            this.ID_Ord = ID;
            InitializeComponent();
        }

        private void DetailOrder_Load(object sender, EventArgs e)
        {
            this.lb_IDBill.Text = "Mã hóa đơn:  HD" + ID_Ord.ToString();
            DGV_Show.ColumnCount = 3;
            DGV_Show.Columns[0].Name = "Mã sản phẩm";
            DGV_Show.Columns[1].Name = "Tên sản phẩm";
            DGV_Show.Columns[2].Name = "Số lượng";
            while (DGV_Show.Rows.Count > 1)
            {
                DGV_Show.Rows.RemoveAt(0);
            }
            foreach (Detail_Order i in BLL.QL_Payment.Instance.getOrder_byID(ID_Ord))
            {
                Item item = BLL.QL_Items_BLL.Instance.getItems_byID_BLL(i.ID_Items);
                ArrayList a = new ArrayList();
                a.Add(i.ID_Items);
                a.Add(item.Items_Name);
                a.Add(i.Amount);
                DGV_Show.Rows.Add(a.ToArray());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
