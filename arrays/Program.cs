namespace arrays;

class Program
{
    static void Main(string[] args)
    {
          // Dizi Tanımlama

            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim 
            renkler[0] = "Mavi";
            dizi[3] = 10;


            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);


            // Döngüler ve dizi kullanımı
            // Klavyeden girilen n tane sayının ortalamasını alan bir örnek

            Console.Write("Lütfen eleman sayisini giriniz :");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayıdizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz", i + 1);
                sayıdizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var sayi in sayıdizisi)
                toplam += sayi;

            Console.WriteLine("Ortalama :" + toplam / diziUzunlugu);

            //Sort
            int[] sayilar = { 23, 12, 86, 72, 3, 11, 17 };
            Console.WriteLine("Sırasız Dizi");
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("Sıralı Dizi");
            Array.Sort(sayilar);
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            //Clear : sayı dizisi elemanlarını kullanarak 2. indexten itibaren 2 tane elemanı 0 lar
            Console.WriteLine("Array Clear");
            Array.Clear(sayilar, 2,3);
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            //Reverse : verdiğimiz diziyi tersine çevirir
            Console.WriteLine("Array Reverse");
            Array.Reverse(sayilar);
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            //İndexOf Verdiğmiz elemanın indexsini döner..
            Console.WriteLine("Array İndexof");
           
            Console.WriteLine(Array.IndexOf(sayilar, 23));
            //Resize : yeniden boyutlandırma
            Console.WriteLine("Array Resize");
            Array.Resize<int>(ref sayilar, 9);
            sayilar[8] = 99;
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.ReadLine();
   
    }
}
