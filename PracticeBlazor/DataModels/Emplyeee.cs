using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Emplyeee
    {
       
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; } = default(string);
        public string? LastName { get; set; } = default(string);
        //public DateTime DateOfBirth;
        public string? Email { get; set; } = default(string);
        //public Gender gender { get; set; }
        //public int DepartmentId { get; set; }
        public string? PhotoPath { get; set; } = default(string);
    }
}
