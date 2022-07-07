using Companies_BLL.Abstract;
using Companies_DAL.Repository.Abstract;
using Companies_EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies_BLL.Concrete
{
    public class CompanyDepartmentManager : ICompanyDepartmentService
    {
        private ICompanyDepartmentRepository _companyDepartmentRepository;
        public CompanyDepartmentManager(ICompanyDepartmentRepository companyDepartmentRepository)
        {
            _companyDepartmentRepository= companyDepartmentRepository;
        }
        public async Task Add(CompanyDepartment entity)
        {
            await _companyDepartmentRepository.Add(entity);
        }

        public Task<IList<CompanyDepartment>> GetDetail()
        {
            return _companyDepartmentRepository.GetDetail();
        }

    }
}
