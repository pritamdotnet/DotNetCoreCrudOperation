using crud.Interface;
using crud.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartment _department;

        public DepartmentController(IDepartment department)
        {
            _department = department ??
                throw new ArgumentNullException(nameof(department));

        }

        [HttpGet]
        [Route("GetDepartment")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _department.GetDepartments());
        }

        [HttpPost]
        [Route("AddDepartment")]
        public async Task<IActionResult> Add([FromBody] Department department)
        {
            if (department == null)
            {
                return BadRequest("Department cannot be null");
            }

            await _department.AddDepartment(department);
            return CreatedAtAction(nameof(Get), new { id = department.DepartmentId }, department); // Assuming Id is the primary key
        }



    }
}
