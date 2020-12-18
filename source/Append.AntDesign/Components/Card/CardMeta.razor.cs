using Microsoft.AspNetCore.Components;

namespace Append.AntDesign.Components
{
   public partial class CardMeta
    {
        [Parameter] public string Title { get; set; }
        [Parameter] public string Description { get; set; }

        [Parameter] public RenderFragment Avatar { get; set; }
    }
}
