using System;

namespace Console_Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool readyForHolidays = false;
            int fuelLevel = 60;

            if (fuelLevel >= 50)
            {
                Console.WriteLine("Niveau de carburant OK !");
                readyForHolidays = true;
            }
            else
            {
                Console.WriteLine("ATTENTION : pas assez de carburant !");
                readyForHolidays = false;
            }

            if (readyForHolidays)
            {
                Console.WriteLine("10, 9, 8...");
                Console.WriteLine("Vers l'infini...");
                Console.WriteLine("6, 5, 4...");
                Console.WriteLine("et au-delà...");
                Consoul.WriteLine("3, 2, 1...");
                Console.WriteLine("Vive les vacances!");
            }
            else
            {
                Console.WriteLine("Demi-tour, on rentre à la maison...");
            }
            Console.ReadLine();
        }
    }
}
