using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace WebMenagement_2.Utilities.Mapping
{
	public class MappingProfile :Profile
	{
        public MappingProfile()
        {
            CreateMap<Project, ProjectDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>();
            CreateMap<ProjectDtoForCreation, Project>();
        }
    }
}
