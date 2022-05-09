using Microsoft.EntityFrameworkCore;
using NLayerLab.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerLab.Data.Concrete.EntityFramework.Contexts
{
    public class NLayerLabContext: DbContext 
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users  { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=NLayerLab;Trusted_Connection=True;Connect Timeout=30;MultipleActiveResultSets=True;");
        }
    }
}
