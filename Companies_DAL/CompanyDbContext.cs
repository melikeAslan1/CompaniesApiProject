using Companies_EL.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies_DAL
{
    public class CompanyDbContext:DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options)
           : base(options)
        {




        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Company> Companies { get; set; }

        public DbSet<CompanyDepartment> CompanyDepartments { get; set; }
    }
}
