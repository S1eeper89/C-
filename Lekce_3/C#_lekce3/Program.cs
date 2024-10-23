//namespace C__lekce3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Ahoj, ja jsem asistent na vyber vhodné aktivity podle nálady, jak se nyní cítíš?");
//            string vstupMesic = Console.ReadLine();

//            switch (vstupMesic)
//            {
//                case "Leden":
//                    Console.WriteLine("Veymi si teplou bundu a koyene botz.");
//                    break;
//                case "Unor":
//                    Console.WriteLine("Veymi si teplou bundu a koyene botz.");
//                    break;
//                case "Březen":
//                    Console.WriteLine("Máš narozeniny.");
//                    break;
//                default:
//                    Console.WriteLine("Špatnej měsíc bobe.");
//            }
//        }
//    }
//}

using System;

namespace C__lekce3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, já jsem asistent na výběr vhodné aktivity podle nálady, jak se nyní cítíš? (šťastná, unavená, znuděná, naštvaná, smutná)");
            string vstupNalada = Console.ReadLine();

            switch (vstupNalada.ToLower()) // Převod na malá písmena pro zjednodušení porovnávání
            {
                case "šťastná":
                    Console.WriteLine("Jdi na procházku do parku a užívej si sluníčko!");
                    break;
                case "unavená":
                    Console.WriteLine("Dej si šálek čaje a přečti si knihu.");
                    break;
                case "znuděná":
                    Console.WriteLine("Zahraj si nějakou zábavnou hru nebo vyzkoušej nový recept!");
                    break;
                case "naštvaná":
                    Console.WriteLine("Zkus se trochu protáhnout nebo si zaběhej, to ti pomůže uvolnit napětí.");
                    break;
                case "smutná":
                    Console.WriteLine("Podívej se na svůj oblíbený film nebo zavolej kamarádce na pokec.");
                    break;
                default:
                    Console.WriteLine("Zadej prosím jednu z následujících nálad: šťastná, unavená, znuděná, naštvaná, smutná.");
                    break;
            }
        }
    }
}
