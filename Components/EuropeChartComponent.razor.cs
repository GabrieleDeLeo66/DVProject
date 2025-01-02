

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace DVProject.Components
{
    public partial class EuropeChartComponent
    {
        private DateTime? _date = DateTime.Parse("2022-02-17");
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            if (firstRender)
            {
                await JS.InvokeVoidAsync("MapEurope", _date?.ToString("yyyy-MM-dd"));
            }
        }

        //public DateTime? Date
        //{
        //    get { return _date; }
        //    set 
        //    { 
        //        _date = value;
        //        var valueString = value?.ToString("yyyy-MM-dd");
        //        JS.InvokeVoidAsync("UpdateEurope", valueString);
        //    }
        //}


        public async Task OnDateChanged(DateTime? value)
        {
            _date = value;
            var valueString = value?.ToString("yyyy-MM-dd");
            //await JS.InvokeVoidAsync("MapEurope", valueString);
            await JS.InvokeVoidAsync("UpdateEurope", valueString);
        }
    }
}
