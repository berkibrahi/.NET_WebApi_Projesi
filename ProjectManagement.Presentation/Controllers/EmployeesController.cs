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
	[Route("api/projects/{projectId}/employees")]
	public class EmployeesController:ControllerBase
	{
		private readonly IServiceManager _service;

		public EmployeesController(IServiceManager service)
		{
			_service = service;
		}
		[HttpGet]
		public IActionResult GetAllEmployeProjectById(Guid projectId)
		{
			try
			{
				var employeelist = _service.EmployeeService.GetAllEmployeesByProjectId(projectId, false);
				return Ok(employeelist);
			}
		    catch (Exception ex){
				return StatusCode(500, "internal server error");
				throw;
			}

		}
		[HttpGet("{id:guid}")]
		public IActionResult GetoneEmployeeProjectById(Guid projectId,Guid id)
		{
			try
			{
				var employee = _service.EmployeeService.GetoneEmployeeProjectById(projectId,id, false);
				return Ok(employee);
			}
			catch (Exception ex)
			{
				return StatusCode(500, "internal error");
				throw;
			}
		}
	}
}
