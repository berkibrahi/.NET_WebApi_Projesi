using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public class RepositoryMenagercs : IRepositorMenager

	{
		private readonly RepositoryContext _context;

		public RepositoryMenagercs(RepositoryContext context)
		{
			_context = context;
			_projectRepository = new ProjectRepository(_context);
			_employeeRepository = new EmployeeRepository(_context);
		}

		private IProjectRepository _projectRepository;
		private IEmployeeRepository _employeeRepository;
		public IProjectRepository Project => _projectRepository;

		public IEmployeeRepository Employee => _employeeRepository;

		public void Save()
		{
			_context.SaveChanges();
		}
	}
}
