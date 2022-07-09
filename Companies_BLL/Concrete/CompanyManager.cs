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
    public class CompanyManager : ICompanyService
    {
        private ICompanyRepository _companyRepository;

        public CompanyManager(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task Add(Company entity)
        {
            await _companyRepository.Add(entity);
           
        }

        public async Task Delete(int id)
        {
           await _companyRepository.Delete(id);
        }

        public Task<IList<Company>> GetDetail()
        {
            return _companyRepository.GetDetail();
        }

        public Task Update(Company entity)
        {
            throw new NotImplementedException();
        }
    }
}
