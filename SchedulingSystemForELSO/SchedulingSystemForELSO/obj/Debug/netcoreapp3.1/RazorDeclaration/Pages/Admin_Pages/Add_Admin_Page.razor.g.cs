// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SchedulingSystemForELSO.Pages.Admin_Pages
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
#line 10 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

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
#line 3 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Admin_Pages\Add_Admin_Page.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Add_Admin_Page/{Admin_Username}")]
    public partial class Add_Admin_Page : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 185 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Admin_Pages\Add_Admin_Page.razor"
       
    [Parameter]
    public string Admin_Username { get; set; }
    AdminTable new_user = new AdminTable();
    LoginTable log_user = new LoginTable();
    protected async Task Add()
    {
        SchedulingSystemForELSOContext db = new SchedulingSystemForELSOContext();
        log_user.UserChoice = "Admin";
        log_user.Username = new_user.Username;
        log_user.Password = new_user.Password;
        db.LoginTable.Add(log_user);
        db.AdminTable.Add(new_user);
        db.SaveChanges();
        toastService.ShowSuccess("Admin has been added successfully.");
        navigationManager.NavigateTo("/Setting_Page/" + Admin_Username);
    }
    protected async Task Cancel()
    {
        navigationManager.NavigateTo("/Setting_Page/" + Admin_Username);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
    }
}
#pragma warning restore 1591
