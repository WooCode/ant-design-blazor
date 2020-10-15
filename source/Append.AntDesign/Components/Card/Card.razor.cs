using System;
using Append.AntDesign.Core;
using Microsoft.AspNetCore.Components;

namespace Append.AntDesign.Components
{
    public partial class Card
    {
        private static readonly string prefix = "ant-card";

        private ClassBuilder Classes => ClassBuilder.Create(Class)
            .AddClass(prefix)
            .AddClassWhen($"{prefix}-bordered", Bordered);

        [Parameter] public bool Bordered { get; set; }
        [Parameter] public bool Loading { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }

        [Parameter] public string HeadStyle { get; set; }
        [Parameter] public string BodyStyle { get; set; }
    }
}
