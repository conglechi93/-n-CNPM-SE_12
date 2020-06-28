using CNPM_SE_12.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_SE_12.BLL
{
    class QL_User_BLL
    {
        private static QL_User_BLL _Instance;
        public static QL_User_BLL Instance

        {
            get
            {
                if (_Instance == null)
                    _Instance = new QL_User_BLL();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private QL_User_BLL()
        {

        }

        public User getUser_byID(string id_user)
        {
            SE_12Entities db = new SE_12Entities();
            User user = db.Users.Where(p => p.ID_Account == id_user).FirstOrDefault();
            return user;
        }
        #region
        public List<User> getUser_BLL()
        {
            SE_12Entities db = new SE_12Entities();
            List<User> user = db.Users.Select(p => p).ToList();
            return user;
        }
        public bool Check()
        {
            return true;
        }
        public bool Add_User_BLL(string ID_User, string User_Name, string Gender, string Birthday, string Phonenumber, string Passport, string Address, string ShiftTime, string Salary)
        {
            User user = new User();
            user.ID_Account = ID_User;
            user.User_Name = User_Name;
            if (Gender == "1")
                user.Gender = true;
            else
                user.Gender = false;
            user.Birthday = Convert.ToDateTime(Birthday);
            user.NumberPhone = Phonenumber;
            user.Pasport = Passport;
            user.Address = Address;
            user.Shift_Time = ShiftTime;
            user.Salary = Convert.ToInt32(Salary);
            try
            {
                SE_12Entities db = new SE_12Entities();
                db.Users.Add(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;

            }
        }
        public User Get_UserByID_BLL(string ID)
        {
            SE_12Entities db = new SE_12Entities();
            User user = db.Users.Where(p => p.ID_Account == ID).FirstOrDefault();
            return user;
        }

        //public void Get_UserInfor_BLL(string ID_User, string User_Name, string Gender, string Birthday, string Phonenumber, string Passport, string Address, string ShiftTime, string Salary)
        //{
        //    User user = new User();
        //    user.ID_User = ID_User;
        //    user.User_Name = User_Name;
        //    if (Gender == "1")
        //        user.Gender = true;
        //    else
        //        user.Gender = false;
        //    user.Birthday = Convert.ToDateTime(Birthday);
        //    user.NumberPhone = Phonenumber;
        //    user.Pasport = Passport;
        //    user.Address = Address;
        //    user.Shift_Time = ShiftTime;
        //    user.Salary = Convert.ToInt32(Salary);
        //    //Add_User_BLL(user);
        //}
        public bool delUser_BLL(DataGridViewSelectedRowCollection r)
        {
            try
            {
                SE_12Entities db = new SE_12Entities();
                foreach (User i in db.Users)
                {
                    foreach (DataGridViewRow j in r)
                    {
                        if (i.ID_Account == j.Cells["ID_Account"].Value.ToString())
                        {
                            db.Users.Remove(i);
                        }
                    }
                }
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        public bool Edit_Ctg_BLL(string ID_User, string User_Name, string Gender, string Birthday, string Phonenumber, string Passport, string Address, string ShiftTime, string Salary)
        {
            try
            {
                SE_12Entities db = new SE_12Entities();
                User user_clone = new User();
                user_clone.ID_Account = ID_User;
                user_clone.User_Name = User_Name;
                if (Gender == "1")
                    user_clone.Gender = true;
                else
                    user_clone.Gender = false;
                user_clone.Birthday = Convert.ToDateTime(Birthday);
                user_clone.NumberPhone = Phonenumber;
                user_clone.Pasport = Passport;
                user_clone.Address = Address;
                user_clone.Shift_Time = ShiftTime;
                user_clone.Salary = Convert.ToInt32(Salary);

                User user = db.Users.Where(p => p.ID_Account == ID_User).FirstOrDefault();
                user.ID_Account = user_clone.ID_Account;
                user.User_Name = user_clone.User_Name;
                user.Gender = user_clone.Gender;
                user.Birthday = user_clone.Birthday;
                user.NumberPhone = user_clone.NumberPhone;
                user.Pasport = user_clone.Pasport;
                user.Address = user_clone.Address;
                user.Shift_Time = user_clone.Shift_Time;
                user.Salary = user_clone.Salary;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        public List<User> Search_BLL(String Search)
        {
            SE_12Entities db = new SE_12Entities();
            List<User> user = new List<User>();
            if (Search == "")
            {
                user = db.Users.Select(p => p).ToList();
            }
            else user = db.Users.Where(p => p.User_Name.Contains(Search)).ToList();
            return user;
        }
        #endregion
    }
}
