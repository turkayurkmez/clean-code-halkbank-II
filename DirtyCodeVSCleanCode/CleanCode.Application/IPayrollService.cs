using CleanCode.Application.Settings;
using CleanCode.Models;

namespace CleanCode.Application
{
    public interface IPayrollService
    {
        double CalculatePayment(List<TimeSheetEntry> timeSheetEntries, PayrollSettings payrollSettings);
    }
}