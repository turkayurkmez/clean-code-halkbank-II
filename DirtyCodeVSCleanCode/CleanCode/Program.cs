using CleanCode.Application;
using CleanCode.Application.Settings;
using CleanCode.Models;
using System.Data.SqlTypes;

namespace CleanCode
{
    class Program
    {

        static void Main(string[] args)
        {
            IBillingService billingService = new BillingService();
            IPayrollService payrollService = new PayrollService();  
            ICompanyService companyService = new CompanyService();
            PayrollSettings payrollSettings = new PayrollSettings();

            var application = new TimeSheetApplication(billingService, 
                                                       payrollService, 
                                                       companyService, 
                                                       payrollSettings);

            application.Run();
           
        }

      

      

      

       
    }
}
