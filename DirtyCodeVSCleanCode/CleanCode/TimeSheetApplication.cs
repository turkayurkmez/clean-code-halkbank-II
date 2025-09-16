using CleanCode.Application;
using CleanCode.Application.Settings;
using CleanCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    internal class TimeSheetApplication
    {

        private readonly IBillingService _billingService;
        private readonly IPayrollService _payrollService;
        private readonly ICompanyService _companyService;
        private readonly PayrollSettings _payrollSettings;

        public TimeSheetApplication(IBillingService billingService,
                                    IPayrollService payrollService,
                                    ICompanyService companyService,
                                    PayrollSettings payrollSettings)
        {

            _billingService = billingService;
            _payrollService = payrollService;
            _companyService = companyService;
            _payrollSettings = payrollSettings;

                
        }

        public void Run()
        {
            var timeSheetEntries = GetTimeSheetEntriesFromUser();
            var companies = _companyService.GetCompanies();

            companies.ForEach(company =>
            {
                _billingService.SimulateEmail(timeSheetEntries, company);
            });

            var payment = _payrollService.CalculatePayment(timeSheetEntries, _payrollSettings);
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
