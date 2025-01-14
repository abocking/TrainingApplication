using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrainingApplication.CourseService.Services;

namespace TrainingApplication.CourseService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCourses()
        {
            var courses = await _courseService.GetCoursesAsync();
            return Ok(courses);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse(Course course)
        {
            var createdCourse = await _courseService.CreateCourseAsync(course);
            return CreatedAtAction(nameof(GetCourses), new { id = createdCourse.Id }, createdCourse);
        }
        
        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok("API is working");
        }
    }
}