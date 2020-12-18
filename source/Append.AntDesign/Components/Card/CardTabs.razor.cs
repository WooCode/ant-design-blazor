using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Append.AntDesign.Components
{
   public partial class CardTabs
    {
        [Parameter] public string ActiveTabKey { get; set; }
        [Parameter] public string DefaultActiveTabKey { get; set; }

        [Parameter] public List<CardTab> TabList { get; set; } = new List<CardTab>();
    }
}
