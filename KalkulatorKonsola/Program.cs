using Microsoft.VisualBasic.FileIO;
using System;

namespace KalkulatorKonsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            while (option != 5)
            {
                Console.WriteLine(" __________\r\n" +
                  "| ________ |\r\n" +
                  "||12345678||\r\n" +
                  "|\"\"\"\"\"\"\"\"\"\"|\r\n" +
                  "|[M|#|C][-]|\r\n" +
                  "|[7|8|9][+]|\r\n" +
                  "|[4|5|6][x]|\r\n" +
                  "|[1|2|3][%]|\r\n" +
                  "|[.|O|:][=]|\r\n\"----------\" ");
                Console.WriteLine("Wybierz operacje:");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnożenie");
                Console.WriteLine("4. Dzielenie");
                Console.WriteLine("5. Wyjście");

                // Pobierz wybór od użytkownika
                option = Convert.ToInt32(Console.ReadLine());

                // Wykonaj odpowiednią operację na podstawie wyboru użytkownika
                double result = 0;
                double number1, number2;
                switch (option)
                {
                    case 1:
                        TakeNumbers(out number1, out number2);
                        result = Sum(number1, number2);
                        Console.WriteLine("Wynik: " + result);
                        break;
                    case 2:
                        TakeNumbers(out number1, out number2);
                        result = Subtraction(number1, number2);
                        Console.WriteLine("Wynik: " + result);
                        break;
                    case 3:
                        TakeNumbers(out number1, out number2);
                        result = Multiplication(number1, number2);
                        Console.WriteLine("Wynik: " + result);
                        break;
                    case 4:
                        TakeNumbers(out number1, out number2);
                        result = Division(number1, number2);
                        Console.WriteLine("Wynik: " + result);
                        break;
                    case 5:
                        Console.WriteLine("Dziękuje za skorzystanie z aplikacji.");
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór.");
                        continue;
                }

                static double Sum(double number1, double number2)
                {
                    return number1 + number2;
                }

                static double Subtraction(double number1, double number2)
                {
                    return number1 - number2;
                }

                static double Multiplication(double number1, double number2)
                {
                    return number1 * number2;
                }

                static double Division(double number1, double number2)
                {
                    if (number2 != 0)
                    {
                        return number1 / number2;
                    }
                    else
                    {
                        Console.WriteLine("Nie można dzielić przez zero.");
                        return 0; // lub inna wartość oznaczająca błąd
                    }
                }


                static void TakeNumbers(out double number1, out double number2)
                {
                    Console.Write("Podaj pierwszą liczbę: ");
                    number1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Podaj drugą liczbę: ");
                    number2 = Convert.ToDouble(Console.ReadLine());
                }

            }

        }
    }
}
