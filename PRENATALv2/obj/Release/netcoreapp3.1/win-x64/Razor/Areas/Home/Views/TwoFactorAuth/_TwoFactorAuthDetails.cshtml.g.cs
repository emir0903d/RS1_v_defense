#pragma checksum "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\TwoFactorAuth\_TwoFactorAuthDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f779de6b28ab7480fa5e61bc52edb78482139d22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Home_Views_TwoFactorAuth__TwoFactorAuthDetails), @"mvc.1.0.view", @"/Areas/Home/Views/TwoFactorAuth/_TwoFactorAuthDetails.cshtml")]
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
#line 1 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\TwoFactorAuth\_TwoFactorAuthDetails.cshtml"
using PRENATALv2.Areas.Home.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f779de6b28ab7480fa5e61bc52edb78482139d22", @"/Areas/Home/Views/TwoFactorAuth/_TwoFactorAuthDetails.cshtml")]
    public class Areas_Home_Views_TwoFactorAuth__TwoFactorAuthDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_2FAdetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\TwoFactorAuth\_TwoFactorAuthDetails.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n        <div class=\"alert alert-danger\">\r\n            <strong># of Recovery codes left:</strong>");
#nullable restore
#line 7 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\TwoFactorAuth\_TwoFactorAuthDetails.cshtml"
                                                 Write(Model.RecoveryCodesLeft);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </div>
        <hr />
        <a href=""/Home/TwoFactorAuth/Disable2FA"" class=""btn btn-small"">Disable 2FA</a>
        <a href=""/Home/TwoFactorAuth/GenerateRecoveryCodes"" class=""btn btn-small"">Reset recovery codes</a>
        <hr />
    </div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_2FAdetails> Html { get; private set; }
    }
}
#pragma warning restore 1591