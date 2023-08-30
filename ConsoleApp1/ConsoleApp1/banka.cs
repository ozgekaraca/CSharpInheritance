using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class banka: musteri
    {
        private string bankaAdi;
        private string subeAdi;
        private int faizOrani;

        public string BADI
        {
            get { return bankaAdi; }
            set { bankaAdi = value.ToUpper();} //büyük harf yapma
        }

        public string SUBE
        {
            get { return subeAdi; }
            set 
            { 
                if(!string.IsNullOrEmpty(value)) //girilen değer boş değilse
                {
                    string lowerValue = value.ToLower(); //girilen değeri küçük harf yapma
                    subeAdi= char.ToUpper(lowerValue[0]) +lowerValue.Substring(1);
                }
            } 
        }

        public int FAIZ
        {
            get { return faizOrani; }
            set { faizOrani = Math.Abs(value); } //mutlak değer 
        }



    }
}
