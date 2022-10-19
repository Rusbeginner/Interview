using InterView.Data;
using InterView.IService;

namespace InterView.Service
{
    public class CategoryService : ICategoryService
    {
        public List<Category> GetCategories()
        {
            return new List<Category>()
            {
                new Category() {IdCategory = 1, Name = "Ropa"},
                new Category() {IdCategory = 2, Name = "Calzado"},
                new Category() {IdCategory = 3, Name = "Electrodomesticos"}
            };
        }
    }
}
