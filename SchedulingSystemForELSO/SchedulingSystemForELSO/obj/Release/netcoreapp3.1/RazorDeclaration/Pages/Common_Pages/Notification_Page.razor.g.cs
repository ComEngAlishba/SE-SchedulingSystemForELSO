// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SchedulingSystemForELSO.Pages.Common_Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\_Imports.razor"
using SchedulingSystemForELSO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\_Imports.razor"
using SchedulingSystemForELSO.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Common_Pages\Notification_Page.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Common_Pages\Notification_Page.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Common_Pages\Notification_Page.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Common_Pages\Notification_Page.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Notification_Page/{Username}")]
    public partial class Notification_Page : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Common_Pages\Notification_Page.razor"
       
    [Parameter]
    public string Username { get; set; }
    List<NotificationTable> notifications = new List<NotificationTable>();
    protected override async Task OnInitializedAsync()
    {
        SchedulingSystemForELSOContext db = new SchedulingSystemForELSOContext();
        notifications = db.NotificationTable.Where(m => m.Username == Username).ToList();
    }
    public void Delete(int id)
    {
        SchedulingSystemForELSOContext db = new SchedulingSystemForELSOContext();
        var n = db.NotificationTable.Where(m => m.Id == id).FirstOrDefault();
        db.NotificationTable.Remove(n);
        db.SaveChanges();
        OnInitializedAsync();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591