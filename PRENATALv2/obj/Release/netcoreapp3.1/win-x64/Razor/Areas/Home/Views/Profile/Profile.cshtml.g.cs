#pragma checksum "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98a69ac0356bbed1d9734c359e24353508031fd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Home_Views_Profile_Profile), @"mvc.1.0.view", @"/Areas/Home/Views/Profile/Profile.cshtml")]
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
#line 1 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
using PRENATALv2.Areas.Home.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98a69ac0356bbed1d9734c359e24353508031fd3", @"/Areas/Home/Views/Profile/Profile.cshtml")]
    public class Areas_Home_Views_Profile_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_profile>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.min.css\" />\r\n\r\n<div class=\"container text-center\">\r\n    <br />\r\n");
#nullable restore
#line 11 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
     using (Html.BeginForm("SaveExisting", "Profile", FormMethod.Post, new { @style = "max-width:1000px;", @class = "form-group d-inline-block" }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <fieldset class=\"btn-group-vertical\">\r\n            ");
#nullable restore
#line 14 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
       Write(Html.HiddenFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class=""container"">
                <div class=""row row_head"">
                    <div class=""col"" style=""width:250px;"">Registration</div>
                    <div class=""col"" style=""width:250px;"">Last login</div>
                    <div class=""col"" style=""width:150px;"">#Logins</div>
                    <div class=""col"" style=""width:150px;"">Email?</div>
                    <div class=""col"" style=""width:150px;"">Phone#?</div>
                    <div class=""col"" style=""width:150px;"">Two factor?</div>
                </div>
                <div class=""row row_data"">
                    <div class=""col"" style=""width:250px;"">");
#nullable restore
#line 25 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
                                                     Write(Html.DisplayFor(Model => Model.RegDate, "", new { @type = "datetime", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col\" style=\"width:250px;\">");
#nullable restore
#line 26 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
                                                     Write(Html.DisplayFor(Model => Model.LastLogin, "", new { @type = "datetime", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col\" style=\"width:150px;\">");
#nullable restore
#line 27 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
                                                     Write(Html.DisplayFor(Model => Model.LoginCount, "", new { @type = "datetime", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col\" style=\"width:150px;\">");
#nullable restore
#line 28 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
                                                     Write(Html.CheckBoxFor(Model => Model.EmailConfirmed, new { @readonly = true, @style = "width:20px; height:20px;", @class = "form-control d-inline align-middle" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a id=\"_validate_email\" class=\"fas fa-envelope-open-text d-inline a_icon align-middle\"></a></div>\r\n                    <div class=\"col\" style=\"width:150px;\">");
#nullable restore
#line 29 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
                                                     Write(Html.CheckBoxFor(Model => Model.PhoneConfirmed, new { @readonly = true, @class = "form-control d-inline align-middle", @style = "width:20px; height:20px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a id=\"_validate_phone\" class=\"fas fa-sms d-inline a_icon align-middle\"></a></div>\r\n                    <div class=\"col\" style=\"width:150px;\">");
#nullable restore
#line 30 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
                                                     Write(Html.CheckBoxFor(Model=>Model.TwoFactor, new {@readonly=true, @class = "form-control d-inline align-middle", @style = "width:20px; height:20px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <a id=""_enable_2fa"" class=""fas fa-tasks d-inline a_icon align-middle""></a></div>
                </div>
            </div>
            <br />
            <div class=""d-inline"">

                <label style=""width:150px; text-align:right;"" class=""d-inline-block"">Name</label>
                ");
#nullable restore
#line 37 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
           Write(Html.EditorFor(model => model.Name, "", new { htmlAttributes = new { @style = "width:250px; background-color:white; border:0;", @readonly = "readonly", @class = "form-control d-inline" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <i class=\"fas fa-edit _change d-inline a_icon\"></i><br />\r\n                ");
#nullable restore
#line 39 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <div class=\"d-inline-block\">\r\n                <label style=\"width:150px; text-align:right;\" class=\"d-inline-block\">Surname</label>\r\n                ");
#nullable restore
#line 44 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
           Write(Html.EditorFor(model => model.Surname, "", new { htmlAttributes = new { @style = "width:250px; background-color:white; border:0;", @readonly = "readonly", @class = "form-control d-inline" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <i class=\"fas fa-edit _change d-inline a_icon\"></i><br />\r\n                ");
#nullable restore
#line 46 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
           Write(Html.ValidationMessageFor(model => model.Surname, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <div class=\"d-inline-block\">\r\n                <label style=\"width:150px; text-align:right;\" class=\"d-inline-block\">E-mail</label>\r\n\r\n                ");
#nullable restore
#line 52 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
           Write(Html.EditorFor(model => model.Email, "", new { htmlAttributes = new { @style = "width:250px; background-color:white; border:0;", @readonly = "readonly", @class = "form-control d-inline" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <i class=\"fas fa-edit _change d-inline a_icon\"></i><br />\r\n                ");
#nullable restore
#line 54 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                
                <div id=""_validation_email"" hidden></div>
               
            </div>
            <br />
            <div class=""d-inline-block"">
                <label style=""width:150px; text-align:right;"" class=""d-inline-block"">Phone number</label>

                ");
#nullable restore
#line 63 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
           Write(Html.EditorFor(model => model.PhoneNumber, "", new { htmlAttributes = new { @style = "width:250px; background-color:white; border:0;", @readonly = "readonly", @class = "form-control d-inline" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <i class=\"fas fa-edit _change d-inline a_icon\"></i><br />\r\n                ");
#nullable restore
#line 65 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
           Write(Html.ValidationMessageFor(model => model.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                <div id=""_validation_phone"" hidden></div>

                
            </div>
            <br />
            <div class=""d-inline-block"">
                <input style=""width:450px"" class=""btn btn-prenatal"" id=""_submit"" type=""submit"" value=""Save"" disabled />
            </div>

        </fieldset>
");
#nullable restore
#line 77 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""_2fa"">

    </div>
</div>

<script>
    $('#_enable_2fa').click(function () {
        if ($('#_2fa').html() == """") {
            $.ajax({
                url: ""/Home/TwoFactorAuth/EnableAuthenticator"",
                type: ""GET"",
                dataType: ""html"",
                success: function (data) {
                    $(""#_2fa"").html(data);
                }

            });
        } else {
            $('#_2fa').empty();
        }
        

    });


    $('#_validate_email').click(function () {
        $('#_validation_email').removeAttr('hidden');


        $.ajax({
            url: ""/Home/Profile/ConfEmail?Id=");
#nullable restore
#line 108 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
                                        Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            type: ""GET"",
            dataType: ""html"",
            success: function (data) {
                $(""#_validation_email"").html(data);
            }

        });

    });

    $('#_validate_phone').click(function () {
        $('#_validation_phone').removeAttr('hidden');

        if ($('#_validation_phone').html() == """") {
            $.ajax({
                url: ""/Home/Profile/ConfPhone?Id=");
#nullable restore
#line 124 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Profile\Profile.cshtml"
                                            Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""GET"",
                dataType: ""html"",
                success: function (data) {
                    $(""#_validation_phone"").html(data);
                }
            });
        }

    });


    $('._change').click(function () {
        if ($(this).parent().children()[1].getAttribute('readonly') != null) {

            $(this).parent().children()[1].removeAttribute('readonly');
            $(this).parent().children()[1].style = 'background-color:lightgrey; width:200px;';

            $('#_submit').removeAttr('disabled');
        }
        else {

            $(this).parent().children()[1].setAttribute('readonly', 'readonly');
            $(this).parent().children()[1].style = 'background-color:white; width:200px;';

            $('#_submit').attr('disabled', 'disabled');
        }

    });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_profile> Html { get; private set; }
    }
}
#pragma warning restore 1591
