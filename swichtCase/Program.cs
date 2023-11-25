namespace swichtCase;

class Program
{
    static void Main(string[] args)
    {
        int month=DateTime.Now.Month;

        switch (month)
        {
            case 1:
            Console.WriteLine("Ocak Ayındayız..");
            break;
            case 2:
             Console.WriteLine("Şubat Ayındayız..");
            break;
             case 3:
             Console.WriteLine("Mart Ayındayız..");
            break;
            case 4:
             Console.WriteLine("Nisan Ayındayız..");
            break;
            case 5:
             Console.WriteLine("Mayıs Ayındayız..");
            break;
            case 6:
             Console.WriteLine("Haziran Ayındayız..");
            break;
            case 7:
             Console.WriteLine("Temmuz Ayındayız..");
            break;
            case 8:
             Console.WriteLine("Ağustos Ayındayız..");
            break;
            case 9:
             Console.WriteLine("Eylül Ayındayız..");
            break;
            case 10:
             Console.WriteLine("Ekim Ayındayız..");
            break;
            case 11:
             Console.WriteLine("Kasım Ayındayız..");
            break;

            default:
                Console.WriteLine("Yanlış tarih girdiniz..");
                break;
        }
        switch (month)
        {
            case 1:
            case 2:
            case 12:
            case 11:
            Console.WriteLine("Kış Ayındasınız...");
            break;
            case 3:
            case 4:
            case 5:
            case 6:
            Console.WriteLine("İlkbahardasınız..");
            break;


            default:
            Console.WriteLine("Küresel ısınma mevsimi boşver");
            break;
        }
    }
}
