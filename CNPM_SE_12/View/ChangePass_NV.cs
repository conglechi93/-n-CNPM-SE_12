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
        private string ID_Account;
        public ChangePass_NV(string id_account)
        {
            InitializeComponent();
            this.ID_Account = id_account;
        }


    }
}
