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
        private IDepartmentRepository _deparmentRepository;

        public DepartmentManager(IDepartmentRepository deparmentRepository)
        {
            _deparmentRepository = deparmentRepository;
        }
        public Task<IList<Department>> GetDetail()
        {
            return _deparmentRepository.GetDetail();
        }
    }
}
