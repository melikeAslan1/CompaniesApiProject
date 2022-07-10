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
    public class CompanyRepository : ICompanyRepository
    {
        private CompanyDbContext _context;

        public CompanyRepository(CompanyDbContext context)
        {
            _context = context;
        }

        public async Task Add(Company entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var company = await _context.Companies.FirstOrDefaultAsync(p => p.Id == id);
            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Company>> GetDetail()
        {
            var companies = await _context.Companies.ToListAsync();
            return companies;
        }

        public async Task<bool> IsExists(int id)
        {
            return await _context.Companies.AnyAsync(p => p.Id == id);
        }

        public async Task Update(Company entity)
        {
            _context.Companies.Update(entity);
            await _context.SaveChangesAsync();
        }

      
    }
}
