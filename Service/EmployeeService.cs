using AutoMapper;
using Contracts;
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
			try
			{
				var employeelist = _repository.Employee.GetEmployeesByProjectId(projectId, trackChanges);
				var employeelistDtos = _mapper.Map<IEnumerable<EmployeeDto>>(employeelist);
				return employeelistDtos;
			}
			catch (Exception ex)
			{
				_logger.LogError("getallemployee  hata oluştu" + ex.Message);
				throw;
			}
		}

		public EmployeeDto GetoneEmployeeProjectById(Guid id,Guid employeeId ,bool trackChanges)
		{
			try
			{
				var employee= _repository.Employee.GetEmployeeByProjectId(id,employeeId, trackChanges);
				var employeeDto = _mapper.Map<EmployeeDto>(employee);
				return employeeDto;
			}
			catch (Exception ex)
			{
				_logger.LogError("employee repository get project hata" + ex.Message);
				throw;
			}
		}
	}
}
