using System;

namespace Console_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool readyForHolidays = false;
            bool kidsStatus = true;
            string phoneStatus = "charged";

            if (kidsStatus && phoneStatus === "charged")
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
                Console.WriteLine(("10, 9, 8, 7, 6, 5, 4, 3, 2, 1...");
                Console.WriteLine("Vers l'infini...");
                Console.WriteLine("et au-delà...");
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
