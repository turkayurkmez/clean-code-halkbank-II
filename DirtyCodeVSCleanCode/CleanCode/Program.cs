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

            companies.ForEach(company =>
            {
                simulateEmail(timeSheetEntries, company);
            });


            var payment = calculatePayment(timeSheetEntries, 40, 15, 10);

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

        private static void simulateEmail(List<TimeSheetEntry> timeSheetEntries, Company company)
        {

            Console.WriteLine($"Simulating Sending email to {company.Name}");
            var bill = calculateBill(timeSheetEntries, company);
            Console.WriteLine("Your bill is $" + bill + " for the hours worked.");


        }

        private static double calculateBill(List<TimeSheetEntry> timeSheetEntries, Company company)
        {
            var totalHours = timeSheetEntries
                              .Where(t => containsCompanyName(t, company))
                              .Sum(t => t.HoursWorked);

            return totalHours * company.HourlyRate;
        }

        private static bool containsCompanyName(TimeSheetEntry timeSheetEntry, Company company)
        {
            return timeSheetEntry.WorkDone.Contains(company.Name.ToLower());
        }

        private static double calculatePayment(List<TimeSheetEntry> timeSheetEntries, int standardWorkHoursPerWeek, double overTimeHourlyRate, double standardHourlyRate)
        {

            double totalHoursForWork = timeSheetEntries.Sum(p => p.HoursWorked);
            if (totalHoursForWork > standardWorkHoursPerWeek)
            {
                var overTimeHours = totalHoursForWork - standardWorkHoursPerWeek;
                var overTimePay = overTimeHours * overTimeHourlyRate;
                var standardPay = standardHourlyRate * standardWorkHoursPerWeek;

                return overTimePay + standardPay;
                //Console.WriteLine("You will get paid $" + (overTimePay + standardPay) + " for your work.");
            }

            return totalHoursForWork * standardHourlyRate;
       
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public double HoursWorked;
    }

    public class UserAnswers
    {
        public const string YES = "yes";
        public const string NO = "no";
    }

    public class Company
    {
        public string Name { get; set; }
        public double HourlyRate { get; set; }

    }

    public class CompanyService
    {
        public List<Company> GetCompanies()
        {
            return new List<Company>()
            {
                new Company{ Name ="Acme", HourlyRate = 150},
                new Company { Name="ABC", HourlyRate=125}
            };
        }
    }
}
