namespace Blog_Management_System.Models
{
	public class BlogPost
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Content { get; set; }
		public DateTime CreatedDate { get; set; }
		public string? Author { get; set; }
	}
}
