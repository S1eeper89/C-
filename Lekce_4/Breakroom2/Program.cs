namespace Breakroom2
{
    internal class Program
    {
        static void Main(string[] args)
        //{
        //    int cislo;
        //    int posledniCislo = 20;
        //    for (int i = 0; i <= posledniCislo-2; i+=2)
        //        Console.WriteLine($"napiš číslo {i+2}");
        //    {

        //    }
        //}

        {
            int cislo;

            Console.WriteLine("Zadej počáteční číslo");

            bool zadejCislo = int.TryParse(Console.ReadLine(), out cislo);

            while (!zadejCislo)
            {
                Console.WriteLine("Zadaný znak není číslo");
                zadejCislo = int.TryParse(Console.ReadLine(), out cislo);
            }



            int posledniCislo;

            Console.WriteLine("Zadej druhé číslo");

            bool zadejDruheCislo = int.TryParse(Console.ReadLine(), out posledniCislo);


            while (!zadejDruheCislo)
            {
                Console.WriteLine("Zadaný znak není číslo");
                zadejDruheCislo = int.TryParse(Console.ReadLine(), out posledniCislo);
            }

            Console.WriteLine("Chceš sudá čísla? A/N");

            string suda = Console.ReadLine();

            int x = 0;

            if (suda == "A")
            {
                x = 2;
            }


            ;
            for (int i = cislo; i <= posledniCislo; i ++)
                Console.WriteLine($"napiš číslo {i}");
            
        }
    }
}
