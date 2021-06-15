#pragma checksum "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "504ebaae842ad0624b1382c54b1cdc2ae2db131e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Records_Views_Referrals__Add), @"mvc.1.0.view", @"/Areas/Records/Views/Referrals/_Add.cshtml")]
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
#line 1 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
using PRENATALv2.Areas.Records.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"504ebaae842ad0624b1382c54b1cdc2ae2db131e", @"/Areas/Records/Views/Referrals/_Add.cshtml")]
    public class Areas_Records_Views_Referrals__Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReferralsMR.Details>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container border-bottom\">\r\n\r\n    <h3><strong class=\"text-uppercase\">Add referral</strong></h3>\r\n");
#nullable restore
#line 7 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
     using (Html.BeginForm("Save", "Referrals", FormMethod.Post, new { @class = "form-group" }))
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("<fieldset class=\"align-content-lg-around\">\r\n    ");
#nullable restore
#line 11 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
Write(Html.HiddenFor(Model => Model.MedicalRecordId, new { @class = "d-none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
     for (int i = 0; i < Model.BloodExams.Count(); i++)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.HiddenFor(Model => Model.BloodExams[i].Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.HiddenFor(Model => Model.BloodExams[i].Unit));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.HiddenFor(Model => Model.BloodExams[i].Low));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.HiddenFor(Model => Model.BloodExams[i].High));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.HiddenFor(Model => Model.BloodExams[i].BloodTest));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
                                                               

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
     for (int i = 0; i < Model.UrineExams.Count(); i++)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.HiddenFor(Model => Model.UrineExams[i].Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.HiddenFor(Model => Model.UrineExams[i].UrineTest));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.HiddenFor(Model => Model.UrineExams[i].Unit));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.HiddenFor(Model => Model.UrineExams[i].ReferenceInterval));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
                                                                       

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"d-inline-block\">\r\n        ");
#nullable restore
#line 30 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.LabelFor(Model => Model.Date, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        ");
#nullable restore
#line 31 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.TextBoxFor(Model => Model.Date, new { @type = "date", @class = "datepicker form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        ");
#nullable restore
#line 32 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.ValidationMessageFor(Model => Model.Date, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"d-inline-block\">\r\n        ");
#nullable restore
#line 35 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.LabelFor(Model => Model.Note, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        ");
#nullable restore
#line 36 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.TextBoxFor(Model => Model.Note, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        ");
#nullable restore
#line 37 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.ValidationMessageFor(Model => Model.Note, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <div class=\"d-inline-block\">\r\n        ");
#nullable restore
#line 41 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.LabelFor(Model => Model.UrineExamsSelected, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        ");
#nullable restore
#line 42 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.ListBoxFor(Model => Model.UrineExamsSelected, new MultiSelectList(Model.UrineExams, "UrineTest", "UrineTest"), new {@style= "height:200px; width:200px; text-align:center;", @class = "form-control", multiple = "multiple" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        ");
#nullable restore
#line 43 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.ValidationMessageFor(Model => Model.UrineExamsSelected, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"d-inline-block\">\r\n        ");
#nullable restore
#line 46 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.LabelFor(Model => Model.BloodExamsSelected, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        ");
#nullable restore
#line 47 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.ListBoxFor(Model => Model.BloodExamsSelected, new MultiSelectList(Model.BloodExams, "BloodTest", "BloodTest"), new { @style = "height:200px; width:200px; text-align:center;", @class = "form-control", multiple = "multiple" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        ");
#nullable restore
#line 48 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
   Write(Html.ValidationMessageFor(Model => Model.BloodExamsSelected, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"d-inline\">\r\n        <button id=\"add_cancel\" class=\"btn btn-small form-control\">Cancel</button>\r\n        <input type=\"submit\" class=\"btn btn-small form-control\" value=\"Save\" />\r\n    </div>\r\n\r\n</fieldset>\r\n");
#nullable restore
#line 56 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\Referrals\_Add.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<script>\r\n    $(\'#add_cancel\').click(function () {\r\n\r\n        $(this).parent().parent().parent().parent().parent().empty();\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReferralsMR.Details> Html { get; private set; }
    }
}
#pragma warning restore 1591
