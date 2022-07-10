using Companies_BLL.Abstract;
using Companies_EL.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companies_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyDepartmentController : ControllerBase
    {
        private ICompanyDepartmentService _companyDepartmentService;

        public CompanyDepartmentController(ICompanyDepartmentService companyDepartmentService)
        {
            _companyDepartmentService = companyDepartmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetDetail()
        {
            var companyDepartments = await _companyDepartmentService.GetDetail();

            return Ok(companyDepartments);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromQuery] int companyId, int departmentId, int? ustDepartmentId)
        {
            CompanyDepartment cd = new CompanyDepartment()
            {
                CompanyId = companyId,
                DepartmentId = departmentId,
                UstDepartmentId = ustDepartmentId
            };
          
            await _companyDepartmentService.Add(cd);
            return CreatedAtAction("Add", new { id = cd.Id }, cd);
        }

        
    }
}
