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
        private List<int> data;
        public Chart_Payment(List<int> data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            for(int i = 0; i <= 11; i++)
            {
                chart_Bill.Series["VND Đồng"].Points.Add(data[i]);
                chart_Bill.Series["VND Đồng"].Points[i].Label = data[i].ToString();
                chart_Bill.Series["VND Đồng"].Points[i].Color = Color.Blue;
                chart_Bill.Series["VND Đồng"].Points[i].AxisLabel = "Tháng " + (i + 1).ToString();
            }    
        }
    }
}
