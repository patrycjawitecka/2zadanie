using System;

namespace _2zadanie

{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 calc = new Class1();
          
            for (; ; )
            {
                Console.WriteLine("Podaj liczby większe od 0");
                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);
               
                if (rating == 0)
                {
                    break;
                }
                if (result == true)
                {
                    calc.AddRating(rating);          
                }
               
            }


            //dopisacwyświetlanie pbranych liczb, ich ilość
            //wyświetlanie liczb: Console.WriteLine(result);
            Console.WriteLine("Wprowadzone liczby to: ");calc.GiveRating();
            Console.WriteLine("Ilość wprowadzonych liczb to:" + calc.GiveCountRating());
            Console.WriteLine("średnia twoich liczb to:" + calc.CalculateAverage());
            Console.WriteLine("najwyższa liczba to:" + calc.GiveMaxRating());
            Console.WriteLine("najniższa liczba to:" + calc.GiveMinRating());
            Console.WriteLine("mediana liczb to:" + calc.GiveMedianRating());
            Console.WriteLine("suma wyświetlanych liczb to:" + calc.GiveSumRating());
            Console.ReadKey();

        }
    }
 }
