#pragma checksum "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89fc41cf522b6c73772bd743de51566774c8a4bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Records_Views_PregnanciesPrevious__Edit), @"mvc.1.0.view", @"/Areas/Records/Views/PregnanciesPrevious/_Edit.cshtml")]
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
#line 1 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
using PRENATALv2.Areas.Records.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89fc41cf522b6c73772bd743de51566774c8a4bd", @"/Areas/Records/Views/PregnanciesPrevious/_Edit.cshtml")]
    public class Areas_Records_Views_PregnanciesPrevious__Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PregnanciesPreviousMR.Details>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container border-bottom\">\r\n    <h3><strong class=\"text-uppercase\">Edit previous pregnancy</strong></h3>\r\n");
#nullable restore
#line 6 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
     using (Html.BeginForm("SaveExisting", "PregnanciesPrevious", FormMethod.Post, new { @class = "form-group" }))
    {
     


#line default
#line hidden
#nullable disable
            WriteLiteral("        <fieldset class=\"align-content-lg-around\">\r\n\r\n            ");
#nullable restore
#line 12 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
       Write(Html.HiddenFor(Model => Model.MedicalRecordId, new { @class = "d-none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 13 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
       Write(Html.HiddenFor(Model => Model.Id, new { @class = "d-none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 15 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
           Write(Html.LabelFor(Model => Model.PregnancyDate, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                ");
#nullable restore
#line 16 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
           Write(Html.EditorFor(Model => Model.PregnancyDate, new { htmlAttributes = new { @type = "date", @class = "datepicker form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                ");
#nullable restore
#line 17 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
           Write(Html.ValidationMessageFor(Model => Model.PregnancyDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 20 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
           Write(Html.LabelFor(Model => Model.GestationWeeks, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                ");
#nullable restore
#line 21 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
           Write(Html.EditorFor(Model => Model.GestationWeeks, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                ");
#nullable restore
#line 22 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
           Write(Html.ValidationMessageFor(Model => Model.GestationWeeks, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 25 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
           Write(Html.LabelFor(Model => Model.DeliveryType, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                ");
#nullable restore
#line 26 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
           Write(Html.EditorFor(Model => Model.DeliveryType, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                ");
#nullable restore
#line 27 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
           Write(Html.ValidationMessageFor(Model => Model.DeliveryType, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 30 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
           Write(Html.LabelFor(Model => Model.Complications, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                ");
#nullable restore
#line 31 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
           Write(Html.EditorFor(Model => Model.Complications, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                ");
#nullable restore
#line 32 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
           Write(Html.ValidationMessageFor(Model => Model.Complications, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 35 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
           Write(Html.LabelFor(Model => Model.Outcome, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                ");
#nullable restore
#line 36 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
           Write(Html.DropDownListFor(Model => Model.Outcome, new SelectList(Model.Outcomes, "Value", "Text", Model.Outcome), "Select:", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                ");
#nullable restore
#line 37 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
           Write(Html.ValidationMessageFor(Model => Model.Outcome, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>

            <div class=""d-inline"">
                <button id=""edit_cancel"" class=""btn btn-small form-control"">Cancel</button>
                <input type=""submit"" class=""btn btn-small form-control"" value=""Save"" />
            </div>
        </fieldset>
");
#nullable restore
#line 45 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<script>\r\n    $(\'#edit_cancel\').click(function () {\r\n        $(this).parent().parent().parent().parent().parent().empty();\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PregnanciesPreviousMR.Details> Html { get; private set; }
    }
}
#pragma warning restore 1591
