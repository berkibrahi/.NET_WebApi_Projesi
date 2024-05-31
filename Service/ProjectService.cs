using AutoMapper;
using Contracts;
using Entities.Exceptionn;
using Entities.Models;
using ServiceContracts;
using Shared.DataTransferObjects;

namespace Service
{
	public class ProjectService : IProjectService
	{
		private readonly IRepositorMenager _repository;
		private readonly ILoggerMenager _logger;
		private readonly IMapper _mapper;

		public ProjectService(IRepositorMenager repository, ILoggerMenager logger,IMapper mapper)
		{
			_repository = repository;
			_logger = logger;
			_mapper = mapper;
		}

		public IEnumerable<ProjectDto> GetAllProject(bool trackChanges)
		{
			
				var projects = _repository.Project.GetAllProjects(trackChanges);
				var projectDtos = _mapper.Map<IEnumerable<ProjectDto>>(projects);
				return projectDtos;
			
			
		}

		public ProjectDto GetOneProjectById(Guid id, bool trackChanges)
		{
			
				var project= _repository.Project.GetOneProjectById(id, trackChanges);
			if (project == null)
				throw new ProjectNotFoundExceptions(id);
				var projectDto = _mapper.Map<ProjectDto>(project);
				return projectDto;
			
		}
	}
}
