using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Week5Demo.Api.Models;
using Week5Demo.Domain;

namespace Week5Demo.Api.Controllers
{
    [Route("api/v1/students")]
    public class StudentController : ApiController
    {
        private readonly SchoolContext _dbContext;

        public StudentController()
        {
            _dbContext = new SchoolContext();
        }

        [HttpGet]
        public async Task<ICollection<StudentModel>> GetAllStudents()
        {
            var students = await _dbContext.Students.Select(x => new StudentModel
            {
                DateOfBirth = x.DateOfBirth,
                Height = x.Height,
                StudentId = x.StudentId,
                StudentName = x.StudentName,
                Weight = x.Weight
            }).ToListAsync();

            return students;
        }
    }
}
