#pragma checksum "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d90f621a0a65207e62cfc1a9cc49b897e9e8fbb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Home_Views_Account_Login), @"mvc.1.0.view", @"/Areas/Home/Views/Account/Login.cshtml")]
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
#line 1 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\Login.cshtml"
using PRENATALv2.Areas.Home.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d90f621a0a65207e62cfc1a9cc49b897e9e8fbb4", @"/Areas/Home/Views/Account/Login.cshtml")]
    public class Areas_Home_Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Login>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\Login.cshtml"
  
    Layout = "_Anonymous";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\Login.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 9 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\Login.cshtml"
      
        if (ViewBag.Msg != "")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div><h3><strong class=\"text-uppercase\" style=\"color:red\">");
#nullable restore
#line 12 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\Login.cshtml"
                                                                 Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h3></div>\r\n");
#nullable restore
#line 13 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\Login.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3><strong class=\"text-uppercase\">Login</strong></h3>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\Login.cshtml"
     using (Html.BeginForm("LoginAttempt", "Account", FormMethod.Post, new { @class = "form-group" }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <fieldset>\r\n            <label>username: </label>\r\n            ");
#nullable restore
#line 21 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\Login.cshtml"
       Write(Html.TextBoxFor(model => model.Username, new { @class = "form-group" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n            <label>password: </label>\r\n            ");
#nullable restore
#line 24 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\Login.cshtml"
       Write(Html.TextBoxFor(model => model.Password, new { @class = "form-group", type = "Password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n");
            WriteLiteral("            <input type=\"submit\" class=\"btn btn-dark\" value=\"Login\" />\r\n        </fieldset>\r\n");
#nullable restore
#line 30 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Account\Login.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Login> Html { get; private set; }
    }
}
#pragma warning restore 1591
