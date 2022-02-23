using System;

namespace Console_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool readyForHolidays = false;
            int fuelLevel = 30;

            if (fuelLevel >= 50
            {
                Console.WriteLine("Niveau de carburant OK !");
                readyForHolidays = true;
            }
            else
            {
                Console.WriteLine("ATTENTION : pas assez de carburant !");
                readyForHolidays = false;
            }
            Console.ReadLine();
        }
    }
}
