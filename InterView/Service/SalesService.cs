using InterView.Data;
using InterView.IService;
using System.Runtime.CompilerServices;

namespace InterView.Service
{
    public class SalesService : ISalesService
    {
        private List<Sales> _sales;
        public SalesService()
        {
            _sales = new List<Sales>()
            {
                new Sales() {IdMark = 1, Month = "January", Sale=145},
                new Sales() {IdMark = 1, Month = "February", Sale=65},
                new Sales() {IdMark = 1, Month = "March", Sale=95},
                new Sales() {IdMark = 1, Month = "April", Sale=214},
                new Sales() {IdMark = 2, Month = "January", Sale=658},
                new Sales() {IdMark = 2, Month = "February", Sale=147},
                new Sales() {IdMark = 2, Month = "March", Sale=352},
                new Sales() {IdMark = 2, Month = "April", Sale=41},
                new Sales() {IdMark = 3, Month = "January", Sale=47},
                new Sales() {IdMark = 3, Month = "February", Sale=85},
                new Sales() {IdMark = 3, Month = "March", Sale=14},
                new Sales() {IdMark = 3, Month = "April", Sale=459},
                new Sales() {IdMark = 4, Month = "January", Sale=524},
                new Sales() {IdMark = 4, Month = "February", Sale=148},
                new Sales() {IdMark = 4, Month = "March", Sale=321},
                new Sales() {IdMark = 4, Month = "April", Sale=149},
                new Sales() {IdMark = 5, Month = "January", Sale=247},
                new Sales() {IdMark = 5, Month = "February", Sale=266},
                new Sales() {IdMark = 5, Month = "March", Sale=176},
                new Sales() {IdMark = 5, Month = "April", Sale=211},
                new Sales() {IdMark = 6, Month = "January", Sale=198},
                new Sales() {IdMark = 6, Month = "February", Sale=148},
                new Sales() {IdMark = 6, Month = "March", Sale=99},
                new Sales() {IdMark = 6, Month = "April", Sale=110},
                new Sales() {IdMark = 7, Month = "January", Sale=103},
                new Sales() {IdMark = 7, Month = "February", Sale=136},
                new Sales() {IdMark = 7, Month = "March", Sale=269},
                new Sales() {IdMark = 7, Month = "April", Sale=471},
                new Sales() {IdMark = 8, Month = "January", Sale=139},
                new Sales() {IdMark = 8, Month = "February", Sale=145},
                new Sales() {IdMark = 8, Month = "March", Sale=47},
                new Sales() {IdMark = 8, Month = "April", Sale=258},
                new Sales() {IdMark = 9, Month = "January", Sale=258},
                new Sales() {IdMark = 9, Month = "February", Sale=287},
                new Sales() {IdMark = 9, Month = "March", Sale=111},
                new Sales() {IdMark = 9, Month = "April", Sale=301},
                new Sales() {IdMark = 10, Month = "January", Sale=421},
                new Sales() {IdMark = 10, Month = "February", Sale=436},
                new Sales() {IdMark = 10, Month = "March", Sale=417},
                new Sales() {IdMark = 10, Month = "April", Sale=148},
                new Sales() {IdMark = 11, Month = "January", Sale=478},
                new Sales() {IdMark = 11, Month = "February", Sale=94},
                new Sales() {IdMark = 11, Month = "March", Sale=178},
                new Sales() {IdMark = 11, Month = "April", Sale=352},
                new Sales() {IdMark = 12, Month = "January", Sale=283},
                new Sales() {IdMark = 12, Month = "February", Sale=308},
                new Sales() {IdMark = 12, Month = "March", Sale=276},
                new Sales() {IdMark = 12, Month = "April", Sale=310},
                new Sales() {IdMark = 13, Month = "January", Sale=541},
                new Sales() {IdMark = 13, Month = "February", Sale=102},
                new Sales() {IdMark = 13, Month = "March", Sale=210},
                new Sales() {IdMark = 13, Month = "April", Sale=330},
                new Sales() {IdMark = 14, Month = "January", Sale=197},
                new Sales() {IdMark = 14, Month = "February", Sale=241},
                new Sales() {IdMark = 14, Month = "March", Sale=290},
                new Sales() {IdMark = 14, Month = "April", Sale=183},
                new Sales() {IdMark = 15, Month = "April", Sale=201},
                new Sales() {IdMark = 15, Month = "April", Sale=179},
                new Sales() {IdMark = 15, Month = "April", Sale=200},
                new Sales() {IdMark = 15, Month = "April", Sale=342},
          
               
            };
        }

        public List<Sales> GetSales()
        {
            return _sales;
        }

        public List<Sales> GetSalesByMark(int IdMark)
        {
            return GetSales().Where(x => x.IdMark == IdMark).ToList();
        }
    }
}
