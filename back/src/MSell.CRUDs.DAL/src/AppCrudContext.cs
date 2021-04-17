using Microsoft.EntityFrameworkCore;
using MSell.CRUDs.Share.src.ENTITY;
using System;

namespace MSell.CRUDs.DAL.src
{
    internal class AppCrudContext: DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppCrudContext(DbContextOptions<AppCrudContext> options) : base(options) { }
    }
}

