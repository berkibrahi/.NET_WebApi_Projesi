using Entities.Models;

namespace ServiceContracts
{
	public interface IEmployeeService
	{
		IEnumerable<Employee> GetAllEmployeesByProjectId(Guid projectId,bool trackChanges);
		Employee GetoneEmployeeProjectById(Guid projectid,Guid employeId, bool trackChanges);

	}
}
