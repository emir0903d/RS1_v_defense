#pragma checksum "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44cbea1afc92e31b211c4666f43c896abea1f6f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Administration_ShowUsers), @"mvc.1.0.view", @"/Areas/Admin/Views/Administration/ShowUsers.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
using PRENATALv2.Areas.Home.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44cbea1afc92e31b211c4666f43c896abea1f6f9", @"/Areas/Admin/Views/Administration/ShowUsers.cshtml")]
    public class Areas_Admin_Views_Administration_ShowUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
  
    ViewData["Title"] = "ShowUsers";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.min.css"" />

<div class=""container"">
    <div class=""text-left"" style=""vertical-align:middle;"">
        <a href=""/Admin/Administration/AddUser"" style=""vertical-align:middle; font-size:20px;"" class=""btn fas fa-plus-square d-inline a_icon""></a>

        <h5 style=""vertical-align:middle;"" class=""d-inline""><strong class=""text-uppercase"">All users:</strong></h5>
    </div>


    <table class=""table"">
        <tr><th>Id</th><th>Name</th><th>Surname</th><th>UserName</th><th>E-mail</th><th>Confirmed?</th><th>PhoneNumber</th><th>Confirmed?</th><th>Status</th><th>Type</th><th>Actions</th></tr>
");
#nullable restore
#line 22 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
         foreach (AppUser x in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
               Write(x.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
               Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
               Write(x.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
               Write(x.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
               Write(x.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
               Write(x.EmailConfirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
               Write(x.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
               Write(x.PhoneNumberConfirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
               Write(x.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a class=\"far fa-thumbs-up a_icon\"");
            BeginWriteAttribute("href", " href=\"", 1304, "\"", 1359, 2);
            WriteAttributeValue("", 1311, "/Admin/Administration/ApproveReject?UserId=", 1311, 43, true);
#nullable restore
#line 33 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
WriteAttributeValue("", 1354, x.Id, 1354, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a></td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
               Write(x.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1428, "\"", 1456, 2);
            WriteAttributeValue("", 1435, "EditUser?UserId=", 1435, 16, true);
#nullable restore
#line 35 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
WriteAttributeValue("", 1451, x.Id, 1451, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-edit a_icon\"></a> <a");
            BeginWriteAttribute("href", " href=\"", 1492, "\"", 1522, 2);
            WriteAttributeValue("", 1499, "DeleteUser?UserId=", 1499, 18, true);
#nullable restore
#line 35 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
WriteAttributeValue("", 1517, x.Id, 1517, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-trash-alt a_icon\"></a></td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\ShowUsers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
