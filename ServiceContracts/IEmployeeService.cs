using Entities.Models;
using Shared.DataTransferObjects;

namespace ServiceContracts
{
	public interface IEmployeeService
	{
        EmployeeDto CreateoneEmployeeProjectById(Guid projectId, EmployeeDtoForCreation employeeDto, bool trackChanges);
        IEnumerable<EmployeeDto> GetAllEmployeesByProjectId(Guid projectId,bool trackChanges);
		EmployeeDto GetoneEmployeeProjectById(Guid projectid,Guid employeId, bool trackChanges);

	}
}
