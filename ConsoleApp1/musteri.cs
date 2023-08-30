using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class musteri 
    {
        private string ad;
        private string soyad;
        private string cinsiyet;
        private int yas;
        private string ibanNo;


        public string ADI //İsim 10 karakter sınırlaması getirme;
        {
            get { return ad; }
            set
            {
               
                if (value.Length < 10)
                {
                    ad = value;
                    
                }
                else
                {
                    repeat:
                    Console.WriteLine("İsim 10 karakterden fazla olamaz!");
                    ad = Console.ReadLine();
                    if(ad.Length >10 )
                    {
                        goto repeat;
                    }
                }
            }
            
        }

        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToLower(); } //bütün hafleri küçük yapar
        }

        public string CINS //K yada E giriş yapılmalı;
        {
            get { return cinsiyet; }
            set
            {
                if(value == "K" || value =="E" )
                {
                    cinsiyet = value;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız!K ya da E seçimi yapınız");
                }

                        
            }
        }

        public int YASI //Reşit olma sınırlaması;
        {
            get { return yas; }
            set {   if (value <18)
                {
                    Console.WriteLine("Yaş 18'den küçük olamaz!");
                    yas = 18;
                }
                else
                {
                   yas = value; 
                }
            }
        }


        public string IBAN // iban no 12 hane sınırlaması;  //normalde int değer olarak tanımlamıştım fakat 12 haneli iban no convert32 ye büyük geldiği için string değere dönüştürüp bu yolu kullandım.
        {
            get { return ibanNo; }
            set
            {
                if (value.Length >= 12 && value.All(char.IsDigit) && value[0] != '-') // min 12 karakter ve negatif değil ayrıca IsDigit ifadesiyle değerin rakamlardan oluşup oluşmadığını kontrol eder
                {
                    ibanNo = value;
                }
                else
                {
                    Console.WriteLine("Geçersiz İban No!");

                    string newIban;
                    do
                    {
                        Console.WriteLine("Geçerli bir IBAN No giriniz:");
                        newIban = Console.ReadLine(); // yeni IBAN no istenir
                    } while (newIban.Length < 12 || !newIban.All(char.IsDigit) || newIban[0] == '-');

                    ibanNo = newIban;
                }
            }
        }




    }
}
