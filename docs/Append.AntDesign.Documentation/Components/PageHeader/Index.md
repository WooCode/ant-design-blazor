A header with common actions and design elements built in.

## When To Use

PageHeader can be used to highlight the page topic, display important information about the page, and carry the action items related to the current page (including page-level operations, inter-page navigation, etc.) It can also be used as inter-page navigation.

## API

| Param | Description | Type | Default value | Version |
| --- | --- | --- | --- | --- |
| Title | Custom title text | RenderFragment | - |  |
| SubTitle | Custom subtitle text | RenderFragment | - |  |
| Ghost | PageHeader type, will change background color | bool | true |  |
| Avatar | Avatar next to the title bar | [Avatar](/components/avatar/) | - |  |
| BackIcon | Custom back icon, if false the back icon will not be displayed | RenderFragment \| bool | `<ArrowLeft />` |  |
| Tags | Tag list next to title | [Tag](/components/tag/)[] \| [Tag](/components/tag/) | - |  |
| Extra | Operating area, at the end of the line of the title line | RenderFragment | - |  |
| Breadcrumb | Breadcrumb configuration | [Breadcrumb](/components/breadcrumb/) | - |  |
| Footer | PageHeader's footer, generally used to render TabBar | RenderFragment | - |  |
| OnBack | Back icon click event | `()=>void` | `()=>history.back()` |  |