using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using HarpreetsBooks.Models;

namespace HarpreetsBooks.DataAccess.Data       // modified the name space 
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CoverType> coverTypes { get; set; }        // added reference for CoverType
        public DbSet<Product> Products { get; set; }        // added refernece for Products 
    }
}
