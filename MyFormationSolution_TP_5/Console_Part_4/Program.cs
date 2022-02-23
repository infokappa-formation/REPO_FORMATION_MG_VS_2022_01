using System;

namespace Console_Part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool readyForHolidays = false;
            int fuelLevel = 17000;
            bool kidsStatus = true;
            string phoneStatus = "charged";

            if (fuelLevel >= 20000)
            {
                Console.WriteLine("Niveau de carburant OK !");
                readyForHolidays = true;
            }
            else
            {
                Console.WriteLine("ATTENTION : pas assez de carburant !");
                readyForHolidays = false;
            }

            if (kidsStatus && phoneStatus == "charged")
            {
                Console.WriteLine("Enfants et téléphone OK !");
                readyForHolidays = true;
            }
            else
            {
                Console.WriteLine("ATTENTION : enfants ou téléphone pas encore OK !");
                readyForHolidays = false;
            }

            if (readyForHolidays)
            {
                Console.WriteLine("10, 9, 8, 7, 6, 5, 4, 3, 2, 1...");
                Console.WriteLine("Vers l'infini et au-delà !");
            }
            else
            {
                Console.WriteLine("Demi-tour, on rentre à la maison...");
            }
            Console.ReadLine();
        }
    }
}
