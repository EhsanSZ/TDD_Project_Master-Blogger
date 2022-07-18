using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Blog.Models;
using System.Security.Permissions;

namespace Blog.Pages
{
    public class CreateArticleModel : PageModel
    {

        [TempData]
        public string ErrorMessage { get; set; }

        private readonly BlogContext _context;

        public CreateArticleModel(BlogContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

    }
}
