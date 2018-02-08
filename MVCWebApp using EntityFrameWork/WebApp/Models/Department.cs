using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;  //for table mapping
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    [Table("tblDepartment")]  //table mapping
    public class Department
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        //here department can have number of employees that is why we add below new property
        public List<Employee> Employees { get; set; }
    }
}