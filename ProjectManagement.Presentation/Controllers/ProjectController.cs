using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Presentation.Controllers
{
	[ApiController]
	[Route("api/projects")]
	public class ProjectController:ControllerBase
	{
		private readonly IServiceManager _service;

		public ProjectController(IServiceManager service)
		{
			_service = service;
		}
		[HttpGet]
		public IActionResult GetAllProjects()
		{
			
				var projects = _service.ProjectService.GetAllProject(false);
				return Ok(projects);
			
		}
		[HttpGet("{id:guid}")]
		public IActionResult GetOneProjectById(Guid id)
		{
			
				var project = _service.ProjectService.GetOneProjectById(id, false);
				return Ok(project);
			
		}
	}
}
