namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Lägg till ny ansökan
            string Applications = "";
            var job = new JobApplication("IKEA", "Säljare", DateTime.Now, "Ansökt");

            while (Applications != "7")
            {
                Console.WriteLine("<<Välkomen till arbetsförmedlingen>>");
                Console.WriteLine("<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine("1.Lägg till ny ansökan:");
                Console.WriteLine("2.Visa alla ansökningar:");
                Console.WriteLine("3.Visa statistik:");
                Console.WriteLine("4.Uppdatera status på en ansökan:");
                Console.WriteLine("5.Ta bort en ansökan:");
                Console.WriteLine("6.Avsluta programmet:");
                Console.WriteLine("***********************************");
                Console.ReadKey();

                Applications = Console.ReadLine();
                Console.Clear();

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
                job.AddJob();

            }
        }
    }
}
