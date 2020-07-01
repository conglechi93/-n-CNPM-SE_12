using CNPM_SE_12.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_SE_12.BLL
{
    class QL_Payment
    {
        private static QL_Payment _Instance;
        public static QL_Payment Instance

        {
            get
            {
                if (_Instance == null)
                    _Instance = new QL_Payment();
                return _Instance;
            }
            private set => _Instance = value;
        }

        private QL_Payment()
        {

        }

        public List<Order> getOrder()
        {
            try
            {
                SE_12Entities db = new SE_12Entities();
                List<Order> ord = db.Orders.Select(p => p).ToList();
                return ord;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }
        public bool Add_Payment_BLL(string id_account,DateTime time,int total)
        {
            try
            {
                SE_12Entities db = new SE_12Entities();
                string id = BLL.QL_User_BLL.Instance.getUser_byID(id_account).ID_Account;
                Order ord = new Order() { ID_Order = 4, ID_Account = id, Time_Order = time, Proceeds = total };
                db.Orders.Add(ord);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

    }
}
