using CNPM_SE_12.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_SE_12.BLL
{
    class QL_Account_BLL
    {
        private static QL_Account_BLL _Instance;
        public static QL_Account_BLL Instance

        {
            get
            {
                if (_Instance == null)
                    _Instance = new QL_Account_BLL();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private QL_Account_BLL()
        {

        }
        public List<Account> getAccount_BLL()
        {
            SE_12Entities db = new SE_12Entities();
            List<Account> account = db.Accounts.Select(p => p).ToList();
            return account;
        }

        public Account getAccount_byID_BLL(string id_account)
        {
            SE_12Entities db = new SE_12Entities();
            Account acc = db.Accounts.Where(p => p.ID_Account == id_account).FirstOrDefault();
            return acc;
        }
        public List<Account> Search_BLL(String Search)
        {
            SE_12Entities db = new SE_12Entities();
            List<Account> account = new List<Account>();
            if (Search == "")
            {
                account = db.Accounts.Select(p => p).ToList();
            }
            else account = db.Accounts.Where(p => p.ID_Account.Contains(Search)).ToList();
            return account;
        }
        public bool Update_Pass_BLL(string ID, string newPass)
        {
            if (newPass == "")
            {
                return false;
            }
            try
            {
                SE_12Entities db = new SE_12Entities();
                db.Accounts.Where(p => p.ID_Account == ID).FirstOrDefault().PassWord = newPass;
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
