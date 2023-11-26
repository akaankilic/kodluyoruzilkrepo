using System.ComponentModel;

namespace odev1;

class Program
{
    static void Main(string[] args)
    {
        //Odev-1-Soru-1
        Console.WriteLine("Bir pozitif sayı giriniz");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        int[] sayilar = new int[sayi1];
        Console.WriteLine(sayi1 + " adet pozitif sayı giriniz");
        for (int i = 0; i < sayi1; i++)
        {
            sayilar[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(" Girilen Sayılardan çift olanlar..");
        for (int i = 0; i < sayi1; i++)
        {
            if (sayilar[i] % 2 == 0)
            {
                Console.Write(sayilar[i]);
                Console.WriteLine(" **");
            }
        }
        //odev-1-Soru-2
        Console.WriteLine(" İki pozitif sayı giriniz");
        int say1 = Convert.ToInt32(Console.ReadLine());
        int say2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(say1 + " adet pozitif sayı giriniz");
        int[] bolunenler = new int[say1];
        for (int i = 0; i < say1; i++)
        {
            bolunenler[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Girdiğiniz 2.Sayıya Eşit yada Tam Bölünen sayılar");
        for (int i = 0; i < say1; i++)
        {
            if (bolunenler[i] % say2 == 0 || bolunenler[i] == say2)
            {
                Console.Write(bolunenler[i]);
                Console.Write("**");
                Console.WriteLine(" ");

            }
        }

        //odev-1 -Soru-3
        Console.WriteLine("Kaç Adet Kelime Sıralamak İstiyorsunuz");
        int kelimeSayisi = Convert.ToInt32(Console.ReadLine());
        string[] kelimeler = new string[kelimeSayisi];
        Console.WriteLine("Kelimeleri giriniz");
        for (int i = 0; i < kelimeSayisi; i++)
        {
            kelimeler[i] = Console.ReadLine();
        }
        Array.Reverse(kelimeler);
        for (int i = 0; i < kelimeSayisi; i++)

        {
            Console.WriteLine("---");
            Console.WriteLine(kelimeler[i]);
        }
        // odev-1-Soru-4 

        Console.WriteLine("Bir Cümle yazınız..");
        string cümleTüm = Console.ReadLine();
        string[] cumle = cümleTüm.Split(' ');
        Console.WriteLine("Kelime sayısı: " + cumle.Length);
        int space = cümleTüm.Count(char.IsWhiteSpace);
        string yenidenCumle = String.Join("", cumle);
        char[] harfler = yenidenCumle.ToCharArray();
        Console.WriteLine($"Harf sayısı:  +{harfler.Count()}" );

    }
}
