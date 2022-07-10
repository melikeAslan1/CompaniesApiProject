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

        public async Task Add(Department entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var department = await _context.Departments.FirstOrDefaultAsync(p => p.Id == id);
            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Department>> GetDetail()
        {
            var departments = await _context.Departments.ToListAsync();
            return departments;
        }

        public async Task<bool> IsExists(int id)
        {
            return await _context.Departments.AnyAsync(p => p.Id == id); //var mı yok mu kontrol eder.
        }

        public async Task Update(Department entity)
        {
            _context.Departments.Update(entity);
            await _context.SaveChangesAsync();
        }

        
    }
}
