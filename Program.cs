namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //här skalpar jag objekt
            JobManager job = new JobManager();
            string val = "";
        
            while (val != "6")
            {
                Console.WriteLine("<< Välkommen till Job Application Tracker >>");
                Console.WriteLine("<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine("1. Lägg till ny ansökan");
                Console.WriteLine("2. Visa alla ansökningar");
                Console.WriteLine("3. Uppdatera status på en ansökan");
                Console.WriteLine("4. Ta bort en ansökan");
                Console.WriteLine("5. Avsluta programmet");
                Console.WriteLine("**************************************");
                Console.Write("Ditt val: ");

                val = Console.ReadLine();
                Console.Clear();

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
                        Console.WriteLine("Programmet avslutas...");
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
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
