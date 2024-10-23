using System.ComponentModel.Design;

namespace Lekce4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Zadej první číslo:");
            //double desetinneCislo1;
            //bool jeCislo1 = double.TryParse(Console.ReadLine(), out desetinneCislo1);
            //if (jeCislo1)
            //{
            //    Console.WriteLine("Zadej operátor (+, -, *, /):");
            //}
            //else
            //{
            //    Console.WriteLine("Nezadal jsi cislo, hra konci, musis zadat cislo.");
            //    return;
            Console.WriteLine("Zadej svůj rok narození.");
            
            int rokNarozeni;
            int zadanyRokNarozeni;
            bool zadejroknarozeni = int.TryParse(Console.ReadLine(), out zadanyRokNarozeni);

            while (!zadejroknarozeni)
            {
                Console.WriteLine("Nezadal jsi číslo!");
                zadejroknarozeni = int.TryParse(Console.ReadLine(), out zadanyRokNarozeni);
            }
            int vek;
            DateTime datum = DateTime.Now;
            int year = datum.Year;
            vek = year - zadanyRokNarozeni;
            Console.WriteLine($"Je ti zhruba {vek} let.");

            Console.ReadLine();
            
            
        }
    }
}
