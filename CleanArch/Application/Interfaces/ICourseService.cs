using System.Collections.Generic;
using Application.ViewModels;

namespace Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
        void Create(CourseViewModel courseViewModel);
    }
}