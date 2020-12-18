
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Append.AntDesign.Components
{
    public class CardTab : AntComponent
    {
        [Parameter] public EventCallback<MouseEventArgs> OnClick { get; set; }

        public string Key { get; set; }
        public string Tab { get; set; }
    }
}
