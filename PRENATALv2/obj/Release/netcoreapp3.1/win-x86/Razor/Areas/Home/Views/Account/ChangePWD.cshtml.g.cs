#pragma checksum "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\ChangePWD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "710e37c1ad8813e1530cbe8a372849615358cc58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Home_Views_Account_ChangePWD), @"mvc.1.0.view", @"/Areas/Home/Views/Account/ChangePWD.cshtml")]
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
#line 1 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\ChangePWD.cshtml"
using PRENATALv2.Areas.Home.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"710e37c1ad8813e1530cbe8a372849615358cc58", @"/Areas/Home/Views/Account/ChangePWD.cshtml")]
    public class Areas_Home_Views_Account_ChangePWD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_changePwd>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\ChangePWD.cshtml"
  
    Layout = "_Anonymous";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div style=\"width:400px; padding:20px 20px 20px 20px;\" class=\"container text-center\">\r\n        <p><strong>1)Lenght:8char MIN.; 2)1Upper; 3)1lower; 4)1Digit;</strong></p>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\ChangePWD.cshtml"
         using (Html.BeginForm("AttemptChangePwd", "Account", FormMethod.Post, new { @class = "form-group d-inline-block", @style = "width:550px;" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\ChangePWD.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\ChangePWD.cshtml"
                                    ;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <fieldset style=\"width:550px;\" class=\"btn-group-vertical\">\r\n                ");
#nullable restore
#line 14 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\ChangePWD.cshtml"
           Write(Html.HiddenFor(Model => Model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"d-inline-flex\">\r\n                    <label class=\"form-control d-inline-flex\" style=\"width:200px;\">Current password</label>\r\n                    ");
#nullable restore
#line 17 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\ChangePWD.cshtml"
               Write(Html.TextBoxFor(Model => Model._currentPassword, "", new { @style = "width:200px;", @class = "form-control d-inline-flex", type = "Password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 18 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\ChangePWD.cshtml"
               Write(Html.ValidationMessageFor(Model => Model._currentPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"d-inline-flex\">\r\n                    <label class=\"form-control d-inline-flex\" style=\"width:200px;\">New password</label>\r\n                    ");
#nullable restore
#line 23 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\ChangePWD.cshtml"
               Write(Html.TextBoxFor(Model => Model._newPassword, "", new { @Id = "_new", @onchange = "EnableConfirmation();", @class = "form-control d-inline-flex", @style = "width:200px;", type = "Password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 24 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\ChangePWD.cshtml"
               Write(Html.ValidationMessageFor(Model => Model._newPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <br />\r\n                <div class=\"d-inline-flex\">\r\n                    <label class=\"form-control d-inline-flex\" style=\"width:200px;\">Confirm password</label>\r\n                    ");
#nullable restore
#line 29 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\ChangePWD.cshtml"
               Write(Html.TextBoxFor(Model => Model._confirmPassword, "", new { @Id = "_confirm", @onchange = "EnableSubmit();", @class = "form-control d-inline-flex", @style = "width:200px;", @disabled = "disabled", type = "Password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 30 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\ChangePWD.cshtml"
               Write(Html.ValidationMessageFor(Model => Model._confirmPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <br />
                <div class=""d-inline-flex"">
                    <input style=""width:400px;"" id=""_sub"" type=""submit"" class=""btn btn-prenatal"" disabled />
                </div>

            </fieldset>
");
#nullable restore
#line 38 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\ChangePWD.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
<script>
    function EnableSubmit() {
        if ($('#_confirm').val() == """") {

            $('#_sub').attr('disabled', 'disabled');
        }

        if ($('#_confirm').val() != """") {

            $('#_sub').removeAttr('disabled');
        }

    }
    function EnableConfirmation() {
        if ($('#_new').val() == """") {

            $('#_confirm').attr('disabled', 'disabled');
        }

        if ($('#_new').val() != """") {

            $('#_confirm').removeAttr('disabled');
        }

    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_changePwd> Html { get; private set; }
    }
}
#pragma warning restore 1591
