using System.Collections.Generic;
using BookInventory.Models.DTOs;

namespace BookInventory.Models
{
    public class IndexViewModel
    {
        #region Constructors

        /// <summary>
        /// Reserved for MVC binding. Do not use.
        /// </summary>
        public IndexViewModel()
        {
        }

        public IndexViewModel(List<BookDTO> bookDTOs)
        {
            BookDTOs = bookDTOs;
        }

        #endregion

        public List<BookDTO> BookDTOs { get; set; }


    }
}