#pragma checksum "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb9a4f0029111288cbe1ccf202bd60f88dd6e17a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Home_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Home/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Home\Index.cshtml"
using PRENATALv2.Areas.Home.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb9a4f0029111288cbe1ccf202bd60f88dd6e17a", @"/Areas/Home/Views/Home/Index.cshtml")]
    public class Areas_Home_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Login>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/baby1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("front-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("vertical-align:middle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Home\Index.cshtml"
  
    Layout = "_Anonymous";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"front-container\" style=\"vertical-align:middle\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb9a4f0029111288cbe1ccf202bd60f88dd6e17a4582", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n    <div class=\"front-group\" style=\"vertical-align:middle\">\r\n\r\n\r\n");
#nullable restore
#line 17 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Home\Index.cshtml"
         using (Html.BeginForm("LoginAttempt", "Account", FormMethod.Post, new { @class = "form-group" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Home\Index.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <fieldset class=\"btn-group-vertical align-content-md-around\">\r\n                <h6>Sign-in:</h6>\r\n                <label>username: </label>\r\n                ");
#nullable restore
#line 23 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(model => model.Username, new { @class = "form-group" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n                <label>password: </label>\r\n                ");
#nullable restore
#line 26 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Home\Index.cshtml"
           Write(Html.TextBoxFor(model => model.Password, new { @class = "form-group", type = "Password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n                <input type=\"submit\" class=\"btn btn-prenatal\" value=\"Login\" />\r\n                <br />\r\n                ");
#nullable restore
#line 30 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Forgot password?", "AccessDenied", "Account", new { area = "Home" }, new { @class = "btn btn-prenatal" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 32 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Register", "Register", "Account", new { area = "Home" }, new { @class = "btn btn-prenatal" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </fieldset>\r\n");
#nullable restore
#line 34 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Home\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <p style=""font-size:10px; color:red""><strong>FOR NEWLY REGISTERED USERS: USERNAME & PASSWORD IS SENT BY E-MAIL!</strong></p>
        <p style=""font-size:10px; color:red""><strong>FOR CREATED USERS: USERNAME:(LASTNAME+1ST-LETTER-OF-NAME); PASSWORD:P!123456</strong></p>
        <p style=""font-size:10px; color:red"">1) admin, Admin!12</p>
        <p style=""font-size:10px; color:red"">2) doctord, Pp!12345</p>
        <p style=""font-size:10px; color:red"">3) nursen, Pp!12345</p>
        <p style=""font-size:10px; color:red"">4) patientp, Pp!12345</p>
    </div>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Login> Html { get; private set; }
    }
}
#pragma warning restore 1591
