using DataModels;

namespace WebAPI.Models
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Emplyeee>> GetEmployeees();
        Task<Emplyeee> GetEmployee(int EmployeeId);
        Task<Emplyeee> AddEmployee(Emplyeee employee);
        Task<Emplyeee> updateEmployee(Emplyeee employee);
        void DeleteEmployee(int employeeId);
    }
}
