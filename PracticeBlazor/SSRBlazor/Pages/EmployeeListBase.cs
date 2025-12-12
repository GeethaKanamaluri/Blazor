using DataModels;
using Microsoft.AspNetCore.Components;
using SSRBlazor.Services;

namespace SSRBlazor.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeServices employeeService { get; set; }
        public IEnumerable<Emplyeee>? Employee {  get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employee = (await employeeService.GetEmployees()).ToList();
            //await Task.Run(LoadEmployee);
        }
        private void LoadEmployee()
        {
            Emplyeee e1 = new Emplyeee
            {
                EmployeeId = 1,
                FirstName = "Test",
                LastName = "TestL",
                Email="test@gmail.com",
                ////DateOfBirth = DateTime.Now,
                //gender = Gender.Male,
                //DepartmentId = 2,
                PhotoPath = "images/john.png"
            };

            Employee = new List<Emplyeee> {  e1 };
        }
    }
}
