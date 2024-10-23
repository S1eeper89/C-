namespace DU2._3
{
    internal class Program
    {
        static void Main(string[] args)
        
            {
                Console.WriteLine("Začátek programu");

                Console.WriteLine("Zadej první hodnotu.");

                string firstNumberText = Console.ReadLine();

                double firstNumber = double.Parse(firstNumberText);

                Console.WriteLine("Zadej operátor (+) (-) (*) (/) ");

                string firstOperator = Console.ReadLine();

                Console.WriteLine("Zadej druhou hodnotu.");

                string secondNumberText = Console.ReadLine();

                double secondNumber = double.Parse(secondNumberText);

                double vysledek;


                if (firstOperator == "+")
                {
                    vysledek = firstNumber + secondNumber;
                    Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                }
                else if (firstOperator == "-")
                {
                    vysledek = firstNumber - secondNumber;
                    Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                }
                else if (firstOperator == "*")
                {
                    vysledek = firstNumber * secondNumber;
                    Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                }
                else if (firstOperator == "/")
                {
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Nulou nelze dělit");
                    }
                    else
                    {
                        vysledek = firstNumber / secondNumber;
                        Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                    }
                }
                else
                {
                    Console.WriteLine("Zadal jsi neplatný operátor");
                }


                Console.WriteLine("Konec Programu");
            }
        
    }
    }
