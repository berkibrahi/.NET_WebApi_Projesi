﻿using Contracts;
using Entities.Models;
using ServiceContracts;

namespace Service
{
	public class ProjectService : IProjectService
	{
		private readonly IRepositorMenager _repository;
		private readonly ILoggerMenager _logger;

		public ProjectService(IRepositorMenager repository, ILoggerMenager logger)
		{
			_repository = repository;
			_logger = logger;
		}

		public IEnumerable<Project> GetAllProject(bool trackChanges)
		{
			var projects = _repository.Project.GetAllProjects(trackChanges);
			return projects;
		}
	}
}
