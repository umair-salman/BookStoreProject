using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreProject
{
    public class Category
    {
        public int Id { get; set; }
        public string Genre { get; set; }
        public double discountPercentage { get; set; }// In case if the category is on discount .

        public List<Category> AddCategory()
        {
            var categoriesList = new List<Category>();

            categoriesList.Add(new Category { Id = 1, Genre = "Crime", discountPercentage = 5.0 });
            categoriesList.Add(new Category { Id = 1, Genre = "Fantasy", discountPercentage = 0.0 });
            categoriesList.Add(new Category { Id = 1, Genre = "Romance", discountPercentage = 0.0 });

            return categoriesList;
        }
        public void DeleteCategory()
        { //Not Implemented
        }
    }
}
