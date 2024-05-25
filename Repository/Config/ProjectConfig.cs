using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Config
{
	public class ProjectConfig : IEntityTypeConfiguration<Project>
	{
		public void Configure(EntityTypeBuilder<Project> builder)
		{
			builder.HasData(
				new Project
				{
					Id=new Guid("224ac437-09d9-477d-a53d-55486b9d7a23"),
					Name="ASP.NET core Web Api Project",
					Description="Web Application Interface",
					Field="sofware science"
				}
				);
		}
	}
}
