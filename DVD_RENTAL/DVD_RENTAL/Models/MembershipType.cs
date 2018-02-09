using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace DVD_RENTAL.Models
{
    [Table("MembershipType")]
    public class MembershipType
    {

        public int ID { get; set; }
        public string MemberShipType { get; set; }
    }
}