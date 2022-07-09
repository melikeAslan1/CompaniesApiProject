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
    public class DepartmentManager : IDepartmentService
    {
        private IDepartmentRepository _departmentRepository;

        public DepartmentManager(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task Add(Department entity)
        {
            await _departmentRepository.Add(entity);
        }

        public async Task Delete(int id)
        {
            await _departmentRepository.Delete(id);
        }

        public Task<IList<Department>> GetDetail()
        {
            return _departmentRepository.GetDetail();
        }
    }
}
