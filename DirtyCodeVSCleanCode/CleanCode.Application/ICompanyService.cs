using CleanCode.Models;

namespace CleanCode.Application
{
    public interface ICompanyService
    {
        List<Company> GetCompanies();
    }
}