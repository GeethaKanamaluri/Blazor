using DataModels;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }

        public DbSet<Emplyeee> Emplyeee { get; set; }
        public DbSet<Department> departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Department>().HasData(new Department { departmentId = 1, departmentName = "IT" });
            //modelBuilder.Entity<Department>().HasData(new Department { departmentId = 2, departmentName = "HR" });
            //modelBuilder.Entity<Department>().HasData(new Department { departmentId = 3, departmentName = "Payroll" });
            //modelBuilder.Entity<Department>().HasData(new Department { departmentId = 4, departmentName = "Admin" });

            modelBuilder.Entity<Emplyeee>().HasKey(p => p.EmployeeId);
            //modelBuilder.Entity<Emplyeee>().HasData(new Emplyeee
            //{

            //    EmployeeId = 1,
            //    FirstName = "Test",
            //    LastName = "TestL",
            //    Email = "test@gmail.com",
            //    DateOfBirth = DateTime.Now,
            //    gender = Gender.Male,
            //    DepartmentId = 1,
            //    PhotoPath = "images/john.png"

            //});

            //modelBuilder.Entity<Emplyeee>().HasData(new Emplyeee
            //{

            //    EmployeeId = 2,
            //    FirstName = "Test2",
            //    LastName = "TestL2",
            //    Email = "test2@gmail.com",
            //    DateOfBirth = DateTime.Now,
            //    gender = Gender.Male,
            //    DepartmentId = 2,
            //    PhotoPath = "images/john2.png"

            //});

            //modelBuilder.Entity<Emplyeee>().HasData(new Emplyeee
            //{

            //    EmployeeId = 3,
            //    FirstName = "Test3",
            //    LastName = "TestL3",
            //    Email = "test3@gmail.com",
            //    DateOfBirth = DateTime.Now,
            //    gender = Gender.Male,
            //    DepartmentId = 3,
            //    PhotoPath = "images/john3.png"

            //});

            //modelBuilder.Entity<Emplyeee>().HasData(new Emplyeee
            //{

            //    EmployeeId = 4,
            //    FirstName = "Test4",
            //    LastName = "TestL4",
            //    Email = "test4@gmail.com",
            //    DateOfBirth = DateTime.Now,
            //    gender = Gender.Male,
            //    DepartmentId = 4,
            //    PhotoPath = "images/john4.png"

            //});
        }
    }
}