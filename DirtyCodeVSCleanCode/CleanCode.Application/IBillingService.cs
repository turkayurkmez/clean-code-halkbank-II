using CleanCode.Models;

namespace CleanCode.Application
{
    public interface IBillingService
    {
        double CalculateBill(List<TimeSheetEntry> timeSheetEntries, Company company);
        void SimulateEmail(List<TimeSheetEntry> timeSheetEntries, Company company);
    }
}