using System.Collections.Generic;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface ICourseRepository
    {
         IEnumerable<Course> GetCourses();
    }
}