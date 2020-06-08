using System.Collections.Generic;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data.Context;

namespace Infrastructure.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private AppDbContext _context;
        public CourseRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}