using BLL.Models;
using BLL.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeService service;
        public EmployeeController(EmployeeService service)
        {
            this.service = service;
        }

        [HttpGet("All")]
        public IActionResult All()
        {
            var data = service.Get();

            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult All(int id)
        {
            var data = service.Get(id);
            if (data == null)
            {
                return NotFound("Restaurant not found");
            }
            return Ok(data);
        }

        [HttpPost("create")]
        public IActionResult Create(EmployeeModel m)
        {
            var data = service.Create(m);

            return Ok(data);
        }

        [HttpPut("update")]
        public IActionResult Update(EmployeeModel m)
        {

            var data = service.Update(m);
            return Ok(data);

        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {

            var data = service.Delete(id);
            return Ok(data);


        }

        [HttpGet("search/{name}")]
        public IActionResult Search(string name)
        {
            var data = service.Search(name);

            return Ok(data);
        }

    }
}
