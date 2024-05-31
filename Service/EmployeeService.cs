using AutoMapper;
using Contracts;
using Entities.Exceptionn;
using Entities.Models;
using ServiceContracts;
using Shared.DataTransferObjects;

namespace Service
{
	public class EmployeeService : IEmployeeService
	{
		private readonly IRepositorMenager _repository;
		private readonly ILoggerMenager _logger;
		private readonly IMapper _mapper;

		public EmployeeService(IRepositorMenager repository, ILoggerMenager logger,IMapper mapper)
		{
			_repository = repository;
			_logger = logger;
			_mapper = mapper;
		}

	

		public IEnumerable<EmployeeDto> GetAllEmployeesByProjectId(Guid projectId, bool trackChanges)
		{
            CheckProjectExists(projectId);
            var employeelist = _repository.Employee.GetEmployeesByProjectId(projectId, trackChanges);
				var employeelistDtos = _mapper.Map<IEnumerable<EmployeeDto>>(employeelist);
				return employeelistDtos;
			
		}

		public EmployeeDto GetoneEmployeeProjectById(Guid projectId,Guid employeeId ,bool trackChanges)
		{
			CheckProjectExists(projectId);
            var employee= _repository.Employee.GetEmployeeByProjectId(projectId,employeeId, trackChanges);
			if (employee == null)
				throw new EmployeeNotFoundExceptions(projectId);
				var employeeDto = _mapper.Map<EmployeeDto>(employee);
				return employeeDto;
			
			
		}
		private void CheckProjectExists(Guid projectId)
		{
            var project = _repository.Project.GetOneProjectById(projectId,  false);
            if (project == null)
                throw new ProjectNotFoundExceptions(projectId);
        }
	}
}
