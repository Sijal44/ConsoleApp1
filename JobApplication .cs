namespace ConsoleApp1
{
    public class JobApplication
    {
        public string CompanyName;
        public string PositionTitle;
        public string Status ; //(Applied, Interview, Offer, Rejected)
        public DateTime ApplicationDate; //| DateTime - Datum när ansökan skickades
        public DateTime ResponseDate;
        public int SalaryExpectation;
        
        
       //// public int GetDaysSinceApplied()
       // {
       //     TimeSpan difference = DateTime.Now - ApplicationDate;
       //     return difference.Days;
       // }
       // public string GetSummary()
       // {
       //     return $"{CompanyName} - {PositionTitle} ({Status})";
       // }...
    }
}