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
    public class CompanyDepartmentRepository : ICompanyDepartmentRepository
    {
        private CompanyDbContext _context;

        public CompanyDepartmentRepository(CompanyDbContext context)
        {
            _context = context;
        }
        public async Task Add(CompanyDepartment entity)
        {

            await _context.CompanyDepartments.AddAsync(entity);
            await _context.SaveChangesAsync();

            //await _context.AddAsync(entity);
            //await _context.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<CompanyDepartment>> GetDetail()
        {
            var companyDepartments = await _context.CompanyDepartments.ToListAsync();
            //CompanyDepartment cd = new CompanyDepartment();
            //cd.CompanyId=companyDepartments.


            return companyDepartments;
        }

        public Task<bool> IsExists(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(CompanyDepartment entity)
        {
            throw new NotImplementedException();
        }
    }
}
