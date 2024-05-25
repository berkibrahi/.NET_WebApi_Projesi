using Contracts;
using Entities.Models;
using ServiceContracts;

namespace Service
{
	public class EmployeeService : IEmployeeService
	{
		private readonly IRepositorMenager _repository;
		private readonly ILoggerMenager _logger;

		public EmployeeService(IRepositorMenager repository, ILoggerMenager logger)
		{
			_repository = repository;
			_logger = logger;
		}

	

		public IEnumerable<Employee> GetAllEmployeesByProjectId(Guid projectId, bool trackChanges)
		{
			try
			{
				var employeelist = _repository.Employee.GetEmployeesByProjectId(projectId, trackChanges);
				return employeelist;
			}
			catch (Exception ex)
			{
				_logger.LogError("getallemployee  hata oluştu" + ex.Message);
				throw;
			}
		}

		public Employee GetoneEmployeeProjectById(Guid id,Guid employeeId ,bool trackChanges)
		{
			try
			{
				return _repository.Employee.GetEmployeeByProjectId(id,employeeId, trackChanges);
			}
			catch (Exception ex)
			{
				_logger.LogError("employee repository get project hata" + ex.Message);
				throw;
			}
		}
	}
}
