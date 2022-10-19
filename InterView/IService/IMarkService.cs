using InterView.Data;

namespace InterView.IService
{
    public interface IMarkService
    {
        List<Mark> GetAllMarks();
        List<Mark> GetMarksByIdProduct(int IdProduct);
        List<Sales> GetSalesByIdMark();

    }
}
