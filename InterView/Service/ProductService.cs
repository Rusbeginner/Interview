using InterView.Data;
using InterView.IService;

namespace InterView.Service
{
    public class ProductService : IProductService
    {
        private List<Product> _products;
        public ProductService()
        {
            _products = new List<Product>()
            {
                new Product() {IdProducto = 1, Name = "Camisa", IdCategory = 1},
                new Product() {IdProducto = 2, Name = "Pantalon", IdCategory = 1},
                new Product() {IdProducto = 3, Name = "Short", IdCategory = 1},
                new Product() {IdProducto = 4, Name = "Tenis", IdCategory = 2},
                new Product() {IdProducto = 5, Name = "Zandalias", IdCategory = 2},
                new Product() {IdProducto = 6, Name = "Grabadora", IdCategory = 3},
                new Product() {IdProducto = 7, Name = "Teatro en Casa", IdCategory = 3},
            };
        }
        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public List<Product> GetProductsByIdCategory(int IdCategory)
        {
            return GetAllProducts().Where(x => x.IdCategory == IdCategory).ToList();
        }
    }
}
