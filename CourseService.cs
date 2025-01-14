using System.Collections.Generic;
using System.Threading.Tasks;
using TrainingApplication.CourseService.Data;

namespace TrainingApplication.CourseService.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        
        public async Task<List<Course>> GetCoursesAsync()
        {
            return await _courseRepository.GetCoursesAsync();
        }
        
        public async Task<Course> CreateCourseAsync(Course course)
        {
            return await _courseRepository.CreateCourseAsync(course);
        }
    }
}