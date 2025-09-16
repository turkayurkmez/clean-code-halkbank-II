using CleanCode.Models;

namespace CleanCode.Application
{
    public class CompanyService : ICompanyService
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
