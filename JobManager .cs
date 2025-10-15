namespace ConsoleApp1
{
    public class JobManager
    {
        //Applications | List<JobApplication> - Samling av alla ansökningar
        public List<JobApplication> Applications = new List<JobApplication>();
        //AddApplication | void - Metod för att lägga till en ansökan
        public void application(JobApplication application)
        {
            Applications.Add(application);
        }
    }
}
