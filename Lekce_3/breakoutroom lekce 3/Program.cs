namespace breakoutroom_lekce_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odpovidej prosím ano / ne");
            Console.WriteLine("Máš čas na čtení knihy?");

            string odpovedCteni = Console.ReadLine().ToLower();
            bool masCasNaCteni = (odpovedCteni == "ano");

            Console.WriteLine("Máš čas na sport?");

            string odpovedSport = Console.ReadLine().ToLower();
            bool masCasNaSport = (odpovedSport == "ano");

            if (masCasNaCteni && masCasNaSport)
            {
                Console.WriteLine("Máš čas na čtení i sport!");
            }
            else if (masCasNaCteni || masCasNaSport)
            {
                Console.WriteLine("Máš čas alespoň na jednu aktivitu!");
            }
            else
            {
                Console.WriteLine("Nemáš čas na žádnou z aktivit dnes.");
            }




        }
    }
}
