using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrainingApplication.CourseService.Data
{
    public class CourseRepository : ICourseRepository
    {
        private readonly CourseContext _context;
        
        public CourseRepository(CourseContext context)
        {
            _context = context;
        }
        
        public async Task<List<Course>> GetCoursesAsync()
        {
            return await _context.Courses.ToListAsync();
        }
        
        public async Task<Course> CreateCourseAsync(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            return course;
            
        }
    }
}