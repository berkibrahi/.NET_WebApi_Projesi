using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
	public interface IServiceManager
	{
		public IProjectService ProjectService { get; }
		public IEmployeeService EmployeeService { get; }
	}
}
