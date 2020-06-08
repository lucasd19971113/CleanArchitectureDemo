using Application.ViewModels;
using AutoMapper;
using Domain.Commands;
using Domain.Models;

namespace Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Course, CourseViewModel>();
        }
    }
}