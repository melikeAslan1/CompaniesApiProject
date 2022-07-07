﻿using Companies_DAL.Repository.Abstract;
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

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Department>> GetDetail()
        {
            var departments = await _context.Departments.ToListAsync();
            return departments;
        }

        public Task Update(Department entity)
        {
            throw new NotImplementedException();
        }
    }
}
