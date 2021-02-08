// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SchedulingSystemForELSO.Pages.Teacher_Pages
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
#line 3 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Arrange_Time_Slots_Page/{Teacher_Username}")]
    public partial class Arranged_Time_Slots_Page : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 182 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
       
    [Parameter]
    public string Teacher_Username { get; set; }
    TimeSlotsTable new_time_slot = new TimeSlotsTable();
    public int notification_numbers { get; set; }
    protected override async Task OnInitializedAsync()
    {
        SchedulingSystemForELSOContext db = new SchedulingSystemForELSOContext();
        notification_numbers = db.NotificationTable.Where(t => t.Username == Teacher_Username).ToList().Count;
        new_time_slot.StartTime = DateTime.Now;
        new_time_slot.EndTime = DateTime.Now;
    }
    protected async Task Add_Meeting()
    {

        if (new_time_slot.StartTime > DateTime.Now)
        {
            if (new_time_slot.StartTime.DayOfWeek.ToString() == "Monday" || new_time_slot.StartTime.DayOfWeek.ToString() == "Tuesday" || new_time_slot.StartTime.DayOfWeek.ToString() == "Wednesday" || new_time_slot.StartTime.DayOfWeek.ToString() == "Thursday" || new_time_slot.StartTime.DayOfWeek.ToString() == "Friday")
            {
                if (new_time_slot.StartTime.Date == new_time_slot.EndTime.Date)
                {

                    new_time_slot.StartTime = Convert.ToDateTime(new_time_slot.StartTime.ToString("MM/dd/yyyy HH:mm:ss tt"));//24 hours format
                    new_time_slot.EndTime = Convert.ToDateTime(new_time_slot.EndTime.ToString("MM/dd/yyyy HH:mm:ss tt"));//24 hours format
                    if (new_time_slot.StartTime.Hour >= 8 && new_time_slot.StartTime.Hour <= 16)
                    {
                        if (new_time_slot.EndTime.Hour >= 8 && new_time_slot.EndTime.Hour <= 16)
                        {
                            new_time_slot.StartTime = Convert.ToDateTime(new_time_slot.StartTime.ToString("MM/dd/yyyy hh:mm:ss tt"));//12 hours format
                            new_time_slot.EndTime = Convert.ToDateTime(new_time_slot.EndTime.ToString("MM/dd/yyyy hh:mm:ss tt"));//12 hours format
                            if (new_time_slot.StartTime < new_time_slot.EndTime)
                            {
                                SchedulingSystemForELSOContext db = new SchedulingSystemForELSOContext();
                                NotificationTable n = new NotificationTable();
                                n.Username = "Admin";
                                n.NotiMessage = "You have a  Request for Creating a Meeting " + new_time_slot.MeetingTopic + " from teacher : " + Teacher_Username + " .";
                                db.NotificationTable.Add(n);
                                new_time_slot.TeacherUsername = Teacher_Username;
                                new_time_slot.Request = false;
                                db.TimeSlotsTable.Add(new_time_slot);
                                db.SaveChanges();
                                toastService.ShowSuccess("Your Request has been Sent Successfully");
                                navigationManager.NavigateTo("/Teacher_Home_Page/" + Teacher_Username);
                            }
                            else
                            {
                                toastService.ShowError("Start Time must be less than End time...");
                            }
                        }
                        else
                        {
                            toastService.ShowError("End Time must be in between 8 am  and 4 pm ....");
                        }
                    }
                    else
                    {
                        toastService.ShowError("Start Time must be in between 8 am  and 4 pm....");
                    }

                }
                else
                {
                    toastService.ShowError("Date of start and end time must be equal...");
                }
            }
            else
            {
                toastService.ShowError("The day must be in between the Monday and Friday....");
            }
        }
        else
        {
            toastService.ShowError("Date must be greater than the Current Time...");
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