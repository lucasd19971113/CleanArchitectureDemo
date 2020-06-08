using System.Collections.Generic;
using System.Linq;
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

        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public IQueryable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}