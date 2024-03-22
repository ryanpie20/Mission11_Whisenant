using Microsoft.AspNetCore.Mvc;
using Mission11_Whisenant.Models;
using Mission11_Whisenant.Models.ViewModels;
using System.Diagnostics;

namespace Mission11_Whisenant.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _bookRepo;

        public HomeController(IBookRepository temp)
        {
            _bookRepo = temp;
        }

        public IActionResult Index(int pageNum)
        {

            int pageSize = 10;

            var blah = new BookListVIewModels
            {
                Books = _bookRepo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _bookRepo.Books.Count()
                }
            };
            return View(blah);
        }
    }
}
