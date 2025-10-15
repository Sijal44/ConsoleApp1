namespace ConsoleApp1
{
    public class JobApplication
    {
        public string CompanyName { get; set; }
        public string PositionTitle { get; set; }
        //Status | enum - (Applied, Interview, Offer, Rejected)
        public string Status { get; set; }
        //ApplicationDate | DateTime - Datum när ansökan skickades
        public DateTime ApplicationDate { get; set; }


        public void AddJob()
        {
            Console.WriteLine("Företagsnamn: ");
            CompanyName = Console.ReadLine();
            Console.WriteLine("Tjänst: ");
            PositionTitle = Console.ReadLine();
            ApplicationDate = DateTime.Now;
            Console.WriteLine("Status (Applied, Interview, Offer, Rejected): ");
            Status = Console.ReadLine();
        }
    }
}
