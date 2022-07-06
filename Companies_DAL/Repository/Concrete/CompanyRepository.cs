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

        public Task Add(Company entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Company>> GetDetail()
        {
            var companies = await _context.Companies.ToListAsync();
            return companies;
        }
    }
}
