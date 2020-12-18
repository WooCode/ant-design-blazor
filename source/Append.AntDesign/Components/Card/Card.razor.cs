﻿using System.Collections.Generic;
using Append.AntDesign.Core;
using Microsoft.AspNetCore.Components;

namespace Append.AntDesign.Components
{
    public partial class Card
    {
        private static readonly string prefix = "ant-card";

        private ClassBuilder Classes => ClassBuilder.Create(Class)
            .AddClass(prefix)
            .AddClassWhen($"{prefix}-bordered", Bordered)
            .AddClassWhen($"{prefix}-hoverable", Hoverable)
            .AddClassWhen($"{prefix}-loading", Loading)
            .AddClassWhen($"{prefix}-type-inner", Type == CardType.Inner)
            .AddClassWhen($"{prefix}-{Type}", Type == CardType.Small)
            .AddClassWhen($"{prefix}-contain-tabs", TabList.Count > 0);

        [Parameter] public bool Bordered { get; set; } = true;
        [Parameter] public string Title { get; set; }
        [Parameter] public bool Loading { get; set; }
        [Parameter] public bool Hoverable { get; set; }
        [Parameter] public CardType Type { get; set; }

        [Parameter] public string HeadStyle { get; set; }
        [Parameter] public string BodyStyle { get; set; }

        [Parameter] public string ActiveTabKey { get; set; }
        [Parameter] public string DefaultActiveTabKey { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public RenderFragment Extra { get; set; }
        [Parameter] public RenderFragment Cover { get; set; }

        [Parameter] public List<RenderFragment> Actions { get; set; } = new List<RenderFragment>();
        [Parameter] public List<CardTab> TabList { get; set; } = new List<CardTab>();
    }
}