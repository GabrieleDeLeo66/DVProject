using Microsoft.JSInterop;

namespace DVProject.Components
{
    public partial class FocusOnChartComponent
    {
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            if (firstRender)
            {
                await JS.InvokeVoidAsync("CreateChart");
            }
        }
    }
}
