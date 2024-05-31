using Entities.Models;

using Shared.DataTransferObjects;

namespace ServiceContracts
{
	public interface IProjectService
	{
        ProjectDto CreateOneProject(ProjectDtoForCreation projectDto);
        IEnumerable<ProjectDto> GetAllProject(bool trackChanges);
		ProjectDto GetOneProjectById(Guid id, bool trackChanges);
	}
}
