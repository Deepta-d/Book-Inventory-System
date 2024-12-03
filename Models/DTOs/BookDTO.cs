using System;
using System.ComponentModel.DataAnnotations;

namespace BookInventory.Models.DTOs
{
    public class BookDTO
    {
        #region Constructors

        /// <summary>
        /// Reserved for MVC binding. Do not use.
        /// </summary>
        public BookDTO()
        {
        }

        public BookDTO(Guid entryId, string title, string author, string genre, DateTime publicationDate, long iSBN)
        {
            EntryID = entryId;
            Title = title;
            Author = author;
            Genre = genre;
            PublicationDate = publicationDate;
            ISBN = iSBN;
        }

        #endregion

        [Key]
        public Guid EntryID { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        public string Author { get; set; }

        [Required]
        [StringLength(100)]
        public string Genre { get; set; }

        [Required]
        public DateTime PublicationDate { get; set; }

        [Required]
        [Range(1000000000000, 9999999999999, ErrorMessage = "The field must be exactly 13 digits.")]
        public long ISBN { get; set; }
    }
}