using System.ComponentModel.DataAnnotations;

namespace Blog_Management_System.Models
{
	public class BlogPost
	{
		public int Id { get; set; }
		[Required(ErrorMessage ="Title shouldnot be empty")]
		public string? Title { get; set; }
		public string? Content { get; set; }
		public DateTime CreatedDate { get; set; }

		[Required(ErrorMessage ="Author shouldnot be empty")]
		public string? Author { get; set; }
	}
}
