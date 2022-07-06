﻿using Companies_EL.Concrete;
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
    }
}
