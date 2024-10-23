namespace Opakování_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Začátek programu");

                Console.WriteLine("Zadej první hodnotu.");
                
                if (double.TryParse(Console.ReadLine(), out double firstNumber))
                {
                    Console.WriteLine("Zadej operátor (+) (-) (*) (/) ");
                }    
                else
                {
                    Console.WriteLine("Nezadal jsi číslo, program končí.");
                    return;
                }
                                
                string firstOperator = Console.ReadLine();

                if (firstOperator == "+" || firstOperator == "-" || firstOperator == "*" || firstOperator == "/")
                {
                    Console.WriteLine("Zadej druhou hodnotu.");
                }
                else
                {
                    Console.WriteLine("Nezadal jsi správný operátor, program končí.");
                    return;
                }

                if (double.TryParse(Console.ReadLine(), out double secondNumber))
                {
                    Console.WriteLine("Zádání je v pořádku, zpracovávám výpočet");
                }
                else
                {
                    Console.WriteLine("Nezadal jsi číslo, program končí.");
                    return;
                }
                               
                double vysledek;

                switch (firstOperator)
                {
                    case "+":
                        vysledek = firstNumber + secondNumber;
                        Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                    case "-":
                        vysledek = firstNumber - secondNumber;
                        Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                    case "*":
                        vysledek = firstNumber * secondNumber;
                        Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                    case "/":
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
                                
                
                
                


                Console.WriteLine("Konec Programu");
            }
        }
    }
}
