using System.Collections.Generic;
using System.Linq;

namespace NorthWindLibrary.Classes
{
    public class DataOperations
    {
        /// <summary>
        /// Get all categories
        /// </summary>
        /// <returns></returns>
        public List<Category> GetCategories()
        {
            using (var context = new NorthWindContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.Categories.ToList();
            }
        }
        /// <summary>
        /// Get only Beverages, easy to read
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProductsWithCategoryBeverages()
        {
            using (var context = new NorthWindContext())
            {
                return context.Products
                    .Where(prod => prod.CategoryID == CategoriesName.Beverages)
                    .OrderBy(p => p.ProductName)
                    .ToList();
            }
        }
        /// <summary>
        /// Get only Confections, easy to read
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProductsWithCategoryConfections()
        {
            using (var context = new NorthWindContext())
            {
                return context.Products
                    .Where(prod => prod.CategoryID == CategoriesName.Confections)
                    .OrderBy(p => p.ProductName)
                    .ToList();
            }
        }
        /// <summary>
        /// Get products by category, common method yet not as readable as above.
        /// </summary>
        /// <param name="categoriesName">
        /// <see cref="CategoriesName"/> specifies which category to show</param>
        /// <returns></returns>
        public List<Product> GetProducts(CategoriesName categoriesName)
        {
            using (var context = new NorthWindContext())
            {
                return context.Products
                    .Where(prod => prod.CategoryID == categoriesName)
                    .OrderBy(p => p.ProductName)
                    .ToList();
            }
        }
        /// <summary>
        /// Shows how to get multiple categories
        /// </summary>
        /// <returns></returns>
        public List<Product> GetBeveragesAndCondiments()
        {
            using (var context = new NorthWindContext())
            {
                return context
                    .Products
                    .Where(p => p.CategoryID == CategoriesName.Beverages || 
                                p.CategoryID == CategoriesName.Condiments)
                    .ToList();
            }
        }
    }
}
