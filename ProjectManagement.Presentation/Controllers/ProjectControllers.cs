﻿using Microsoft.AspNetCore.Mvc;
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
	public class ProjectControllers:ControllerBase
	{
		private readonly IServiceManager _service;

		public ProjectControllers(IServiceManager service)
		{
			_service = service;
		}
		[HttpGet]
		public IActionResult GetAllProjects()
		{
			try
			{
				var projects = _service.ProjectService.GetAllProject(false);
				return Ok(projects);
			}
			catch (Exception ex)
			{
				return StatusCode(500, "internal server error");
			}
		}
	}
}
