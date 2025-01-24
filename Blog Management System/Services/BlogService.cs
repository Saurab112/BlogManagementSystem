using Blog_Management_System.Models;

namespace Blog_Management_System.Services
{
	public class BlogService : IBlogService
	{
		private readonly List<BlogPost> _posts = new List<BlogPost>()
		{
			new BlogPost() { Title = "study", Author = "sauravv", Content = "hello world", CreatedDate = DateTime.Now },
			new BlogPost() { Title = "study", Author = "sauravv", Content = "hello world", CreatedDate = DateTime.Now },
			new BlogPost() { Title = "study", Author = "sauravv", Content = "hello world", CreatedDate = DateTime.Now }
		};
		public void AddPost(BlogPost post)
		{
			_posts.Add(post);
		}

		public void DeletePost(int id)
		{
			BlogPost? post = _posts.Find(x => x.Id == id);
			if (post != null)
			{
				_posts.Remove(post);
			}
		}

		public IEnumerable<BlogPost> GetAllPosts()
		{
			return _posts;
		}

		public BlogPost? GetPostById(int id)
		{
			return _posts.Find(post => post.Id == id);
		}

		public void UpdatePost(BlogPost post)
		{
			BlogPost? existingPost = GetPostById(post.Id);
			if (existingPost != null)
			{
				existingPost.Title = post.Title;
				existingPost.Content = post.Content;
				existingPost.Author = post.Author;
			}
		}
	}
}
