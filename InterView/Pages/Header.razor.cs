using InterView.Data;
using InterView.IService;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using MudBlazor.Extensions;
using System.Reflection.Metadata;

namespace InterView.Pages
{
    public partial class Header
    {
        [Inject] ICategoryService categoryService { get; set; }
        [Inject] IProductService productService { get; set; }
        [Inject] IMarkService markService { get; set; }
        [Inject] ISalesService salesService { get; set; }

        private List<Category>? Categories;
        private List<Product>? Products;
        private List<Mark>? Marks;
        private List<Sales>? Sales;

        private IEnumerable<int>? selectedValueCategories = new List<int>();
        private IEnumerable<int>? selectedValueProducts = new List<int>();
        private IEnumerable<int>? selectedValueMarks = new List<int>();
        static double[] series;
        public List<ChartSeries> Series;
        public string[] XAxisLabels = { "January", "February", "March", "April" };

         

        protected override void OnInitialized()
        {
            Categories = categoryService.GetCategories();
            selectedValueCategories = new List<int>()
            {
                Categories[0].IdCategory
            };

            Products = null;
            Products = productService.GetProductsByIdCategory(Categories[0].IdCategory);

            selectedValueProducts = new List<int>()
            {
                Products[0].IdProducto
            };

            Marks = null;
            Marks = markService.GetMarksByIdProduct(Products[0].IdProducto);
            selectedValueMarks = new List<int>()
            {
                 Marks[0].IdMark
            };

            Sales = null;
            Sales = salesService.GetSalesByMark(Marks[0].IdMark);
            series = new double[Sales.Count];

            for (var i = 0; i < Sales.Count; i++)
            {
                series[i] = Sales[i].Sale;
            }

         Series = new List<ChartSeries>()
        {
            new ChartSeries() { Name = "Ventas", Data = series }
        };
        }

        public List<Product> GetProductsByCategory(int IdCategory)
        {
            Products = productService.GetProductsByIdCategory(IdCategory);

            return Products;
        }

        void OnCategoriesValuesChanged(IEnumerable<int> values)
        {

            selectedValueCategories = null;
            selectedValueCategories = new List<int>()
            {
                values.ElementAt(0)
            };

            Products = null;
            Products = productService.GetProductsByIdCategory(values.ElementAt(0));

            selectedValueProducts = null;
            selectedValueProducts = new List<int>()
            {
                Products[0].IdProducto
            };


        }

        void OnProductsValuesChanged(IEnumerable<int> values)
        {
            selectedValueProducts = null;
            selectedValueProducts = new List<int>()
            {
               values.ElementAt(0)
            };

            Marks = null;
            Marks = markService.GetMarksByIdProduct(values.ElementAt(0));

            selectedValueMarks = null;
            selectedValueMarks = new List<int>()
            {
                Marks[0].IdMark
            };
        }

        void OnMarksValuesChanged(IEnumerable<int> values)
        {
            selectedValueMarks = null;
            selectedValueMarks = new List<int>()
            {
                values.ElementAt(0)
            };
            Sales = null;
            Sales = salesService.GetSalesByMark(values.ElementAt(0));

            for (var i = 0; i < Sales.Count; i++)
            {
                series[i] = Sales[i].Sale;
            }

            Series = new List<ChartSeries>()
        {
            new ChartSeries() { Name = "Ventas", Data = series }
        };
        }

    }
}
