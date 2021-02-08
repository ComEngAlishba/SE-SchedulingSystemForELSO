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
#line 3 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Admin_Pages\Recieved_Request_Admin_Page.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Admin_Pages\Recieved_Request_Admin_Page.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Admin_Pages\Recieved_Request_Admin_Page.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Admin_Pages\Recieved_Request_Admin_Page.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Recieved_Request_Admin_Page/{Admin_Username}")]
    public partial class Recieved_Request_Admin_Page : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 174 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Admin_Pages\Recieved_Request_Admin_Page.razor"
       
    [Parameter]
    public string Admin_Username { get; set; }
    public int notification_numbers_Create { get; set; } = 0;
    public int notification_numbers_Delete { get; set; } = 0;
    public int notification_numbers_Reschedule { get; set; } = 0;
    List<TimeSlotsTable> meetings;
    protected override async Task OnInitializedAsync()
    {
        SchedulingSystemForELSOContext db = new SchedulingSystemForELSOContext();
        meetings = db.TimeSlotsTable.Where(t => t.Request == false).ToList();
        var notifications = db.NotificationTable.Where(n => n.Username == Admin_Username).ToList();
        for(int i=0; i<notifications.Count; i++)
        {
            if(notifications[i].NotiMessage.Contains("Creating"))
            {
                notification_numbers_Create++;
            }
            else if(notifications[i].NotiMessage.Contains("Rescheduling"))
            {
                notification_numbers_Reschedule++;
            }
            else if(notifications[i].NotiMessage.Contains("Cancelling"))
            {
                notification_numbers_Delete++;
            }
        }
    }

    void Accept_Meeting_Request(int id)
    {
        toastService.ShowInfo("Please wait for a few seconds.");
        SchedulingSystemForELSOContext db = new SchedulingSystemForELSOContext();
        var meeting = db.TimeSlotsTable.Where(t => t.Id == id).FirstOrDefault();
        var notifications = db.NotificationTable.Where(n => n.Username == Admin_Username).ToList();
        for (int j = 0; j < notifications.Count; j++)
        {
            if (notifications[j].NotiMessage.Contains(meeting.TeacherUsername) && notifications[j].NotiMessage.Contains("Creating"))
            {
                db.Remove(notifications[j]);
                db.SaveChanges();
                break;
            }
        }
        NotificationTable n = new NotificationTable();
        n.Username = meeting.TeacherUsername;
        n.NotiMessage = "Your Request for Meeting " + meeting.MeetingTopic + " has been Accepted.";
        string email = db.TeacherTable.Where(t => t.Username == meeting.TeacherUsername).FirstOrDefault().Email;
        using (MailMessage mail = new MailMessage())
        {
            mail.From = new MailAddress("schedulingelso@gmail.com");
            mail.To.Add(email);
            mail.Subject = "ELSO Annoucment";
            mail.Body = n.NotiMessage;
            mail.IsBodyHtml = true;

            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("schedulingelso@gmail.com", "soft5150.");
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
        }
        db.NotificationTable.Add(n);
        meeting.Request = true;
        db.SaveChanges();
        toastService.ShowSuccess("Request has been accepted successfully...");
        OnInitializedAsync();
    }
    void Delete_Meeting_Request(int id)
    {
        toastService.ShowInfo("Please wait for a few seconds.");
        SchedulingSystemForELSOContext db = new SchedulingSystemForELSOContext();
        var meeting = db.TimeSlotsTable.Where(t => t.Id == id).FirstOrDefault();
        var notifications = db.NotificationTable.Where(n => n.Username == Admin_Username).ToList();
        for (int j = 0; j < notifications.Count; j++)
        {
            if (notifications[j].NotiMessage.Contains(meeting.TeacherUsername) && notifications[j].NotiMessage.Contains("Creating"))
            {
                db.Remove(notifications[j]);
                db.SaveChanges();
                break;
            }
        }
        NotificationTable n = new NotificationTable();
        n.Username = meeting.TeacherUsername;
        n.NotiMessage = "Your Request for Meeting " + meeting.MeetingTopic + " has been Rejected.";
        string email = db.TeacherTable.Where(t => t.Username == meeting.TeacherUsername).FirstOrDefault().Email;
        using (MailMessage mail = new MailMessage())
        {
            mail.From = new MailAddress("schedulingelso@gmail.com");
            mail.To.Add(email);
            mail.Subject = "ELSO Annoucment";
            mail.Body = n.NotiMessage;
            mail.IsBodyHtml = true;

            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("schedulingelso@gmail.com", "soft5150.");
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
        }
        db.NotificationTable.Add(n);
        db.TimeSlotsTable.Remove(meeting);
        db.SaveChanges();
        toastService.ShowSuccess("Request has been deleted successfully...");
        OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591