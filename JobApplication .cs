namespace ConsoleApp1
{
    public class JobApplication
    {
        public string CompanyName { get; set; }
        public string PositionTitle { get; set; }
        public string Status { get; set; } //(Applied, Interview, Offer, Rejected)
        public DateTime ApplicationDate { get; set; }//| DateTime - Datum när ansökan skickades
        public DateTime ResponseDate { get; set; }
        public int SalaryExpectation { get; set; }


        public JobApplication(string companyName, string position, DateTime date, string status)
        {
            CompanyName = companyName;
            PositionTitle = position;
            ApplicationDate = date;
            Status = status;
        }

        //Här ska vi skapa en metod som lägger till en ansökan
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
