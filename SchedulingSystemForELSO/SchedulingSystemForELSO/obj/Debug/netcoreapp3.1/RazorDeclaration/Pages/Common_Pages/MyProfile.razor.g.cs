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
#line 3 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Common_Pages\MyProfile.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/MyProfile/{Username}")]
    public partial class MyProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Common_Pages\MyProfile.razor"
       
    [Parameter]
    public string Username { get; set; }
    RegisterTable view_user = new RegisterTable();
    LoginTable user = new LoginTable();
    protected override async Task OnInitializedAsync()
    {
        SchedulingSystemForELSOContext db = new SchedulingSystemForELSOContext();
        user = db.LoginTable.Where(x => x.Username == Username).FirstOrDefault();
        if(user.UserChoice== "Student")
        {
            view_user = db.RegisterTable.Where(x => x.Username == Username).FirstOrDefault();
            view_user.Password = EncryptionDecryption.Decrypt(view_user.Password);
        }
        else if(user.UserChoice == "Teacher")
        {
            var temp_User = db.TeacherTable.Where(x => x.Username == Username).FirstOrDefault();
            view_user.Username = temp_User.Username;
            view_user.Password = temp_User.Username;
            view_user.FullName = temp_User.FullName;
            view_user.Email = temp_User.Email;
            view_user.ContactNumber = temp_User.ContactNumber;
        }
        else if(user.UserChoice == "Admin")
        {
            var temp_User = db.AdminTable.Where(x => x.Username == Username).FirstOrDefault();
            view_user.Username = temp_User.Username;
            view_user.Password = temp_User.Username;
            view_user.FullName = temp_User.FullName;
            view_user.Email = temp_User.Email;
            view_user.ContactNumber = temp_User.ContactNumber;
        }

    }
    void Back()
    {
        if (user.UserChoice == "Student")
        {
            navigationManager.NavigateTo("/Student_Home_Page/" + user.Username);
        }
        else if (user.UserChoice == "Teacher")
        {
            navigationManager.NavigateTo("/Teacher_Home_Page/" + user.Username);
        }
        else if (user.UserChoice == "Admin")
        {
            navigationManager.NavigateTo("/Admin_Home_Page/" + user.Username);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
