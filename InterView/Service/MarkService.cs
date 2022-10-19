using InterView.Data;
using InterView.IService;

namespace InterView.Service
{
    public class MarkService : IMarkService
    {
        public List<Mark> GetAllMarks()
        {
            return new List<Mark>()
            {
                new Mark() {IdMark = 1, Name = "Yumuri", IdProduct = 1},
                new Mark() {IdMark = 2, Name = "Bacteria", IdProduct = 1},
                new Mark() {IdMark = 3, Name = "Gucci", IdProduct = 2},
                new Mark() {IdMark = 4, Name = "Tom Evans", IdProduct = 2},
                new Mark() {IdMark = 5, Name = "Short1", IdProduct = 3},
                new Mark() {IdMark = 6, Name = "Short2", IdProduct = 3},
                new Mark() {IdMark = 8, Name = "Adidas", IdProduct = 4},
                new Mark() {IdMark = 9, Name = "Nike", IdProduct = 4},
                new Mark() {IdMark = 10, Name = "Reebox", IdProduct = 5},
                new Mark() {IdMark = 11, Name = "Puma", IdProduct = 5},
                new Mark() {IdMark = 12, Name = "Sony", IdProduct = 6},
                new Mark() {IdMark = 13, Name = "Panasonic", IdProduct = 6},
                new Mark() {IdMark = 14, Name = "Sanyo", IdProduct = 7},
                new Mark() {IdMark = 15, Name = "Daytron", IdProduct = 7}
            };
        }

        public List<Mark> GetMarksByIdProduct(int IdProduct)
        {
            return GetAllMarks().Where(x => x.IdProduct == IdProduct).ToList();
        }

        public List<Sales> GetSalesByIdMark()
        {
            throw new NotImplementedException();
        }
    }
}
