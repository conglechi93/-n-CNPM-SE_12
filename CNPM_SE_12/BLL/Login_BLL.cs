using CNPM_SE_12.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_SE_12.BLL
{
    public class Login_BLL
    {
        private HassPass H = new HassPass();
        private static Login_BLL _Instance;
        public static Login_BLL Instance

        {
            get
            {
                if (_Instance == null)
                    _Instance = new Login_BLL();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private Login_BLL()
        {

        }



        public bool CheckAccount(string login, string pass)
        {
            SE_12Entities DB = new SE_12Entities();
            var account = DB.Accounts.Select(p => p);
            string s = H.MD5(pass);
            foreach (Account i in account.ToList())
            {
                if (login == i.Login && H.MD5(pass) == i.PassWord)
                {
                    return true;
                }
            }
            return false;
        }

        public string getIDUser(string login)
        {
            SE_12Entities DB = new SE_12Entities();
            var account = DB.Accounts.Select(p => p);
            foreach (Account i in account.ToList())
            {
                if (login == i.Login)
                {
                    return i.ID_Account;
                }
            }
            return null;
        }
    }
}
