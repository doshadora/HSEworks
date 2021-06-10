using practice2.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace practice2.Models
{
    public class UserContext : DbContext
    {
        public UserContext() :
            base("cswEntities")
        { }

        public DbSet<customer> Cust { get; set; }
        public DbSet<store> Store { get; set; }
    }
}