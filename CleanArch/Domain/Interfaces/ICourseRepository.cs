using System.Collections.Generic;
using System.Linq;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface ICourseRepository
    {
         IQueryable<Course> GetCourses();
         void Add(Course course);
    }
}