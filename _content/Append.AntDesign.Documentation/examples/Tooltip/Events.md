﻿<Codebox Title="Events" id="components-tooltip-demo-events">
    <Description>
        <p>
            You can listen to the <code>VisibleChanged</code> event, whenever the visibility is changed.
        </p>
    </Description>
    <Demo>
        <p>Is Visible: @visibility</p>
        <Tooltip VisibleChanged="HandleVisibilityChanged"
                 Placement="TooltipPlacement.Bottom"
                 Triggers="@(new[] { TooltipTrigger.Click})">
            <Title>prompt text</Title>
            <ChildContent>
                <Button Label="Click me!" Type="ButtonType.Dashed" />
            </ChildContent>
        </Tooltip>
    </Demo>
</Codebox>

@code{
    bool visibility = false;
    public void HandleVisibilityChanged(bool isVisible)
    {
        visibility = isVisible;
    }

}
