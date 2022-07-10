using Companies_EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies_BLL.Abstract
{
    public interface ICompanyService
    {

        Task<IList<Company>> GetDetail();

        Task Add(Company entity);

        Task Update(Company entity);

        Task Delete(int id);

        Task<bool> IsCompanyExists(int id);
    }
}
