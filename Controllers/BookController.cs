using System;
using System.Text;
using System.Web.Mvc;
using BookInventory.Models;
using BookInventory.Services;

namespace BookInventory.Controllers
{
    public class BookController : Controller
    {
        public virtual ActionResult Index()
        {
            try
            {
                IBookService bookService = new BookService();

                IndexViewModel viewModel = bookService.GetIndexViewModel();

                return View(viewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public virtual ActionResult AddBook()
        {
            try
            {
                IBookService bookService = new BookService();

                AddBookViewModel viewModel = bookService.GetAddBookViewModel();

                return View(viewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult AddBook(AddBookViewModel viewModel)
        {
            if (viewModel == null)
            {
                throw new ArgumentNullException(nameof(viewModel));
            }

            try
            {
                if (ModelState.IsValid)
                {
                    IBookService bookService = new BookService();

                    bookService.AddBook(viewModel);

                    return RedirectToAction("Index", "Book");
                }
                else
                {
                    return View(viewModel);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public virtual ActionResult ExportToCsv()
        {
            try
            {
                IBookService bookService = new BookService();

                byte[] csvContent = bookService.GetCsvResult();

                return File(csvContent, "text/csv", "Books.csv");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public virtual ActionResult ExportToJson()
        {
            try
            {
                IBookService bookService = new BookService();

                string jsonContent = bookService.GetJsonResult();

                byte[] fileBytes = Encoding.UTF8.GetBytes(jsonContent);

                return File(fileBytes, "application/json", "Books.json");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}