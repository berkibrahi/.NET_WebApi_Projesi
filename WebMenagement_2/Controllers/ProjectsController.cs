using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entities.Models;
using Contracts;
using Repository; // Doğru using ifadesi, noktalı virgül eklenmiş

namespace WebMenagement_2.Controllers
{
	[Route("api/projects")] // Route attribute düzeltildi
	[ApiController]
	public class ProjectsController : ControllerBase
	{
		private ILoggerMenager _logger;
		private List<Project> _projectList;
		private IRepositorMenager _repository;
        public ProjectsController(ILoggerMenager logger,IRepositorMenager repository)
        {
			_logger = logger;
			_repository = repository;
			_projectList = new List<Project>{
				new Project
				{
					Id=Guid.NewGuid(),Name="proje 1"
				},
				new Project
				{
					Id = Guid.NewGuid(),
					Name = "proje 2"
				}
				};
		}
      
		[HttpGet]
		public IActionResult Get()
			
		{
			try {
				_logger.LogInfo("project.Get() gerçeklerşti");
				var list = _repository.Project.GetAllProjects(false);
			return Ok(list);
			}
			catch (Exception ex) {
				_logger.LogError("project.Get() hatası oluşru" + ex.Message);
				throw;
			}
			
			
		}

		

		
		

		// Diğer metotlar ve işlemler
	}
}
