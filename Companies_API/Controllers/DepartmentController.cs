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
    public class DepartmentController : ControllerBase
    {
        private IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetDetail()
        {
            var departments = await _departmentService.GetDetail();

            return Ok(departments);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException("id değeri negatif olamaz!");

            }
            await _departmentService.Delete(id);
            return Ok();
        }

        [HttpPost] 
        public async Task<IActionResult> Add([FromBody]Department department)
        {

            await _departmentService.Add(department);
            return CreatedAtAction("Add", new { id = department.Id }, department);

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Department department)
        {
            if (await _departmentService.IsDepartmentExists(id))
            {
                if (ModelState.IsValid)
                {
                    await _departmentService.Update(department);
                    return Ok();
                }
                return BadRequest(ModelState);
            }
            return NotFound(new { message = $"{id} id'li ürün bulunamadı" });
        }

    }
}
