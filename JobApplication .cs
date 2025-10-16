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
        
        
        public int GetDaysSinceApplied()
        {
            TimeSpan difference = DateTime.Now - ApplicationDate;
            return difference.Days;
        }
        public string GetSummary()
        {
            return $"{CompanyName} - {PositionTitle} ({Status})";
        }
    }
}