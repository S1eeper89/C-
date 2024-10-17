using System;

namespace Druha_lekce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 2;

            int numberTwo = 5;

            int numberThree = numberOne + numberTwo;

            Console.WriteLine(numberThree);

            Console.WriteLine("Napis jmeno");

            string name = Console.ReadLine();

            if (name == "Admin")
            {
                Console.WriteLine("Jsi prihlasen s přihlášen s administrátorskými právy");
            }
            else if (name == "User")
            {
                Console.WriteLine("Jsi prihlasen s přihlášen s uživatelskými právy");
            }
            else
            {
                Console.WriteLine("Uzivatel je neznamy a nebyl prihlasen");
            }


            Console.WriteLine("Konec programu");

            int correctNumber = 666;


            int guessNumber = 666;

            if (guessNumber > correctNumber && guessNumber naber)

            else if (guessNumber > correctNumber)
            {
                Console.WriteLine("tip je příliš vysoký");
            }
            else if (guessNumber < correctNumber)
            {
                Console.WriteLine("tip je příliš nízký");
            }
            else if (guessNumber == correctNumber)
            {
                Console.WriteLine("gratuluji uživateli, uhádl jsi správně");
            }
            

        }
    }
}
