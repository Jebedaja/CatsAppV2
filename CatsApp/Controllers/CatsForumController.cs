// CatsForumController.cs
using Microsoft.AspNetCore.Mvc;
using CatsForum.Models;
using System.Linq;
using CatsApp.Data;

namespace CatsForum.Controllers
{
    public class CatsForumController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CatsForumController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Comments()
        {
            var comments = _context.Comments.ToList();
            return View("Comments", comments);
        }

        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            if (ModelState.IsValid)
            {
                _context.Comments.Add(comment);
                _context.SaveChanges();
                return RedirectToAction("Comments");
            }
            return View("Comments", comment);
        }
    }
}
