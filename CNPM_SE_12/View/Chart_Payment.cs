using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_SE_12.View
{
    public partial class Chart_Payment : Form
    {
        public Chart_Payment()
        {
            InitializeComponent();
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            chart_Bill.Series["VND Đồng"].Points.Add(60000);
            chart_Bill.Series["VND Đồng"].Points[0].Label = "60000";
            chart_Bill.Series["VND Đồng"].Points[0].Color = Color.Blue;
            chart_Bill.Series["VND Đồng"].Points[0].AxisLabel = "Tháng 1";
            chart_Bill.Series["VND Đồng"].Points.Add(30000);
            chart_Bill.Series["VND Đồng"].Points[1].Label = "30000";
            chart_Bill.Series["VND Đồng"].Points[1].Color = Color.Blue;
            chart_Bill.Series["VND Đồng"].Points[1].AxisLabel = "Tháng 2";
        }
    }
}
