using System;

namespace KalkulatorKonsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Kalkulator");
                Console.WriteLine("Wybierz operacje:");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnożenie");
                Console.WriteLine("4. Dzielenie");
                Console.WriteLine("5. Wyjście");

                // Pobierz wybór od użytkownika
                int wybor = Convert.ToInt32(Console.ReadLine());

                if (wybor == 5)
                {
                    // Zakończ program, jeśli użytkownik wybierze 5
                    break;
                }

                Console.Write("Podaj pierwszą liczbę: ");
                double liczba1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Podaj drugą liczbę: ");
                double liczba2 = Convert.ToDouble(Console.ReadLine());

                double wynik = 0;

                // Wykonaj odpowiednią operację na podstawie wyboru użytkownika
                switch (wybor)
                {
                    case 1:
                        wynik = liczba1 + liczba2;
                        break;
                    case 2:
                        wynik = liczba1 - liczba2;
                        break;
                    case 3:
                        wynik = liczba1 * liczba2;
                        break;
                    case 4:
                        if (liczba2 != 0)
                        {
                            wynik = liczba1 / liczba2;
                        }
                        else
                        {
                            Console.WriteLine("Nie można dzielić przez zero.");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór.");
                        continue;
                }

                Console.WriteLine("Wynik: " + wynik);
                Console.WriteLine("Hello World!");
            }
        }
    }
}
