﻿using Companies_EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies_BLL.Abstract
{
    public interface ICompanyDepartmentService
    {
        Task<IList<CompanyDepartment>> GetDetail();

        Task Add(CompanyDepartment entity);
    }
}
