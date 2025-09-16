using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public class PayrollService
    {
        public double CalculatePayment(List<TimeSheetEntry> timeSheetEntries, PayrollSettings payrollSettings)
        {

            double totalHoursForWork = timeSheetEntries.Sum(p => p.HoursWorked);
            if (totalHoursForWork > payrollSettings.StandardWorkHoursPerWeek)
            {
                var overTimeHours = totalHoursForWork - payrollSettings.StandardWorkHoursPerWeek;
                var overTimePay = overTimeHours * payrollSettings.OvertimeHourlyRate;
                var standardPay = payrollSettings.StandardHourlyRate *
                                  payrollSettings.StandardWorkHoursPerWeek;

                return overTimePay + standardPay;
                //Console.WriteLine("You will get paid $" + (overTimePay + standardPay) + " for your work.");
            }

            return totalHoursForWork * payrollSettings.StandardHourlyRate;

        }
    }
}
