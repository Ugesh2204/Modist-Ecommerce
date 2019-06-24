using Modist.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modist.Database
{
    public class ApplicationDbContext:DbContext, IDisposable
    {

        public ApplicationDbContext() : base("ModistConnection")
        {

        }

        public DbSet<Category> categories { get; set; }

        public  DbSet<Product> products { get; set; }
    }
}
