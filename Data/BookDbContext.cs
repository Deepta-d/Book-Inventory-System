using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BookInventory.Models.DTOs;

namespace BookInventory.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext() : base("Localhost")
        {
        }

        public DbSet<BookDTO> Books { get; set; }
    }
}