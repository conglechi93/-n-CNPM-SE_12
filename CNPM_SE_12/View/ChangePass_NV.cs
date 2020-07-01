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
    public partial class ChangePass_NV : UserControl
    {
        public ChangePass_NV()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            hash("sha256", "");
        }
    }
}
