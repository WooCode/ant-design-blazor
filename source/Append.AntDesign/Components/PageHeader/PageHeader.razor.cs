using Append.AntDesign.Core;
using Append.AntDesign.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Append.AntDesign.Components
{
    public partial class PageHeader
    {

        private static string prefix = "ant-page-header";

        private ClassBuilder classes => ClassBuilder.Create(Class)
                .AddClass(prefix)
                .AddClassWhen("has-breadcrum", Breadcrumb != null)
                .AddClassWhen("has-footer", Footer != null)
                .AddClassWhen($"{prefix}-ghost", Ghost)
                .AddClassWhen($"{prefix}-compact", compact);

        [Inject] public IWindowService WindowService { get; set; }
        [Parameter] public RenderFragment<Avatar> Avatar { get; set; }
        [Parameter] public RenderFragment BackIcon { get; set; }
        [Parameter] public Breadcrumb Breadcrumb { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public RenderFragment Extra { get; set; }
        [Parameter] public RenderFragment Footer { get; set; }
        [Parameter] public bool Ghost { get; set; } = true;
        //give OnBack the previous visitted website as default
        [Parameter] public EventCallback OnBack { get; set; }
        [Parameter] public RenderFragment SubTitle { get; set; }
        [Parameter] public RenderFragment<Tag> Tags {get; set; }
        [Parameter] public RenderFragment Title { get; set; }

        private bool compact { get; set; }
        private void UpdateCompact(int windowWidth)
        {
            compact = windowWidth < BreakpointType.Md.Width;
            StateHasChanged();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            if (firstRender)
            {
                var dimensions = await WindowService.GetDimensions();
                await WindowService.RegisterOnWindowResizeHandler(this);
                UpdateCompact(dimensions.Width);
            }
        }

        [JSInvokable]
        public void OnWindowResize(int windowWidth)
        {
            UpdateCompact(windowWidth);
        }
    }
}
