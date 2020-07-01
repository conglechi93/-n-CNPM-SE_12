using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SE_12
{
    public class HassPass
    {
        public string MD5(string password)
        {
            byte[] textBytes = Encoding.Default.GetBytes(password);
            try
            {
                MD5CryptoServiceProvider cryptHandler;
                cryptHandler = new MD5CryptoServiceProvider();
                byte[] hash = cryptHandler.ComputeHash(textBytes);
                string ret = "";
                foreach (byte a in hash)
                {
                    if (a < 16)
                        ret += "0" + a.ToString("x");
                    else
                        ret += a.ToString("x");
                }
                return ret;
            }
            catch
            {
                throw;
            }
        }
        public string SHA1(string password)
        {
            byte[] textBytes = Encoding.Default.GetBytes(password);
            try
            {

                SHA1CryptoServiceProvider sha1crypt;
                sha1crypt = new SHA1CryptoServiceProvider();
                byte[] hash = sha1crypt.ComputeHash(textBytes);
                string passencrypt = "";
                foreach (byte a in hash)
                {
                    if (a < 16)
                        passencrypt += "0" + a.ToString("x");
                    else
                        passencrypt += a.ToString("x");
                }
                return passencrypt;
            }
            catch
            {
                throw;
            }
        }
        public string MD52(string a, int solan)
        {
            string kq = a;
            for (int i = 0; i < solan; i++)
            {
                kq = MD5(kq);
            }
            return kq;
        }
        public string SHAn(string a, int solan)
        {
            string kq = a;
            for (int i = 0; i < solan; i++)
            {
                kq = SHA1(kq);
            }
            return kq;
        }
        public string enrsa(string data)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] newdata = Encoding.Default.GetBytes(data);
            byte[] endata = rsa.Encrypt(newdata, false);
            string strencrypt = "";
            for (int i = 0; i < endata.Length; i++)
            {
                strencrypt += endata[i].ToString();
            }
            return strencrypt;
        }
        public string getbit(string data)
        {
            byte[] nedata = Encoding.Default.GetBytes(data);
            return Encoding.UTF8.GetString(nedata);
        }

        public byte[] hash(string password)
        {
            byte[] textBytes = Encoding.Default.GetBytes(password);
            try
            {
                MD5CryptoServiceProvider cryptHandler;
                cryptHandler = new MD5CryptoServiceProvider();
                byte[] hash = cryptHandler.ComputeHash(textBytes);

                return hash;
            }
            catch
            {
                throw;
            }
        }

    }
}

