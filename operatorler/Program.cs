namespace operatorler;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("-----atama ve işlemli atama-------");
        // Atama ve işlemli atama
        int x=3;
        int y=4;
        y=y+2;
        System.Console.WriteLine(y);
        y+=2;
        System.Console.WriteLine(y);
        y/=1;
        System.Console.WriteLine(y);
        x*=2;
        System.Console.WriteLine(x);

        System.Console.WriteLine("--------mantıksal operatorler------");
        // mantıksal operatorler
        //|| , && , !

        bool dogruMu= true;
        bool tamamlandıMı=false;

        if (dogruMu&&tamamlandıMı){
            System.Console.WriteLine("Mükemmel");
        }
        if (dogruMu||tamamlandıMı){
            System.Console.WriteLine("idare eder");
        }
        if (dogruMu&&!tamamlandıMı){
            System.Console.WriteLine("eh işte");
        }
        System.Console.WriteLine("-----ilişkisel operatorler---------");
        // ilişkisel operatorler
        // <, >, <=,=>, ==,!=
        int a=3;
        int b=4;
        bool result=a<b;
        System.Console.WriteLine(result);
        result=a>b;
        System.Console.WriteLine(result);
        result=a>=b;
        System.Console.WriteLine(result);
        result=a<=b;
        System.Console.WriteLine(result);
        result=a==b;
        System.Console.WriteLine(result);
        result=a!=b;
        System.Console.WriteLine(result);
        
        System.Console.WriteLine("-----Aritmetik operatorler----");
        // /,-,+,*

        int say1=10;
        int say2=5;
        int sonuc=say1/say2;
        System.Console.WriteLine(sonuc);
        sonuc=say1*say2;
        System.Console.WriteLine(sonuc);
        sonuc=say1+say2;
        System.Console.WriteLine(sonuc);
        sonuc=say1-say2;
        System.Console.WriteLine(sonuc);

        // %mod alma 
        System.Console.WriteLine("**********");
        int sonuc1=20%2;
        System.Console.WriteLine(sonuc1);



    }
}
