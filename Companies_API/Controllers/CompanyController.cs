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
    public class CompanyController : ControllerBase
    {
        private ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public async Task<IActionResult> GetDetail()
        {
            var companies = await _companyService.GetDetail();

            return Ok(companies);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException("id değeri negatif olamaz!");

            }
            await _companyService.Delete(id);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Company company)
        {
            await _companyService.Add(company);
            return CreatedAtAction("Add", new { id = company.Id }, company);
        }
    }
}
