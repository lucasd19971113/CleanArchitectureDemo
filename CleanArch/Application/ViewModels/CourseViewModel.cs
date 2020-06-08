using System.Collections.Generic;
using Domain.Models;

namespace Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}