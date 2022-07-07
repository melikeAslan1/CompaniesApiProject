using Companies_EL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies_DAL.Repository.Abstract
{
   public interface IRepository<T> where T : IEntity, new()
    {
        Task<IList<T>> GetDetail();

        Task Add(T entity);

        Task Update(T entity);

        Task Delete(int id);



    }
}
