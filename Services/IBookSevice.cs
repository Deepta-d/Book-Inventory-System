using BookInventory.Models;

namespace BookInventory.Services
{
    public interface IBookService
    {
        IndexViewModel GetIndexViewModel();

        AddBookViewModel GetAddBookViewModel();

        void AddBook(AddBookViewModel viewModel);

        byte[] GetCsvResult();

        string GetJsonResult();
    }
}