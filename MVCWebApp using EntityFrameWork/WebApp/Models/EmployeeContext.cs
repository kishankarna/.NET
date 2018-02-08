using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApp.Models
{
    // MVC follows naming convention, it will look for "EmployeeContext" connection name in web.config, 
    // bcoz we inherited this class with "DbContext" class and we know DbContext gives us access to database.
    public class EmployeeContext :DbContext
    {
        //making DbSet(table) from Department and Employee model
        public DbSet<Employee> GetEmployees { get; set; }
        public DbSet<Department> GetDepartment { get; set; }

    }
}