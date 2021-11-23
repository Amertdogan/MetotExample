using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NettworkAkademi_N047_MetotOrnek2
{
    class Matematik
    {
        //Toplama
       public decimal toplamaIslemi(decimal sayi1,decimal sayi2)
        {
            decimal sonuc = sayi1 + sayi2;
            return sonuc;
        }

        //Çıkartma
        public decimal cikartmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }

        //Çarpma
        public decimal carpmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;
        }

        //Bölme
        public decimal bolmeIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }

        public void menuHazirla()
        {
            Console.WriteLine("*********MENU*********");
            Console.WriteLine("1-TOPLAMA");
            Console.WriteLine("2-ÇIKARTMA");
            Console.WriteLine("3-ÇARPMA");
            Console.WriteLine("4-BÖLME");
            Console.Write("Lütfen yaptırmak istediginiz islemi seciniz.");
        }

        public void sonucEkranaYaz(decimal kullanıcıSay1,decimal kullanıcıSayi2,decimal sonuc,string operators)
        {
            Console.WriteLine("{0} {1} {2} = {3}",kullanıcıSay1,operators,kullanıcıSayi2,sonuc);
        }



    }
}
