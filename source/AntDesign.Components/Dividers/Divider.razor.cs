﻿using Append.AntDesign.Core;
using Microsoft.AspNetCore.Components;
using System;

namespace Append.AntDesign.Components
{
    public partial class Divider
    {
        [Parameter] public DividerDirection Direction { get; set; } = DividerDirection.Horizontal;
        [Parameter] public DividerOrientation Orientation { get; set; } = DividerOrientation.Center;
        [Parameter] public bool Dashed { get; set; }
        [Parameter] public string Label { get; set; }
        private const string dividerPrefix = "ant-divider";
        /// <summary>
        /// The actual css classes, combining Ant Design classes with the classes of the client.
        /// </summary>
        private string classes =>
            dividerPrefix
            .AddClassWhen($"{dividerPrefix}-{Direction}",true)
            .AddClassWhen($"{dividerPrefix}-with-text-{Orientation}",!string.IsNullOrWhiteSpace(Label))
            .AddClassWhen($"{dividerPrefix}-dashed",Dashed)
            + Class;
    }
}
