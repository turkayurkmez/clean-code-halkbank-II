using System.Data.SqlTypes;

namespace CleanCode
{
    class Program
    {

        static void Main(string[] args)
        {

            var timeSheetEntries = GetTimeSheetEntriesFromUser();


            var companyService = new CompanyService();
            var companies = companyService.GetCompanies();

            var billingService = new  BillingService();
           
            var payrollService = new  PayrollService();

            companies.ForEach(company =>
            {
                billingService.SimulateEmail(timeSheetEntries, company);
            });

            var payRollSettings = new PayrollSettings();
            var payment = payrollService.CalculatePayment(timeSheetEntries, payRollSettings);

            Console.WriteLine("You will get paid $" + payment + " for your work.");          
         
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }

        private static List<TimeSheetEntry> GetTimeSheetEntriesFromUser()
        {

            /*
             * En az bir kere, kullanıcdan veri al. Kullanıcı "devam" derse tekrar al:
             * 
             */
            List<TimeSheetEntry> timeSheetEntries = new List<TimeSheetEntry>();
            string answer = string.Empty;
            do
            {
                Console.Write("Enter what you did: ");
                string workDescription = Console.ReadLine();
                double timeForWork = getTimeForWork();

                TimeSheetEntry timeSheetEntry = new TimeSheetEntry
                {
                    HoursWorked = timeForWork,
                    WorkDone = workDescription
                };
                timeSheetEntries.Add(timeSheetEntry);
                Console.Write("Do you want to enter more time (yes/no): ");

                answer = Console.ReadLine();
            }
            while (answer.ToLower() == UserAnswers.YES);



            return timeSheetEntries;
        }

        private static double getTimeForWork()
        {
            Console.Write("How long did you do it for: ");
            string rawTimeWorked = Console.ReadLine();
            double timeForWork;
            while (!double.TryParse(rawTimeWorked, out timeForWork))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid number given");
                Console.Write("How long did you do it for: ");
                rawTimeWorked = Console.ReadLine();
            }

            return timeForWork;
        }

      

      

       
    }
}
