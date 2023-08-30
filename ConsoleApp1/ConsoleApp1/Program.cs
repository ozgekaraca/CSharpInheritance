using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
           login log = new login();

            Console.WriteLine("Kullanıcı Adı Giriniz: ");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifrenizi Giriniz: ");
            string sifre = Console.ReadLine();
            if (kullaniciAdi == "ozge" && sifre== "1234")
            {
                Console.WriteLine("Tebrikler, Başarılı giriş yaptınız!");
                kullaniciAdi= Console.ReadLine();
            }
                else
                 {

                  Console.WriteLine("Hatalı kullanıcı adı veya şifre!");
                }

            Console.ReadLine();
            Console.WriteLine("Bankamıza Hoşgeldiniz! ");
             banka bank = new banka();

            Console.WriteLine("Banka Adı Giriniz: ");
            bank.BADI = Console.ReadLine();

            Console.WriteLine("Şube Adı Giriniz: ");
            bank.SUBE = Console.ReadLine();

            Console.WriteLine("Faiz Oranı Giriniz: ");
            bank.FAIZ = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Müşteri Adı Giriniz: ");
            bank.ADI = Console.ReadLine();

            Console.WriteLine("Müşteri Soyadı Giriniz: ");
            bank.SOYAD = Console.ReadLine();

            Console.WriteLine("Müşteri Yaşı Giriniz: ");
            bank.YASI = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Müşteri Cinsiyeti Giriniz");
            bank.CINS = Console.ReadLine();

            Console.WriteLine("Müşteri Iban No Giriniz: ");
            bank.IBAN = Console.ReadLine();



            Console.WriteLine("Banka ve Müşteri Bilgileri Görüntüle: ");

            Console.WriteLine("Banka adı: " + bank.BADI);
            Console.WriteLine("Şube adı: " + bank.SUBE);
            Console.WriteLine("Faiz oranı: " + bank.FAIZ);
            Console.WriteLine("Müşteri adı: " + bank.ADI);
            Console.WriteLine("Müşteri soyadı: " + bank.SOYAD);
            Console.WriteLine("Müşteri yaşı: " + bank.YASI);
            Console.WriteLine("Müşteri cinsiyeti: " + bank.CINS);
            Console.WriteLine("Müşteri iban no: " + bank.IBAN);

            Console.ReadLine();


          
        }
    }
}
