namespace TasKagıtMaka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taş-Kağıt-Makas oyununa Hoşgeldiniz");
            string[] secenekler = ["taş", "kağıt", "makas" ];
            int KazanılanOyun = 0;
            int KaybedilenOyun = 0;
            string KullanıcıSecimi = "";
            Random random = new Random();


            while (true)
            {
                Console.WriteLine("Yapamak istediğiniz seçimi yazınız.");
                Console.WriteLine("taş|kağıt|makas|çıkış");
                KullanıcıSecimi=Console.ReadLine();

                if (KullanıcıSecimi == "çıkış")
                {
                    Console.WriteLine("Çıkış Yapılıyor.İyi Günler...");
                    break;

                }

                int bilgisayarSecimiIndex=random.Next(secenekler.Length);
                string bilgisayarSecimi = secenekler[bilgisayarSecimiIndex];

                Console.WriteLine(bilgisayarSecimi);
                if (KullanıcıSecimi == bilgisayarSecimi)
                {
                    Console.WriteLine("Berabere..");
                    continue;
                }


                if (KullanıcıSecimi=="taş" && bilgisayarSecimi=="makas")
                {
                    Console.WriteLine("Taş makası kırar Tebrikler Kazandın");
                    KazanılanOyun++;
                }
                else if( KullanıcıSecimi == "kağıt" && bilgisayarSecimi == "taş")
                {
                    Console.WriteLine("KAğıt taşı sarar Tebrikler Kazandın");
                    KazanılanOyun++;
                }
                else if(KullanıcıSecimi=="makas" && bilgisayarSecimi == "kağıt")
                {
                    Console.WriteLine("Makas Kağıdı keser kazandınız");
                    KazanılanOyun++;
                }
                else
                {
                    Console.WriteLine("Kaybettin... Tekrar dene");
                    KaybedilenOyun++;
                }




                Console.WriteLine($"kazanılan oyun: { KazanılanOyun}  ,kaybedilen oyun: {KaybedilenOyun}");
            }
        }
    }
}
