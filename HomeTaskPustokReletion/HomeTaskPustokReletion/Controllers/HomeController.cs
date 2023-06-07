using HomeTaskPustokReletion.DAL;
using HomeTaskPustokReletion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeTaskPustokReletion.Controllers
{
    public class HomeController : Controller
    {
        private readonly PustokDbContext _context;

        public HomeController(PustokDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ICollection<Book> books = _context.Books
                .Include(x => x.Author)
                .Include(x => x.Genre)
                .Include(x => x.BookTags)
                .ThenInclude(xm => xm.Tag).ToList();
            return View(books);
        }
    }
}
