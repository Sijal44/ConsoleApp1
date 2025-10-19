namespace ConsoleApp1
{
    public class JobManager
    {
        // Lista som innehåller alla ansökningar
        List<JobApplication> Applications = new List<JobApplication>();

        // Lägg till ny ansökan
        public void AddJob()
        {
            JobApplication ansökan = new JobApplication(); // Skapa nytt objekt

            Console.Write("Företagsnamn: ");
            ansökan.CompanyName = Console.ReadLine();

            Console.Write("Tjänst: ");
            ansökan.PositionTitle = Console.ReadLine();

            Console.Write("Status (Applied, Interview, Offer, Rejected): ");

            Applications.Add(ansökan); // Lägg till i listan
            Console.WriteLine("Ansökan tillagd!\n");
        }

        // Uppdatera status på befintlig ansökan
        public void UpdateStatus()
        {
            Console.Write("Ange företagsnamn att uppdatera: ");
            string namn = Console.ReadLine();

            var ansökan = Applications.FirstOrDefault(a => a.CompanyName == namn); // LINQ söker

            if (ansökan == null)
            {
                Console.WriteLine("Ingen ansökan hittades.");
                return;
            }

            Console.Write("Ny status (Applied, Interview, Offer, Rejected): ");
            string nyStatus = Console.ReadLine();

            ansökan.Status = nyStatus; // Uppdaterar status
            Console.WriteLine("Status har uppdaterats!");
        }

        // Visa alla ansökningar
        public void ShowAll()
        {
            if (Applications.Count == 0) // Kolla om listan är tom
            {
                Console.WriteLine("Inga ansökningar finns ännu.");
                return;
            }

            foreach (var ansökan in Applications)
            {
                Console.WriteLine($"{ansökan.CompanyName} - {ansökan.PositionTitle} - {ansökan.Status}");
            }
        }

        // Ta bort en ansökan
        public void RemoveJob()
        {
            Console.Write("Ange företagsnamn att ta bort: ");
            string namn = Console.ReadLine();

            var ansökan = Applications.FirstOrDefault(a => a.CompanyName == namn); // LINQ söker

            if (ansökan != null)
            {
                Applications.Remove(ansökan); // Tar bort ansökan
                Console.WriteLine("Ansökan borttagen!");
            }
            else
            {
                Console.WriteLine("Ingen ansökan hittades.");
            }
        }
    }
}
