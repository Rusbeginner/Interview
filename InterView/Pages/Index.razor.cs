using InterView.Data;
using InterView.IService;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.DataProtection.Repositories;
using MudBlazor;

namespace InterView.Pages
{
    public partial class Index
    {

        public List<ChartSeries> Series = new List<ChartSeries>()
    {
        new ChartSeries() { Name = "Ventas", Data = new double[] { 100, 254, 25, 27 } }
    };
        public string[] XAxisLabels = { "January", "February", "March", "April" };
    }
}
