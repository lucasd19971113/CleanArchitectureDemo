using Domain.Core.Commands;

namespace Domain.Commands
{
    public abstract class CourseCommand : Command
    {
       public string Name { get; protected set; } 
       public string Description { get; protected set; }
       public string ImageUrl { get; protected set; }
    }
}