#pragma checksum "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86a6261eb9b9836839b8cd3cd1e2cb5943aeaffe"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "html");
            __builder.AddAttribute(1, "lang", "en");
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.AddMarkupContent(3, @"<head>

    <link rel=""shortcut icon"" href=""img/favicon.png"">

    <title>Scheduling System ELSO| Arrange Time Slots</title>

    
    <link href=""css/bootstrap.min.css"" rel=""stylesheet"">
    
    <link href=""css/bootstrap-theme.css"" rel=""stylesheet"">
    
    
    <link href=""css/elegant-icons-style.css"" rel=""stylesheet"">
    <link href=""css/font-awesome.min.css"" rel=""stylesheet"">
    
    <link href=""css/style.css"" rel=""stylesheet"">
    <link href=""css/style-responsive.css"" rel=""stylesheet"">


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
#line 56 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                    Teacher_Username

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
            __builder.AddAttribute(41, "href", "/My_Profile_Teacher_Page/" + (
#nullable restore
#line 62 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                                   Teacher_Username

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
            __builder.AddAttribute(64, "href", "/Teacher_Home_Page/" + (
#nullable restore
#line 81 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                              Teacher_Username

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
            __builder.AddAttribute(74, "href", "/Arrange_Time_Slots_Page/" + (
#nullable restore
#line 88 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                                    Teacher_Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(75, "\r\n                            <i class=\"icon_piechart\"></i>\r\n                            ");
            __builder.AddMarkupContent(76, "<span>Create Meeting</span>\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                    ");
            __builder.OpenElement(79, "li");
            __builder.AddMarkupContent(80, "\r\n                        ");
            __builder.OpenElement(81, "a");
            __builder.AddAttribute(82, "class", true);
            __builder.AddAttribute(83, "href", "/Send_Annoucment_Page/" + (
#nullable restore
#line 96 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                                 Teacher_Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(84, "\r\n                            \r\n                            <i class=\"icon_piechart\"></i>\r\n                            ");
            __builder.AddMarkupContent(85, "<span>Send Annoucments</span>\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                    ");
            __builder.OpenElement(88, "li");
            __builder.AddMarkupContent(89, "\r\n                        ");
            __builder.OpenElement(90, "a");
            __builder.AddAttribute(91, "class", true);
            __builder.AddAttribute(92, "href", "/Received_Meeting_Requests/" + (
#nullable restore
#line 105 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                                      Teacher_Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(93, "\r\n                            <i class=\"icon_piechart\"></i>\r\n                            ");
            __builder.AddMarkupContent(94, "<span>Meeting Requests</span>\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                    ");
            __builder.OpenElement(97, "li");
            __builder.AddMarkupContent(98, "\r\n                        ");
            __builder.OpenElement(99, "a");
            __builder.AddAttribute(100, "class", true);
            __builder.AddAttribute(101, "href", "/My_Meeting_Teacher_Page/" + (
#nullable restore
#line 113 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                                    Teacher_Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(102, "\r\n                            <i class=\"icon_piechart\"></i>\r\n                            ");
            __builder.AddMarkupContent(103, "<span>My Meetings</span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                    ");
            __builder.OpenElement(106, "li");
            __builder.AddMarkupContent(107, "\r\n                        ");
            __builder.OpenElement(108, "a");
            __builder.AddAttribute(109, "class", true);
            __builder.AddAttribute(110, "href", "/Reschedule_Meetings_Page/" + (
#nullable restore
#line 119 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                                     Teacher_Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(111, "\r\n                            <i class=\"icon_piechart\"></i>\r\n                            ");
            __builder.AddMarkupContent(112, "<span>Reschedule Meetings</span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                    ");
            __builder.OpenElement(115, "li");
            __builder.AddMarkupContent(116, "\r\n                        ");
            __builder.OpenElement(117, "a");
            __builder.AddAttribute(118, "class", true);
            __builder.AddAttribute(119, "href", "/Cancel_Meeting_Page/" + (
#nullable restore
#line 125 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                                Teacher_Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(120, "\r\n                            <i class=\"icon_piechart\"></i>\r\n                            ");
            __builder.AddMarkupContent(121, "<span>Cancel Meetings</span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                    ");
            __builder.OpenElement(124, "li");
            __builder.AddAttribute(125, "class", true);
            __builder.AddMarkupContent(126, "\r\n                        ");
            __builder.OpenElement(127, "a");
            __builder.AddAttribute(128, "class", true);
            __builder.AddAttribute(129, "href", "/Notification_Page/" + (
#nullable restore
#line 131 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                              Teacher_Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(130, "\r\n                            ");
            __builder.AddMarkupContent(131, "<i><img src=\"icons/bell.png\"></i>\r\n                            ");
            __builder.AddMarkupContent(132, "<span>Notification</span>\r\n                            ");
            __builder.OpenElement(133, "span");
            __builder.AddAttribute(134, "class", "badge bg-important");
            __builder.AddContent(135, 
#nullable restore
#line 134 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                              notification_numbers

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n        \r\n        \r\n        ");
            __builder.OpenElement(142, "section");
            __builder.AddAttribute(143, "id", "main-content");
            __builder.AddMarkupContent(144, "\r\n            \r\n               ");
            __builder.AddMarkupContent(145, "<div><img src=\"../icons/im.jpg\" style=\"margin-top:100px; right:50%;top:50%; width:350px; height:430px; position:absolute\">\r\n            </div>\r\n            \r\n            ");
            __builder.OpenElement(146, "div");
            __builder.AddAttribute(147, "class", "loginBox");
            __builder.AddMarkupContent(148, "\r\n\r\n                ");
            __builder.AddMarkupContent(149, "<h2>Create Meeting</h2>\r\n                ");
            __builder.OpenElement(150, "form");
            __builder.AddMarkupContent(151, "\r\n                                                    \r\n                       ");
            __builder.AddMarkupContent(152, "<p>Start Time:</p>\r\n                        ");
            __builder.OpenElement(153, "div");
            __builder.AddMarkupContent(154, "\r\n                            ");
            __builder.OpenComponent<Syncfusion.Blazor.Calendars.SfDateTimePicker<DateTime>>(155);
            __builder.AddAttribute(156, "onselectionchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 155 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                                                                                           StateHasChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(157, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 155 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                                                                                                                      () => StateHasChanged()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(158, "Placeholder", "Select a date and time");
            __builder.AddAttribute(159, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DateTime>(
#nullable restore
#line 155 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                                              new_time_slot.StartTime

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(160, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<DateTime>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<DateTime>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => new_time_slot.StartTime = __value, new_time_slot.StartTime))));
            __builder.AddAttribute(161, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<DateTime>>>(() => new_time_slot.StartTime));
            __builder.CloseComponent();
            __builder.AddMarkupContent(162, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n                        ");
            __builder.AddMarkupContent(164, "<p> End Time:</p>\r\n                        ");
            __builder.OpenElement(165, "div");
            __builder.AddMarkupContent(166, "\r\n                            ");
            __builder.OpenComponent<Syncfusion.Blazor.Calendars.SfDateTimePicker<DateTime>>(167);
            __builder.AddAttribute(168, "onselectionchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 160 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                                                                                         StateHasChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(169, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 160 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                                                                                                                    () => StateHasChanged()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(170, "Placeholder", "Select a date and time");
            __builder.AddAttribute(171, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DateTime>(
#nullable restore
#line 160 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                                              new_time_slot.EndTime

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(172, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<DateTime>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<DateTime>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => new_time_slot.EndTime = __value, new_time_slot.EndTime))));
            __builder.AddAttribute(173, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<DateTime>>>(() => new_time_slot.EndTime));
            __builder.CloseComponent();
            __builder.AddMarkupContent(174, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n                        ");
            __builder.AddMarkupContent(176, "<p>Meeting Topic:</p>\r\n                        ");
            __builder.OpenElement(177, "div");
            __builder.AddMarkupContent(178, "\r\n                            ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(179);
            __builder.AddAttribute(180, "TValue", "string");
            __builder.AddAttribute(181, "Placeholder", "Write a Topic");
            __builder.AddAttribute(182, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 165 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                                     new_time_slot.MeetingTopic

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(183, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => new_time_slot.MeetingTopic = __value, new_time_slot.MeetingTopic))));
            __builder.AddAttribute(184, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => new_time_slot.MeetingTopic));
            __builder.CloseComponent();
            __builder.AddMarkupContent(185, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n                         ");
            __builder.OpenElement(187, "div");
            __builder.AddMarkupContent(188, "\r\n                             ");
            __builder.OpenElement(189, "button");
            __builder.AddAttribute(190, "type", "button");
            __builder.AddAttribute(191, "class", "btn btn-success mt-1");
            __builder.AddAttribute(192, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 168 "C:\Users\Shan\Desktop\Software Engineering\Project Docs\SchedulingSystemForELSO\SchedulingSystemForELSO\Pages\Teacher_Pages\Arranged_Time_Slots_Page.razor"
                                                                                          () => Add_Meeting()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(193, "Send Request");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n                         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(195, "\r\n           \r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(197, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(198, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\r\n\r\n\r\n");
            __builder.CloseElement();
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
