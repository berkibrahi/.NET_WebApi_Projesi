using Entities.Models;

namespace ServiceContracts
{
	public interface IProjectService
	{
		IEnumerable<Project> GetAllProject(bool trackChanges);
		Project GetOneProjectById(Guid id, bool trackChanges);
	}
}
