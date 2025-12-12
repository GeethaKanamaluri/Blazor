using DataModels;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _AppDbContext;
        public EmployeeRepository(AppDbContext AppDbContext)
        {
            this._AppDbContext = AppDbContext;
        }
        public async Task<Emplyeee> AddEmployee(Emplyeee employee)
        {
            var result = await _AppDbContext.Emplyeee.AddAsync(employee);
            await _AppDbContext.SaveChangesAsync();
            return result.Entity;

        }

        public async void DeleteEmployee(int employeeId)
        {
            var result = await _AppDbContext.Emplyeee
                .FirstOrDefaultAsync(e=>e.EmployeeId == employeeId);
            if(result != null) { 
                _AppDbContext.Emplyeee.Remove(result);
                await _AppDbContext.SaveChangesAsync();
            }            
        }

        public async Task<Emplyeee> GetEmployee(int employeeId)
        {
            return await _AppDbContext.Emplyeee.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
        }

        public async Task<IEnumerable<Emplyeee>> GetEmployeees()
        {
            return await _AppDbContext.Emplyeee.ToListAsync();
        }

        public async Task<Emplyeee?> updateEmployee(Emplyeee employee)
        {
            var results = await _AppDbContext.Emplyeee.FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);
            if(results != null)
            {
                results.FirstName = employee.FirstName;
                results.LastName = employee.LastName;
                results.Email = employee.Email;
                results.PhotoPath = employee.PhotoPath;
                //results.DepartmentId = employee.DepartmentId;
                await _AppDbContext.SaveChangesAsync();
                return results;
            }
            return null;
        }
    }
}
