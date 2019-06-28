using Modist.Database;
using Modist.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modist.Services
{
    public class CategoriesService
    {

        public List<Category> GetAllCategories()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.categories.ToList();
            }
        }


       public void SaveCategory(Category category)
        {
            using (var context = new ApplicationDbContext())
            {
                context.categories.Add(category);
                context.SaveChanges();

            }
        }

    }
}
