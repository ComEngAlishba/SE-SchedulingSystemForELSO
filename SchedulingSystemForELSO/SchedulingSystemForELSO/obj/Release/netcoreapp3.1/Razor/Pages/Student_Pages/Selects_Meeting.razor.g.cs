#pragma checksum "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2857064e932ec310fd0fbcc2661c73ee4adadbe3"
// <auto-generated/>
#pragma warning disable 1591
namespace SchedulingSystemForELSO.Pages.Student_Pages
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
#line 3 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Selects_Meeting_Page/{Student_Username}")]
    public partial class Selects_Meeting : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "html");
            __builder.AddAttribute(1, "lang", "en");
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.AddMarkupContent(3, @"<head>

    <link rel=""shortcut icon"" href=""img/favicon.png"">

    <title>Basic Table | Creative - Bootstrap 3 Responsive Admin Template</title>

    
    <link href=""css/bootstrap.min.css"" rel=""stylesheet"">
    
    <link href=""css/bootstrap-theme.css"" rel=""stylesheet"">
    
    
    <link href=""css/elegant-icons-style.css"" rel=""stylesheet"">
    <link href=""css/font-awesome.min.css"" rel=""stylesheet"">
    
    <link href=""css/style.css"" rel=""stylesheet"">
    <link href=""css/style-responsive.css"" rel=""stylesheet"">
    <title>Sceduling System for ELSO| Select Meeting </title>

</head>

");
            __builder.OpenElement(4, "body");
            __builder.AddMarkupContent(5, "\r\n    \r\n    ");
            __builder.OpenElement(6, "section");
            __builder.AddAttribute(7, "id", "container");
            __builder.AddAttribute(8, "class", true);
            __builder.AddMarkupContent(9, "\r\n        \r\n        ");
            __builder.OpenElement(10, "header");
            __builder.AddAttribute(11, "class", "header dark-heading-bg");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.AddMarkupContent(13, "<div class=\"toggle-nav\">\r\n                <div class=\"icon-reorder tooltips\" data-original-title=\"Toggle Navigation\" data-placement=\"bottom\"><img src=\"icons/task.png\"></div>\r\n            </div>\r\n\r\n            \r\n            ");
            __builder.AddMarkupContent(14, "<a href class=\"logo\"><b>Scheduling System <span class=\"lite\">ELSO</span></b></a>\r\n            \r\n\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "top-nav notification-row");
            __builder.AddMarkupContent(17, "\r\n                \r\n                ");
            __builder.OpenElement(18, "ul");
            __builder.AddAttribute(19, "class", "nav pull-right top-menu");
            __builder.AddMarkupContent(20, "\r\n\r\n                    \r\n                    ");
            __builder.OpenElement(21, "li");
            __builder.AddAttribute(22, "class", "dropdown");
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "data-toggle", "dropdown");
            __builder.AddAttribute(26, "href", "#");
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.AddMarkupContent(28, "<span class=\"profile-ava\">\r\n                                <img alt src=\"icons/user.png\">\r\n                            </span>\r\n                            ");
            __builder.OpenElement(29, "span");
            __builder.AddAttribute(30, "class", "username");
            __builder.AddContent(31, 
#nullable restore
#line 54 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                                    Student_Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                            <b class=\"caret\"></b>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "ul");
            __builder.AddAttribute(35, "class", "dropdown-menu extended logout");
            __builder.AddMarkupContent(36, "\r\n                            <div class=\"log-arrow-up\"></div>\r\n                            ");
            __builder.OpenElement(37, "li");
            __builder.AddAttribute(38, "class", "eborder-top");
            __builder.AddMarkupContent(39, "\r\n                                ");
            __builder.OpenElement(40, "a");
            __builder.AddAttribute(41, "href", "/My_Profile_Student_Page/" + (
#nullable restore
#line 60 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                                                   Student_Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "<i class=\"icon_profile\"></i> My Profile");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                            ");
            __builder.AddMarkupContent(45, "<li>\r\n                                <a href=\"/\"><i class=\"icon_key_alt\"></i> Log Out</a>\r\n                            </li>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    \r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        \r\n        \r\n        ");
            __builder.OpenElement(51, "aside");
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "id", "sidebar");
            __builder.AddAttribute(55, "class", "nav-collapse");
            __builder.AddMarkupContent(56, "\r\n                \r\n                ");
            __builder.OpenElement(57, "ul");
            __builder.AddAttribute(58, "class", "sidebar-menu");
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "li");
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.OpenElement(62, "a");
            __builder.AddAttribute(63, "class", true);
            __builder.AddAttribute(64, "href", "/Student_Home_Page/" + (
#nullable restore
#line 79 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                                              Student_Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(65, "\r\n                            \r\n                            <i class=\"icon_house_alt\"></i>\r\n                            ");
            __builder.AddMarkupContent(66, "<span>Home Page</span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.OpenElement(69, "li");
            __builder.AddAttribute(70, "class", "active");
            __builder.AddMarkupContent(71, "\r\n                        ");
            __builder.OpenElement(72, "a");
            __builder.AddAttribute(73, "class", true);
            __builder.AddAttribute(74, "href", "/Selects_Meeting_Page/" + (
#nullable restore
#line 86 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                                                 Student_Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(75, "\r\n                            <i class=\"icon_piechart\"></i>\r\n                            ");
            __builder.AddMarkupContent(76, "<span>Select a Meeting</span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                    ");
            __builder.OpenElement(79, "li");
            __builder.AddAttribute(80, "class", true);
            __builder.AddMarkupContent(81, "\r\n                        ");
            __builder.OpenElement(82, "a");
            __builder.AddAttribute(83, "class", true);
            __builder.AddAttribute(84, "href", "/My_Meeting_Student_Page/" + (
#nullable restore
#line 92 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                                                    Student_Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(85, "\r\n                            <i class=\"icon_piechart\"></i>\r\n                            ");
            __builder.AddMarkupContent(86, "<span>My Meetings</span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n        \r\n        \r\n        ");
            __builder.OpenElement(92, "section");
            __builder.AddAttribute(93, "id", "main-content");
            __builder.AddMarkupContent(94, "\r\n            ");
            __builder.OpenElement(95, "section");
            __builder.AddAttribute(96, "class", "wrapper");
            __builder.AddMarkupContent(97, "\r\n                ");
            __builder.AddMarkupContent(98, "<header>\r\n                    <h1 class=\"text-center pr-5\">\r\n                        Select Meeting\r\n                    </h1>\r\n                </header>\r\n                ");
            __Blazor.SchedulingSystemForELSO.Pages.Student_Pages.Selects_Meeting.TypeInference.CreateSfGrid_0(__builder, 99, 100, 
#nullable restore
#line 110 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                     timeslots

#line default
#line hidden
#nullable disable
            , 101, (__builder2) => {
                __builder2.AddMarkupContent(102, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<TimeSlotsTable>>(103);
                __builder2.AddAttribute(104, "RowDataBound", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Grids.RowDataBoundEventArgs<TimeSlotsTable>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Grids.RowDataBoundEventArgs<TimeSlotsTable>>(this, 
#nullable restore
#line 111 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                                                      CustomizedCell

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(106);
                __builder2.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(108, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(109);
                    __builder3.AddAttribute(110, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 113 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                           nameof(TimeSlotsTable.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(111, "HeaderText", "Meeting Id");
                    __builder3.AddAttribute(112, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 113 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                                                                                        Syncfusion.Blazor.Grids.TextAlign.Left

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(113, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(114, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(115);
                    __builder3.AddAttribute(116, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 114 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                           nameof(TimeSlotsTable.MeetingTopic)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(117, "HeaderText", "Meeting Topic");
                    __builder3.AddAttribute(118, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 114 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                                                                                                     Syncfusion.Blazor.Grids.TextAlign.Left

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(119, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(120, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(121);
                    __builder3.AddAttribute(122, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 115 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                           nameof(TimeSlotsTable.StartTime)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(123, "HeaderText", "Start Time");
                    __builder3.AddAttribute(124, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 115 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                                                                                               Syncfusion.Blazor.Grids.TextAlign.Left

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(125, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(126, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(127);
                    __builder3.AddAttribute(128, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 116 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                           nameof(TimeSlotsTable.EndTime)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(129, "HeaderText", "End Time");
                    __builder3.AddAttribute(130, "Width", "150");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(131, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(132);
                    __builder3.AddAttribute(133, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 117 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                           nameof(TimeSlotsTable.TeacherUsername)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(134, "HeaderText", "Teacher Name");
                    __builder3.AddAttribute(135, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 117 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                                                                                                       Syncfusion.Blazor.Grids.TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(136, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(137, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(138);
                    __builder3.AddAttribute(139, "HeaderText", "Meetings");
                    __builder3.AddAttribute(140, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 118 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                                                     Syncfusion.Blazor.Grids.TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(141, "Width", "120");
                    __builder3.AddAttribute(142, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(143, "\r\n");
#nullable restore
#line 120 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                  
                                    var m = (context as TimeSlotsTable);

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(144, "                                    ");
                        __builder4.OpenElement(145, "a");
                        __builder4.AddAttribute(146, "class", "btn btn-success");
                        __builder4.AddAttribute(147, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 122 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
                                                                         () => View_Meeting(m.Id)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(148, "View");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(149, "\r\n");
                        __builder4.AddContent(150, "                            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(151, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(152, "\r\n                ");
            }
            );
            __builder.AddMarkupContent(153, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n        \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n    \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 137 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Student_Pages\Selects_Meeting.razor"
       
    [Parameter]
    public string Student_Username { get; set; }
    TimeSlotsTable m = new TimeSlotsTable();
    List<TimeSlotsTable> timeslots;

    protected override async Task OnInitializedAsync()
    {
        SchedulingSystemForELSOContext db = new SchedulingSystemForELSOContext();
        timeslots = db.TimeSlotsTable.Where(t => t.Request == true).ToList();
        for (int i = 0; i < timeslots.Count; i++)
        {
            timeslots[i].TeacherUsername = db.TeacherTable.Where(t => t.Username == timeslots[i].TeacherUsername).FirstOrDefault().FullName;
        }
    }

    void View_Meeting(int id)
    {
        var url = "/View_Meeting/" + id.ToString() + "/" + Student_Username;
        navigationManager.NavigateTo(url);
    }
    public void CustomizedCell(RowDataBoundEventArgs<TimeSlotsTable> args)
    {
        SchedulingSystemForELSOContext db = new SchedulingSystemForELSOContext();
        string color = db.TeacherTable.Where(p => p.FullName == args.Data.TeacherUsername).FirstOrDefault().Color;
        args.Row.AddStyle(new string[] { "background-color:" + color + ";" });

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
namespace __Blazor.SchedulingSystemForELSO.Pages.Student_Pages.Selects_Meeting
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
