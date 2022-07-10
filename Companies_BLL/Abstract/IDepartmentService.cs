using Companies_EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies_BLL.Abstract
{
    public interface IDepartmentService
    {
        Task<IList<Department>> GetDetail();
        Task Delete(int id);

        Task Add(Department entity);

        Task Update(Department entity);

        Task<bool> IsDepartmentExists(int id);
    }
}
