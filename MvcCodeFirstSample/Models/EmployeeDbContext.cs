using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcCodeFirstSample.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("EmployeeDbContext")
        {

        }
        public DbSet<Employee> employee { get; set; }

        
    }
}