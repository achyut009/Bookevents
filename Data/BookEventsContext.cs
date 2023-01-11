using BooksEvents.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksEvents.Data
{
    public class BookEventsContext : IdentityDbContext<UserModel>
    {
        public BookEventsContext(DbContextOptions<BookEventsContext> options) : base(options)
        {

        }

        public DbSet<Events> Event { get; set; }
    }
}
