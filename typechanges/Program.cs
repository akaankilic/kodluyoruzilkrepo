using System;
using System.ComponentModel;

namespace typechanges;

class Program
{
    static void Main(string[] args)
    {
    // implicit conversion(biçimsiz dönüşüm)

        byte x=5;
        sbyte y=20;
        short v=10;
        int d =x+y+v;
        System.Console.WriteLine("d:"+d);

        long h=d;
        System.Console.WriteLine("h:"+h);
        float g=h;
        System.Console.WriteLine("g:"+g);

        string ad="Kaan";
        char e='A';
        object o=ad+e+g;
        System.Console.WriteLine("o: "+o);

        //explit conversion (bilinçli bönüşüm)
        System.Console.WriteLine("******Explit Conversion****");

        int ab=4;
        byte cc=(byte)ab;
        System.Console.WriteLine("cc: "+cc);
         int s=100;
         byte tt=(byte)s;
         System.Console.WriteLine("cc:"+tt);
         float w=10.3f;
         byte qq=(byte)w;
         System.Console.WriteLine("qq:"+qq);

         // to string metodu
         System.Console.WriteLine("**** toString metodu****");

         int op=7;
         string lal=op.ToString();
         System.Console.WriteLine("lal :"+lal);

         string zz=12.5f.ToString();
         Console.WriteLine("zz:"+zz);

         ////system convert
         System.Console.WriteLine("*****system.convert sınıfı******");

         string s1="10",s2="20";
         int sayi1,sayi2;
         int toplam;
         sayi1=Convert.ToInt32(s1);
         sayi2=Convert.ToInt32(s2);
         toplam=sayi1+sayi2;
         Console.WriteLine("toplam ="+toplam);

         // parse 
         Console.WriteLine("*****parse işlemi****");
         ParseMethod();

    }

    public static void ParseMethod(){
        string metin1="10";
        string metin2="10.25";
        int rakam1;
        double double1;

        rakam1=Int32.Parse(metin1);
        double1=Double.Parse(metin2);
        System.Console.WriteLine("double1= "+double1);
        System.Console.WriteLine("rakam1 ="+rakam1);
    }
}
