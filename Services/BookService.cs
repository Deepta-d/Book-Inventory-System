using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using BookInventory.Data;
using BookInventory.Models;
using BookInventory.Models.DTOs;
using Newtonsoft.Json;

namespace BookInventory.Services
{


    public class BookService : IBookService
    {
        public IndexViewModel GetIndexViewModel()
        {
            List<BookDTO> bookDTOs = GetBookDtoList();

            IndexViewModel indexViewModel = new IndexViewModel(bookDTOs: bookDTOs);

            return indexViewModel;
        }

        public AddBookViewModel GetAddBookViewModel()
        {
            BookDTO bookDTO = new BookDTO();

            AddBookViewModel addBookViewModel = new AddBookViewModel(bookDTO);

            return addBookViewModel;
        }

        public void AddBook(AddBookViewModel viewModel)
        {
            if (viewModel == null || viewModel.BookDTO == null)
            {
                throw new ArgumentNullException(nameof(viewModel), "ViewModel or Book cannot be null");
            }

            viewModel.BookDTO.EntryID = Guid.NewGuid();

            using (BookDbContext dbContext = new BookDbContext())
            {
                viewModel.BookDTO.EntryID = Guid.NewGuid();

                dbContext.Books.Add(viewModel.BookDTO);

                dbContext.SaveChanges();
            }
        }

        public byte[] GetCsvResult()
        {
            var csv = new StringBuilder();

            csv.AppendLine("Id,Title,Author,Genre,Publication Date,ISBN");

            List<BookDTO> bookDTOs = GetBookDtoList();

            foreach (var book in bookDTOs)
            {
                csv.AppendLine($"{book.EntryID},{book.Title},{book.Author},{book.Genre},{book.PublicationDate},{book.ISBN}");
            }

            byte[] csvBytes = Encoding.UTF8.GetBytes(csv.ToString());

            return csvBytes;
        }

        public string GetJsonResult()
        {
            List<BookDTO> bookDTOs = GetBookDtoList();

            string json = JsonConvert.SerializeObject(bookDTOs, Formatting.Indented);

            return json;
        }

        private List<BookDTO> GetBookDtoList()
        {
            BookDbContext dbContext = new BookDbContext();

            List<BookDTO> bookDtos = dbContext.Books.ToList();

            return bookDtos;
        }
    }
}