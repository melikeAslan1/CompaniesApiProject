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


        //[HttpPost]        
        //public async Task<IActionResult> Add([FromBody]CompanyDepartment entity)
        //{
        //    //if (ModelState.IsValid)
        //    //{
        //    //    int CompanyDepartmentId = await _companyDepartmentService.Add(entity);

        //    //    //Url yönlendirmesi,eklendiği zaman detay olrak istemciye yeni url veriyoruz
        //    //    return CreatedAtAction(nameof(CompanyDepartmentId), routeValues: new { id = CompanyDepartmentId }, value: null);  //nameof Nesne,metot adı kullanıyorsanız hata yapmayı engeller
        //    //}
        //    //return BadRequest(ModelState);

        //    try
        //    {
               
        //        var result = _companyDepartmentService.Add(entity);
               
        //    }
        //    catch (Exception ex)
        //    {

        //        return Problem("Beklenmedik bir hata oluştu! " + ex.Message);
        //    }
            
        //}


    }
}
