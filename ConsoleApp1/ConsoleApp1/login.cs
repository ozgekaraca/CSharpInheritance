using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class login
    {
        private string kullaniciAdi;
        private string kullaniciSifre;

        public string User
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }

        public string Password
        {
            get { return kullaniciSifre; }
            set { kullaniciSifre = value; }
        }
    }
}
