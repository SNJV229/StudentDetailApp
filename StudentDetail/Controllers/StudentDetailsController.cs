using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentDetail.Models;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace StudentDetail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentDetailsController : ControllerBase
    {
        private readonly StudentContext _studentContext;

        public StudentDetailsController(StudentContext studentContext)
        {
            _studentContext = studentContext;

            if (_studentContext.Students.Count() == 0)
            {
                _studentContext.Students.Add(new StudentModel
                {
                    StudentName = "Sanjeev",
                    StudentClass = "5",
                    StudentRollNumber = 21
                });

                _studentContext.Students.Add(new StudentModel
                {
                    StudentName = "Ravi",
                    StudentClass = "4",
                    StudentRollNumber = 25
                });

                _studentContext.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable GetAll()
        {
            return _studentContext.Students.ToList();
        }

        [HttpPost]
        public IActionResult Create([FromBody] StudentModel item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            _studentContext.Students.Add(item);
            _studentContext.SaveChanges();

            //CreatedAtRoute returns URL to the newly created resource when we invoke the POST method.
            return CreatedAtRoute("GetById", new { id = item.StudentName }, item);
        }
    }
}
