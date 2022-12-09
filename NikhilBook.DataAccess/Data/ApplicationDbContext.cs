using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NikhilBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NikhilBookStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Category> CoverType { get; set; }
        public DbSet<Category> Product { get; set; }
    }
}
