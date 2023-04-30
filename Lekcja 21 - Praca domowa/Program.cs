using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_21___Praca_domowa
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Część, odpowiedz na kilka pytań abym mógł się odpowiedno z Tobą przyiwtać");
                Console.WriteLine("Jak masz na imię");

                //imię
                string name = Console.ReadLine();

                //powiększanie pierwszej litery imiena
                name = char.ToUpper(name[0]) + name.Substring(1);

                int yearOfBirth = GetYear();
                int monthOfBith = GetMonth();
                int dayOfBith = GetDay(yearOfBirth, monthOfBith);

                // miejsce u rodzenia
                Console.WriteLine("Powiedz gdzie sie urodziłeś");
                string birthPlace = Console.ReadLine();

                //powiększanie pierwszej litery miejscowości
                birthPlace = char.ToUpper(birthPlace[0]) + birthPlace.Substring(1);

                int age = DateTime.Now.Year - yearOfBirth;

                if (yearOfBirth> DateTime.Now.DayOfYear)
                    age--;

                Console.WriteLine($"\n\nCześć {name} urodziłeś się w {birthPlace} i masz {age} lat!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Nieprawidłowe dane");
                throw ex;

            }
            finally
            {
                Console.WriteLine("Kliknij Enter aby zakończyć program");
                Console.ReadLine();
            }

        }

        private static int GetDay(int year, int month)
        {
            while (true)
            {
                Console.WriteLine("Podaj swój dzień urodzenia");
                if (!int.TryParse(Console.ReadLine(), out int day)
                    || day > DateTime.DaysInMonth(year, month) 
                    || day < 1)
                {
                    Console.WriteLine("Podano nieprawidłowy dzień, spróbuj ponownie\n");
                    continue;
                }

                return day;
            }
        }

        private static int GetMonth()
        {
            Console.WriteLine("Podaj swój miesiąc urodzenia");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int month) 
                    || month > 12 
                    || month < 1) 
                {
                    Console.WriteLine("Podano nieprawidłowy miesiąc, spróbuj ponownie\n");
                    continue; 
                }

                return month;
            }
        }

        private static int GetYear()
        {
            while (true)
            {
                Console.WriteLine("Podaj swój rok urodzenia");
                if (!int.TryParse(Console.ReadLine(), out int year) || year > DateTime.Now.Year)
                {
                    Console.WriteLine("Podano nieprawidłowy rok, spróbuj ponownie\n");
                    continue;
                }

                return year;
            }
        }


    }
}
