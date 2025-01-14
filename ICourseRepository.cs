using System.Collections.Generic;
using System.Threading.Tasks;

namespace TrainingApplication.CourseService.Data
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetCoursesAsync();
        Task<Course> CreateCourseAsync(Course course);
    }
}