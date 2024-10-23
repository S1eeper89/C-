﻿namespace Du_lekce4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Začátek programu");

                Console.WriteLine("Zadej první hodnotu.");

                // , kter8 i trzparsuje double

                if (double.TryParse(Console.ReadLine(), out double firstNumber))
                {
                    Console.WriteLine("Zadej operátor (+) (-) (*) (/) ");
                }
                else
                {
                    Console.WriteLine("Nezadal jsi číslo, prosím zadej číslo.");
                    return;
                }
                
                string firstOperator = Console.ReadLine();

                // logika pro yad8n9 oper8toru vzlucuj9c9 jine ney +-*/ operatorz

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
                        break;
                    case "-":
                        vysledek = firstNumber - secondNumber;
                        Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                        break;
                    case "*":
                        vysledek = firstNumber * secondNumber;
                        Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                        break;
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
                        break;



                }






                Console.WriteLine("Konec Programu");
            }
        }
    }
}