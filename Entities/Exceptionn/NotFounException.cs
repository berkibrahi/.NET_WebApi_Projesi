using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptionn
{
    public class NotFounException : Exception
    {
        protected NotFounException(string message):base(message)
        {
        }
    }
    public sealed class ProjectNotFoundExceptions : NotFounException
    {
        public ProjectNotFoundExceptions(Guid ProjectId) 
            : base($"bu proje id: {ProjectId} bulunamadı")
        {
        }
    }
    public sealed class EmployeeNotFoundExceptions : NotFounException
    {
        public EmployeeNotFoundExceptions(Guid EmployeId)
            : base($"bu employee id: {EmployeId} bulunamadı")
        {
        }
    }
}
