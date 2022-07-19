using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Permissions;

namespace Blog.Pages
{
    public class CreateArticleModel : PageModel
    {
        public CreateArticle Command { get; set; }

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

        public IActionResult OnPost(CreateArticle command)
        {
            if (ModelState.IsValid)
            {
                var article = new Article(command.Title, command.Picture, command.PictureAlt,
                command.PictureTitle, command.ShortDescription, command.Body);

                _context.Articles.Add(article);
                _context.SaveChanges();
                return RedirectToPage("./Index");
            }
            else
            {
                ErrorMessage = "لطفا مقادیر خواسته شده را تکمیل نمایید.";
                return Page();
            }
        }
    }
}
