using DataModels;
 
namespace SSRBlazor.Services
{
    public class EmployeeService : IEmployeeServices
    {
        private readonly HttpClient _httpClient; 
        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Emplyeee>> GetEmployees()
        {
            return await _httpClient.GetFromJsonAsync<Emplyeee[]>("api/Employees");
        }
    }
}
