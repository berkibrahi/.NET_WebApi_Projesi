using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
	public class Project
	{
        [Column("ProjectId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="isim alanı gereklidir")]
        [StringLength(60,ErrorMessage ="max uzunluk 60 'tır")]
        public string Name { get; set; }
        public string? Description { get; set; }
		public string? Field { get; set; }
		public string? ImageUrl { get; set; }
        public ICollection<Employee>? Employees { get; set; }
	}
}


