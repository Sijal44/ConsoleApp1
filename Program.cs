using ConsoleApp1;
using System;

class Program
{
    static void Main(string[] args)
    {
        JobManager job = new JobManager(); // Skapar JobManager
        string val = "";

        while (val != "5") // Loop tills användaren avslutar
        {
            Console.WriteLine("<< Welcome to Job Application Tracker >>");
            Console.WriteLine("<< ************************************* >>");
            Console.WriteLine("1. Lägg till ny ansökan");
            Console.WriteLine("2. Visa alla ansökningar");
            Console.WriteLine("3. Uppdatera status på en ansökan");
            Console.WriteLine("4. Ta bort en ansökan");
            Console.WriteLine("5. Avsluta programmet");
            Console.Write("Ditt val ===> ");

            val = Console.ReadLine(); // Läs användarens val

            switch (val) // Kör metod beroende på valet
            {
                case "1":
                    job.AddJob(); // Lägg till ansökan
                    break;
                case "2":
                    job.ShowAll(); // Visa alla ansökningar
                    break;
                case "3":
                    job.UpdateStatus(); // Uppdatera status
                    break;
                case "4":
                    job.RemoveJob(); // Ta bort ansökan
                    break;
                case "5":
                    Console.WriteLine("Programmet avslutas...");
                    break;
                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;
            }
        }
    }
}
//JobApplication ansökan = new JobApplication();

//string summary = ansökan.GetSummary();
//Console.WriteLine("Sammanfattning: " + summary);

// Anropa GetDaysSinceApplied
//int dagar = ansökan.GetDaysSinceApplied();
//Console.WriteLine("Antal dagar sedan ansökan: " + dagar);
