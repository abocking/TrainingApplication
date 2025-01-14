using System.Collections.Generic;
using System.Threading.Tasks;

namespace TrainingApplication.CourseService.Services
{
    public interface ICourseService
    {
        Task<List<Course>> GetCoursesAsync();
        Task<Course> CreateCourseAsync(Course course);
    }
}