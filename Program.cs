namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Lägg till ny ansökan
            Applications ansökan = new Applications();
            string Applications = "";
            job.Applications = Applications;


            while (Applications != "7")
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

                
                Applications = Console.ReadLine();

                switch (Applications)
                {
                    case "1":
                        Console.WriteLine("Företagsnamn:");
                        break;
                    case "2":
                        Console.WriteLine("Visa alla ansökningar:");
                        break;
                    case "3":
                        Console.WriteLine("Visa statistik:");
                        break;
                    case "4":
                        Console.WriteLine("Uppdatera status på en ansökan:");
                        break;
                    case "5":
                        Console.WriteLine("Ta bort en ansökan:");
                        break;
                    case "6":
                        Console.WriteLine("Avsluta programmet:");
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
                foreach (var item in Applications)
                {
                    Console.WriteLine(item);
                }
                ansökan.AddJob();

            }
        }
    }
}
