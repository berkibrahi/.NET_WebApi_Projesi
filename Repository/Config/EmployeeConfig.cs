using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
	public class EmployeeConfig : IEntityTypeConfiguration<Employee>
	{
		public void Configure(EntityTypeBuilder<Employee> builder)
		{
			builder.HasData(
				new Employee {
					Id=new Guid("f6dacc0c-20fe-42e0-aa0b-c585a0ca1083"),
					ProjectId=new Guid("224ac437-09d9-477d-a53d-55486b9d7a23"),
					FirstName="ibrahim",
					LastName="Berk",
					Age=23,
					Position="Backend developer"

				}
				);
		}

	}
}
