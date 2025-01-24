using Blog_Management_System.Models;
using Blog_Management_System.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Management_System.Controllers
{
	public class BlogController : Controller
	{
		private readonly IBlogService _blogService;

		public BlogController(IBlogService blogService)
		{
			_blogService = blogService;
		}
		public IActionResult Index()
		{
			var post = _blogService.GetAllPosts();
			return View(post);
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(BlogPost post)
		{
			_blogService.AddPost(post);
			return RedirectToAction("Index");
		}
	}
}
