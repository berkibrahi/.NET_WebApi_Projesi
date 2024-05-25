using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entities.Models;
using Contracts;
using Repository;
using ServiceContracts; // Doğru using ifadesi, noktalı virgül eklenmiş

namespace WebMenagement_2.Controllers
{
	[Route("api/projects")] // Route attribute düzeltildi
	[ApiController]
	public class ProjectsController : ControllerBase
	{
		
		
		private IServiceManager _service;
        public ProjectsController(IServiceManager service)
        {
			
			_service = service;
			
		}
      
		[HttpGet]
		public IActionResult Get()
			
		{
			
				
			var list = _service.ProjectService.GetAllProject(false);
			return Ok(list);
			
			
			
			
		}

		

		
		

		// Diğer metotlar ve işlemler
	}
}
