using InterView.Data;

namespace InterView.IService
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        List<Product> GetProductsByIdCategory(int IdCategory);
    }
}
