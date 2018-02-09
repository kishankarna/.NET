using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace DVD_RENTAL.Models
{
    public class CustomerContext : DbContext
    {

        public DbSet<Customer>  GetEmployees{ get; set; }
        public DbSet<MembershipType> MembershipType { get; set; }

    }
}