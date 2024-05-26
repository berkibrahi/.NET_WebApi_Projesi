using AutoMapper;
using Contracts;
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
			try
			{
				var projects = _repository.Project.GetAllProjects(trackChanges);
				var projectDtos = _mapper.Map<IEnumerable<ProjectDto>>(projects);
				return projectDtos;
			}
			catch (Exception ex)
			{
				_logger.LogError("getallproject oluştu" + ex.Message);
				throw;
			}
			
		}

		public ProjectDto GetOneProjectById(Guid id, bool trackChanges)
		{
			try
			{
				var project= _repository.Project.GetOneProjectById(id, trackChanges);
				var projectDto = _mapper.Map<ProjectDto>(project);
				return projectDto;
			}catch (Exception ex)
			{
				_logger.LogError("project repository get project hata" + ex.Message);
				throw;
			}
		}
	}
}
