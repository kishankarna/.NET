using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("tblEmployee")]     //this is mapping with the database table
    public class Employee
    {
        [Key]//just incase if in database this field is no primary key
        //make sure dataype and field name are same as database table
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int Department_ID { get; set; }
    }
}