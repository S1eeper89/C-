namespace Opakování_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Začátek programu");

            // Ověření prvního čísla
            Console.WriteLine("Zadej první hodnotu.");
            string firstNumberText = Console.ReadLine();
            if (!double.TryParse(firstNumberText, out double firstNumber))
            {
                Console.WriteLine("Zadal jsi neplatný vstup pro první číslo.");
                return; // Konec programu
            }

            // Ověření operátoru
            Console.WriteLine("Zadej operátor (+) (-) (*) (/)");
            string firstOperator = Console.ReadLine();
            if (firstOperator != "+" && firstOperator != "-" && firstOperator != "*" && firstOperator != "/")
            {
                Console.WriteLine("Zadal jsi neplatný operátor.");
                return; // Konec programu
            }

            // Ověření druhého čísla
            Console.WriteLine("Zadej druhou hodnotu.");
            string secondNumberText = Console.ReadLine();
            if (!double.TryParse(secondNumberText, out double secondNumber))
            {
                Console.WriteLine("Zadal jsi neplatný vstup pro druhé číslo.");
                return; // Konec programu
            }

            // Výpočet výsledku
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
                    Console.WriteLine("Nulou nelze dělit.");
                }
                else
                {
                    vysledek = firstNumber / secondNumber;
                    Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                }
            }

            Console.WriteLine("Konec programu");
        }
    }
}