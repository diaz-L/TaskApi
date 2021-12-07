using AutoMapper;
using TaskApi.Data.Models;

namespace TaskApi.Data.Entities.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Task, TaskModel>()
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.TaskId));
                
            CreateMap<Task, TaskForCreationModel>();
            CreateMap<TaskForUpdateModel, Task>()
                .ReverseMap();
        }
    }
}