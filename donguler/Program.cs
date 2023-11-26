using System;

namespace donguler;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Kendisinden önceki tek sayıları görmek istediğiniz sayıyı giriniz...");
        // int sayi=int.Parse(Console.ReadLine());// girilen sayıya kadar olan tek sayıları yazdır.
        // for (int i = 1; i <=sayi; i++)
        // {//tek sayı bulmak için mod alma
        //     if (i%2==1)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }
        // // int sayacCift=0;
        // // int sayacTek=0;
        // // for (int i = 1; i <=1000; i++)
        // // {
        // //     if (i%2==0)
        // //     {
        // //         sayacCift=i+sayacCift;
        // //     }else{
        // //         sayacTek=i+sayacTek;
        // //     }
           
        // // }
        // // Console.WriteLine("Çift Sayıların toplamı=" +sayacCift);
        // // Console.WriteLine("Tek Sayıların toplamı=" +sayacTek);
        // for (int i = 0; i <= 10; i++)
        // {
        //     if (i==5)
        //     {
        //         continue;
        //     }
        //     Console.WriteLine(i);
        // }
        // for (int i = 0; i <= 10; i++)
        // {
        //     if (i==7)
        //     {
        //         break;
        //     }
        //     Console.WriteLine(i);
        // }
        //While**//
       Console.WriteLine("Lütfen bir sayı giriniz...");
       int sayi=int.Parse(Console.ReadLine());
       int sayac=1;
       int toplam=0;
        while (sayac<=sayi)
        {
            toplam+=sayac;
            sayac++;

        }
        Console.WriteLine(toplam/sayi);
        char character='a';
        while (character<'z')
        {
            Console.Write(character);
            character++;
        }
        Console.WriteLine("*******Foreach donsugu*******");

        string[] sehirler={"Ankara","İstanbul","Eskişehir","İzmir","Adana"};

        foreach (var sehir in sehirler)
        {
            Console.WriteLine(sehir);
        }


    
    }


}
