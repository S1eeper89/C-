namespace cyklus_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"jím sučenkui číslo {i}");
            //}

            //{

            //}

            //int pocetSusenek = 4;
            //int startovaciSusenka = 0;
            //for (int cisloSusenky = startovaciSusenka; cisloSusenky < pocetSusenek; cisloSusenky++)
            //{
            //    Console.WriteLine($"Jim susenku cislo {cisloSusenky+1}");
            while (true)
            {
                Console.WriteLine("Vykonávám první část programu...");

                Console.WriteLine("Chceš skončit program? A/N");

                string vstupUzivatele = Console.ReadLine();


                if (vstupUzivatele == "A")
                {
                    break; //vyskoci z c
                    //return; //ukonci program
                }


                Console.WriteLine("Chceš přeskočit na další část programu?");
                vstupUzivatele = Console.ReadLine();
                if (vstupUzivatele == "A")
                {
                    continue;
                }



                Console.WriteLine("Vykonávám druhou část programu...");

                

            }

            Console.WriteLine("Program končí");


        }
    }
}
