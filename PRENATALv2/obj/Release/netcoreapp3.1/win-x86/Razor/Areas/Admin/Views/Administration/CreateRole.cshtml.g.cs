#pragma checksum "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\CreateRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bb21380963e3d0be6fee94dc75f5af314c9fe15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Administration_CreateRole), @"mvc.1.0.view", @"/Areas/Admin/Views/Administration/CreateRole.cshtml")]
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
#line 1 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\CreateRole.cshtml"
using PRENATALv2.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bb21380963e3d0be6fee94dc75f5af314c9fe15", @"/Areas/Admin/Views/Administration/CreateRole.cshtml")]
    public class Areas_Admin_Views_Administration_CreateRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateRole>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\CreateRole.cshtml"
  
    ViewData["Title"] = "CreateRole";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\CreateRole.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create a new role:</h1>\r\n\r\n<div class=\"container\">\r\n");
#nullable restore
#line 13 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\CreateRole.cshtml"
     using (Html.BeginForm("AttemptCreateRole", "Administration", FormMethod.Post, new { @class = "form-group" }))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\CreateRole.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\CreateRole.cshtml"
                                ;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <fieldset class=\"btn-group-vertical align-content-md-around\">\r\n            <label>Role name:</label>\r\n            ");
#nullable restore
#line 18 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\CreateRole.cshtml"
       Write(Html.TextBoxFor(model => model.RoleName, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 19 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\CreateRole.cshtml"
       Write(Html.ValidationMessageFor(model => model.RoleName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            <button type=\"submit\" class=\"btn btn-prenatal\">Create</button>\r\n        </fieldset>\r\n");
#nullable restore
#line 22 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\CreateRole.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateRole> Html { get; private set; }
    }
}
#pragma warning restore 1591
