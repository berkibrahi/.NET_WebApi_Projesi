using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entities.Models;
using Contracts; // Doğru using ifadesi, noktalı virgül eklenmiş

namespace WebMenagement_2.Controllers
{
	[Route("api/projects")] // Route attribute düzeltildi
	[ApiController]
	public class ProjectsController : ControllerBase
	{
		private ILoggerMenager _logger;
		private List<Project> _projectList;
        public ProjectsController(ILoggerMenager logger)
        {
			_logger = logger;
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
			return Ok(_projectList);
			}
			catch (Exception ex) {
				_logger.LogError("project.Get() hatası oluşru" + ex.Message);
				throw;
			}
			
			
		}

		

		
		

		// Diğer metotlar ve işlemler
	}
}
