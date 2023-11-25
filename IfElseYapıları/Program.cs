using System;

namespace IfElseYapıları;

class Program
{
    static void Main(string[] args)
    {
        int zaman=DateTime.Now.Hour;

        if (zaman <= 12&& zaman>=5 )
        
            Console.WriteLine("Günaydın..");
        else if(zaman<=18 &&zaman>=12){
            Console.WriteLine("İyi Günler..");
        }else if (zaman>=01&&zaman<=5)
        {
            Console.WriteLine("İyi Geceler..");
        }else{
            Console.WriteLine("İyi Akşamlar..");
        }
    }
}
