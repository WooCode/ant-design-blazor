using Append.AntDesign.Core;
using Microsoft.AspNetCore.Components;

namespace Append.AntDesign.Components
{
   public partial class CardGrid
    {
        private static readonly string prefix = "ant-card-grid";

        private ClassBuilder classes => ClassBuilder.Create(Class)
            .AddClass(prefix)
            .AddClassWhen($"{prefix}-hoverable", Hoverable);

        private StyleBuilder styles => StyleBuilder.Create(Style);

        [Parameter] public bool Hoverable { get; set; } = true;

        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
