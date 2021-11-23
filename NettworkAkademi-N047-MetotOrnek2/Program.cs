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
        baslangıc:
            

            int secim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir sayı giriniz.");
            int sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir sayı daha giriniz.");
            int sayı2 = Convert.ToInt32(Console.ReadLine());
            switch (secim)

            {
                case 1:
                    int toplama = sayı1 + sayı2;
                    Console.WriteLine("Toplama sonucu " + toplama);
                    break;
                case 2:
                    int cikartma = sayı1 - sayı2;
                    Console.WriteLine("Çıkartma sonucu " + cikartma);
                    break;
                case 3:
                    int carpma = sayı1 * sayı2;
                    Console.WriteLine("Çarpma sonucu " + carpma);
                    break;
                case 4:
                    int bolme = sayı1 / sayı2;
                    Console.WriteLine("Bölme sonucu " + bolme);
                    break;


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
