﻿using Microsoft.EntityFrameworkCore;
using WebApi.Domain.Models;

namespace WebApi.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Author> authors { get; set; }
        public DbSet<Book> books { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }
    }
}