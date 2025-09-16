using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public class BillingService
    {
        public void SimulateEmail(List<TimeSheetEntry> timeSheetEntries, Company company)
        {

            Console.WriteLine($"Simulating Sending email to {company.Name}");
            var bill = CalculateBill(timeSheetEntries, company);
            Console.WriteLine("Your bill is $" + bill + " for the hours worked.");


        }

        public double CalculateBill(List<TimeSheetEntry> timeSheetEntries, Company company)
        {
            var totalHours = timeSheetEntries
                             .Where(t => containsCompanyName(t, company))
                             .Sum(t => t.HoursWorked);

            return totalHours * company.HourlyRate;
        }

        private bool containsCompanyName(TimeSheetEntry t, Company company)
        {
            return t.WorkDone.Contains(company.Name.ToLower());
        }
    }
}
