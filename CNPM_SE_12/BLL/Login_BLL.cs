using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SE_12.BLL
{
    public class Login_BLL
    {
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
            foreach (Account i in account.ToList())
            {
                if (login == i.Login && pass == i.PassWord)
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
                    return i.ID_User;
                }
            }
            return null;
        }
    }
}
