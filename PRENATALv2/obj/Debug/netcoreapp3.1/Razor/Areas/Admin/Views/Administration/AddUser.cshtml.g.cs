#pragma checksum "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3725dda00a089d41d9ef33a18233cc1babc2cd94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Administration_AddUser), @"mvc.1.0.view", @"/Areas/Admin/Views/Administration/AddUser.cshtml")]
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
#line 1 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
using PRENATALv2.Areas.Home.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3725dda00a089d41d9ef33a18233cc1babc2cd94", @"/Areas/Admin/Views/Administration/AddUser.cshtml")]
    public class Areas_Admin_Views_Administration_AddUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Register>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
  
    ViewData["Title"] = "AddUser";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n\r\n        <h3><strong class=\"text-uppercase\">Add a new user:</strong></h3>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
         using (Html.BeginForm("SaveNewUser", "Administration", FormMethod.Post, new { @class = "form-group" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
                                    ;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <fieldset class=\"btn-group-vertical align-content-md-around\">\r\n                <label>Name:</label>\r\n                ");
#nullable restore
#line 21 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
           Write(Html.TextBoxFor(Model => Model.Name, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 22 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
           Write(Html.ValidationMessageFor(Model => Model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n                <label>Surname:</label>\r\n                ");
#nullable restore
#line 25 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
           Write(Html.TextBoxFor(Model => Model.Surname, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 26 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
           Write(Html.ValidationMessageFor(Model => Model.Surname, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n                <label>E-mail:</label>\r\n                ");
#nullable restore
#line 29 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
           Write(Html.TextBoxFor(Model => Model.Email, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 30 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
           Write(Html.ValidationMessageFor(Model => Model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n                <label>PhoneNumber:</label>\r\n                ");
#nullable restore
#line 33 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
           Write(Html.TextBoxFor(Model => Model.PhoneNumber, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 34 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
           Write(Html.ValidationMessageFor(Model => Model.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n                <label>Gender:</label>\r\n                ");
#nullable restore
#line 37 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
           Write(Html.DropDownListFor(model => model.Gender, new SelectList(Model.Gender_List, "Value", "Text"), "Choose:", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 38 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
           Write(Html.ValidationMessageFor(model => model.Gender, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n                <label>Account type:</label>\r\n                ");
#nullable restore
#line 41 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
           Write(Html.DropDownListFor(model => model.Type, new SelectList(Model.Type_List, "Value", "Text"), "Choose:",
               new { @Id = "Type", @onchange = "IsPatient();", @class = "form-control", style = "width:200px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                ");
#nullable restore
#line 43 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
           Write(Html.ValidationMessageFor(model => model.Type, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <div id=\"hidden_options\" hidden name=\"hidden_options\">\r\n                    <label>Doctor:</label>\r\n                    ");
#nullable restore
#line 47 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
               Write(Html.DropDownListFor(model => model.DoctorId, new SelectList(Model.Doctors, "Value", "Text"), "Choose account type:", new { @class = "form-control", style = "width:200px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 48 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
               Write(Html.ValidationMessageFor(model => model.DoctorId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <br />\r\n                <input type=\"submit\" class=\"btn btn-prenatal\" value=\"Create\" />\r\n            </fieldset>\r\n");
#nullable restore
#line 54 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Admin\Views\Administration\AddUser.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
<script>
    function IsPatient() {

        if ($('#Type').val() == ""3"") {
            $('#hidden_options').removeAttr('hidden');
        }
        else {
            $('#hidden_options').attr(""hidden"", true);

        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Register> Html { get; private set; }
    }
}
#pragma warning restore 1591
