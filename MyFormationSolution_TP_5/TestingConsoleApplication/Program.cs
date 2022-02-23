using System;
using System.Collections.Generic;

namespace TestingConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program.Gateway();
        }

        static void Gateway()
        {
            Program.DivideByZero();
        }
        static void DivideByZero()
        {
            int lowerBound = 0;
            int upperBound = 1000;
            int iterations = upperBound;
            int finalValue = upperBound;
            int currentStep;
            int currentValue;
            Random random = new Random();
            for (currentStep = 1; currentStep <= iterations; currentStep++)
            {
                currentValue = random.Next(lowerBound, upperBound);
                finalValue /= currentValue;
            }
            Console.WriteLine($"La valeur finale vaut {finalValue}");
        }

        static void DivideByZero_OK()
        {
            int lowerBound = 0;
            int upperBound = 1000;
            int iterations = upperBound;
            int finalValue = upperBound;
            int currentStep;
            int currentValue;
            Random random = new Random();
            for (currentStep = 1; currentStep <= iterations; currentStep++)
            {
                currentValue = random.Next(lowerBound, upperBound);
                try
                {
                    finalValue /= currentValue;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"Division par zéro à l'étape {currentStep} !");
                }
            }
            Console.WriteLine($"La valeur finale vaut {finalValue}");
        }

        static void PersonsTest()
        {
            IList<Person> persons = new List<Person> {
                new Person { FirstName = "Victor", LastName = "Hugo" },
                new Person { FirstName = "Charles", LastName = "Baudelaire" },
                new Person { FirstName = "Jean", LastName = "Giono" },
                new Person { FirstName = "Gustave", LastName = "Flaubert" },
                new Person { FirstName = "Jean", LastName = "Racine" },
            };
            Console.WriteLine(persons);
        }
    }
}
