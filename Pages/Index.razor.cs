﻿

namespace DVProject.Pages
{
    public partial class Index
    {
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
                await base.OnAfterRenderAsync(firstRender);
        }
    }
}