using InterView.Data;

namespace InterView.IService
{
    public interface ISalesService
    {
        List<Sales> GetSales();
        List<Sales> GetSalesByMark(int IdMark);

    }
}
