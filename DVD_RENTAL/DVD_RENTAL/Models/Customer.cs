using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DVD_RENTAL.Models
{
    [Table("Customer")]
    public partial class Customer
    {

        public int ID { get; set; }

        public string Name { get; set; }
        [Display(Name= "Membership Type") ]
        public int MemberShipID { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime DateJoined { get; set; }



    }
}