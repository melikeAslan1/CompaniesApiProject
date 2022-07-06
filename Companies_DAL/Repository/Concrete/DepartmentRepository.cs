using Companies_DAL.Repository.Abstract;
using Companies_EL.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies_DAL.Repository.Concrete
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private CompanyDbContext _context;

        public DepartmentRepository(CompanyDbContext context)
        {
            _context = context;
        }

        public Task Add(Department entity)
        {
            _context.
        }

        public async Task<IList<Department>> GetDetail()
        {
            var departments = await _context.Departments.ToListAsync();
            return departments;
        }
       
    }
}
