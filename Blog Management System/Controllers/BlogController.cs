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
			if (ModelState.IsValid)
			{
				_blogService.AddPost(post);
				return RedirectToAction("Index");
			}
			return View(post);
		}

		public IActionResult Edit(int id)
		{
			BlogPost? post = _blogService.GetPostById(id);
			if (post != null)
			{
				return View(post);
			}
			return NotFound();
		}

		[HttpPost]
		public IActionResult Edit(BlogPost post)
		{
			if (ModelState.IsValid)
			{
				_blogService.UpdatePost(post);
				return RedirectToAction("Index");
			}
			return View(post);
		}
		[HttpGet]
		public IActionResult Delete(int Id)
		{
			BlogPost? post = _blogService.GetPostById(Id);
			if (post == null)
			{
				return NotFound();
			}
			return View(post);
		}
		[HttpPost, ActionName("Delete")]
		public IActionResult DeleteConfirmed(int id)
		{
			if (ModelState.IsValid)
			{
				_blogService.DeletePost(id);
			}
			return RedirectToAction("Index");
		}

		public IActionResult Show(int id)
		{
			BlogPost? post = _blogService.GetPostById(id);
			if(post != null)
			{
				return View(post);
			}
			return NotFound();
		}
	}
}
