using Blog_Management_System.Models;

namespace Blog_Management_System.Services
{
	public interface IBlogService
	{
		IEnumerable<BlogPost> GetAllPosts();
		BlogPost? GetPostById(int id);
		void AddPost(BlogPost post);
		void UpdatePost(BlogPost post);
		void DeletePost(int id);
	}
}
