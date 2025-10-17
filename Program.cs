using ConsoleApp1;
using System;

class Program
{
    static void Main(string[] args)
    {
        JobManager job = new JobManager();
        string val = "";

        while (val != "6")
        {
            Console.WriteLine("\n<< Välkommen till arbetsförmedlingen >>");
            Console.WriteLine("1. Lägg till ny ansökan");
            Console.WriteLine("2. Visa alla ansökningar");
            Console.WriteLine("3. Uppdatera status på en ansökan");
            Console.WriteLine("4. Ta bort en ansökan");
            Console.WriteLine("5. Visa statistik (VG-del)");
            Console.WriteLine("6. Avsluta programmet");
            Console.Write("Ditt val: ");

            val = Console.ReadLine();

            switch (val)
            {
                case "1":
                    job.AddJob();
                    break;
                case "2":
                    job.ShowAll();
                    break;
                case "3":
                    job.UpdateStatus();
                    break;
                case "4":
                    job.RemoveJob();
                    break;
                case "5":
                    Console.WriteLine("Denna del är VG-nivå.");
                    break;
                case "6":
                    Console.WriteLine("Programmet avslutas...");
                    break;
                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;
            }
        }
    }
}
