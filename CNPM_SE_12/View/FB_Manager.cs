using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using CNPM_SE_12.DTO;

namespace CNPM_SE_12.View
{
    public partial class FB_Manager : UserControl
    {
        public FB_Manager()
        {
            InitializeComponent();
        }

        private void FB_Manager_Load(object sender, EventArgs e)
        {
            DGV_Show.ColumnCount = 2;
            DGV_Show.Columns[0].Name = "Mã feedback";
            DGV_Show.Columns[1].Name = "Subject";

            List<Link> link = BLL.QL_FeedBack.Instance.getFB();
            while (DGV_Show.Rows.Count > 1)
            {
                DGV_Show.Rows.RemoveAt(0);
            }
            foreach (Link i in link)
            {
                ArrayList a = new ArrayList();
                a.Add(i.ID_FB);
                a.Add(i.Subject);
                DGV_Show.Rows.Add(a.ToArray());
            }
        }
    }
}
