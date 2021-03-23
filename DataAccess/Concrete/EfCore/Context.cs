using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EfCore
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ProjeDb;integrated security=true;");
        }

        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Kategoriler> Kategorilers { get; set; }
    }
}
