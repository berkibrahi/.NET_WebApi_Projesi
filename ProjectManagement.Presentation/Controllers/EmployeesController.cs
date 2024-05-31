using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using Shared.DataTransferObjects;
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
			
				var employeelist = _service.EmployeeService.GetAllEmployeesByProjectId(projectId, false);
				return Ok(employeelist);
			

		}
		[HttpGet("{id:guid}",Name ="GetOneEmployeeByProjectIdAndId")]
		public IActionResult GetoneEmployeeProjectById(Guid projectId,Guid id)
		{
			
			
				var employee = _service.EmployeeService.GetoneEmployeeProjectById(projectId,id, false);
				return Ok(employee);
			
			
		}
        [HttpPost]
        public IActionResult CreateoneEmployeeProjectById(Guid projectId, [FromBody]EmployeeDtoForCreation employeeDto)
        {

			EmployeeDto employee = _service.EmployeeService.CreateoneEmployeeProjectById(projectId, employeeDto, true);

			return CreatedAtRoute("GetOneEmployeeByProjectIdAndId", new { projectId, id = employee.Id }, employee);
        }
    }
}
