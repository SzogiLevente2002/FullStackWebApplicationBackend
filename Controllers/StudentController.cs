using FullStackWebApplicationBackend.Context;
using FullStackWebApplicationBackend.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FullStackWebApplicationBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class StudentController(SchoolDbContext context) : ControllerBase
    {
        [HttpGet]

        public async Task<ActionResult<IEnumerable<Student>>> GetAll()
        {
            var students = await context.Students.ToListAsync();

            return Ok(students);
        }

        [HttpPost]

        public async Task<ActionResult<Student>> Add([FromBody] Student student)
        {
            context.Students.Add(student);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAll),new {id = student.StudentId },student);
        }
    }
}
