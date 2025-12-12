using DataModels;

namespace SSRBlazor.Services
{
    public interface IEmployeeServices
    {
        Task<IEnumerable<Emplyeee>> GetEmployees();


    }
}
