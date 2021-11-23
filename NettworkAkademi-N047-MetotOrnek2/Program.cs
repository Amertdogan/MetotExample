using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NettworkAkademi_N047_MetotOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
        #region
        /*Matematik adında bir class oluşturun.
         * Bir menü hazırlayın metot ile
         * Menüde
         * "*****Menü*****"
         * "1-Toplama"
         * "2-Çıkartma"
         * "3-Çarpma"
         * "4-Bölme"
         * "Lütfen bir deger seçiniz"
         * Metot ile 4 işlemleri ekrana  yazdırılacak.
         * public static void içinde matematik sınıfının bir instance'ini al
         * kullanıcıdan 2 deger iste ve Matematik sınıfındaki 4 işlem metotunu kullanarak
         * sonucları ekrana yazdır.switch case
         * Yeniden iişlem yapmak isteyip istemediğini sorunuz.
         */

        #endregion
        

            Matematik M = new Matematik();
        baslangıc:
            M.menuHazirla();
            int kullanıcıSecim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 1. sayı degerini giriniz.");
            decimal kullanıcıSayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2. sayı degerini giriniz.");
            decimal kullanıcıSayi2 = Convert.ToInt32(Console.ReadLine());
            decimal sonuc = 0;
            switch (kullanıcıSecim)

            {
                case 1:
                    sonuc = M.toplamaIslemi(kullanıcıSayi1, kullanıcıSayi2);
                    M.sonucEkranaYaz(kullanıcıSayi1, kullanıcıSayi2, sonuc, "+");
                    break;
                case 2:
                    sonuc = M.cikartmaIslemi(kullanıcıSayi1, kullanıcıSayi2);
                    M.sonucEkranaYaz(kullanıcıSayi1, kullanıcıSayi2, sonuc, "-");
                    break;
                case 3:
                    sonuc = M.carpmaIslemi(kullanıcıSayi1, kullanıcıSayi2);
                    M.sonucEkranaYaz(kullanıcıSayi1, kullanıcıSayi2, sonuc, "x");
                    break;
                case 4:
                    sonuc = M.bolmeIslemi(kullanıcıSayi1, kullanıcıSayi2);
                    M.sonucEkranaYaz(kullanıcıSayi1, kullanıcıSayi2, sonuc, "/");
                    break;
                default:
                    Console.WriteLine("Belirtmiş oldugunuz deger liste icerisinde bulunamadı.");
                    Console.WriteLine("Lütfen tekrar deneyiniz.");
                    System.Threading.Thread.Sleep(2000);
                    goto baslangıc;



            }
            Console.WriteLine("Tekrardan islem yapmak istiyor musunuz ? E/H");
            String secim2 = Console.ReadLine();
            if (secim2.ToUpper() == "E")
            {
                goto baslangıc;
            }



            Console.ReadLine();
        }
    }
}
