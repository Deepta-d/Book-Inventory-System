using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookInventory.Models.DTOs;

namespace BookInventory.Models
{
    public class AddBookViewModel
    {
        #region Constructors

        /// <summary>
        /// Reserved for MVC binding. Do not use.
        /// </summary>
        public AddBookViewModel()
        {
        }

        public AddBookViewModel(BookDTO bookDTO)
        {
            BookDTO = bookDTO;
        }

        #endregion

        public BookDTO BookDTO { get; set; }

        public string GetModalTitle()
        {
            return "Add Book";
        }
    }
}