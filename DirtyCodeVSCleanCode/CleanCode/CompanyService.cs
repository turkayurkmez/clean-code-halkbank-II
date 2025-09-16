namespace CleanCode
{
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
