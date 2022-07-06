using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies_EL.Abstract
{
    public interface IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
