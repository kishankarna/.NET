using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BusinessLayer
{
    public partial class Employee    //creating partial class
    {   //This are the properties of Employee
        
        public int ID { get; set; }
        [Required ]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int Department_ID { get; set; }
    }

    [MetadataType(typeof(MetaDatakarna ) ) ]  //adding propety change to partial class
    public partial class Employee
    {

    }

    public class MetaDatakarna          //making custom property
    {
        [Display(Name = "Employees Name")]
        public string Name { get; set; }
    }



}
