namespace ConsoleApp1
{
    public class JobManager
    {
        //skapa en lista som innehålla av alla ansökningar
        List<JobApplication> Applications = new List<JobApplication>();

        //Här ska vi skapa en metod som lägger till en ansökan
        public void AddJob()
        {
            //  Skapa ett nytt objekt 
            JobApplication ansökan = new JobApplication();

            // 2️ Fyll i företagsnamn
            Console.Write("Företagsnamn: ");
            ansökan.CompanyName = Console.ReadLine();

            // 3️ Fyll i tjänst/titel
            Console.Write("Tjänst: ");
            ansökan.PositionTitle = Console.ReadLine();

            // 5️ Fyll i status
            Console.Write("Status (Applied, Interview, Offer, Rejected): ");
            ansökan.Status = Console.ReadLine();


            //stoppar objektet i listan.
            Applications.Add(ansökan);
            // Feedback till användaren
            Console.WriteLine("Ansökan tillagd!\n");
            }

        //ändra status på befintlig ansökan
        public void UpdateStatus()
        {
            Console.Write("Ange företagsnamn att uppdatera: ");
            string namn = Console.ReadLine();

            var ansökan = Applications.FirstOrDefault(a => a.CompanyName == namn);

            if (ansökan == null)//kolla om ett objekt finns
            {
                Console.WriteLine("Ingen ansökan hittades med det företaget.");
                return;
            }

            Console.Write("Ny status (Applied, Interview, Offer, Rejected): ");
            string nyStatus = Console.ReadLine();

            ansökan.Status = nyStatus;
            Console.WriteLine("Status har uppdaterats!");
            }
        public void ShowAll()
        {
            ////Om listan är tom → visar bara ett kort meddeland
            if (Applications.Count == 0)//kollar om listan är tom
            {
                Console.WriteLine("Inga ansökningar finns ännu.");
                return;
            }

            foreach (var ansökan in Applications)
            {
                Console.WriteLine($"{ansökan.CompanyName} - {ansökan.PositionTitle} - {ansökan.Status}");
            }
        }
        public void RemoveJob()
        {
                Console.Write("Ange företagsnamn att ta bort: ");
                string namn = Console.ReadLine();

               // Hitta ansökan med samma namn
               var ansökan = Applications.FirstOrDefault(a => a.CompanyName == namn);

           if (ansökan != null)//Kolla om vi hittade något
            {
                Applications.Remove(ansökan);
                Console.WriteLine("Ansökan borttagen!");
           }
           else
           {
                Console.WriteLine("Ingen ansökan hittades.");
           }
        }
    }
}

