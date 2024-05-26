using Entities.Models;
using Shared.DataTransferObjects;

namespace ServiceContracts
{
	public interface IEmployeeService
	{
		IEnumerable<EmployeeDto> GetAllEmployeesByProjectId(Guid projectId,bool trackChanges);
		EmployeeDto GetoneEmployeeProjectById(Guid projectid,Guid employeId, bool trackChanges);

	}
}
