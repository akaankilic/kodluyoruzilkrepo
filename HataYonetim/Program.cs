using System;

namespace HataYonetim;

class Program
{
    static void Main(string[] args)
    {
       try
       {
        Console.WriteLine("Bir Sayı Giriniz ...");
        int sayi =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Girdiğiniz sayı "+sayi);
       }
       catch (System.Exception expsiton)
       {
        Console.WriteLine("Hata "+expsiton.Message.ToString());
        
       }
       //finally{
       // Console.WriteLine("İşlem Tamamlandı");
       //}
       try
       {
        //int a = int.Parse(null);
       // int a = int.Parse("ad");
        int a = int.Parse("32132132132");
       }
       catch (Exception ex)
       {
        Console.WriteLine("Yanlış veri tipi..");
        Console.WriteLine(ex);
       }
        
    }
}
