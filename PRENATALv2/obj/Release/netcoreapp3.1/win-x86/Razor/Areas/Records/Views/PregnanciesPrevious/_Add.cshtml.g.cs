#pragma checksum "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a61fd48fe9b2fd390c7b84dd196274c9a17b06c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Records_Views_PregnanciesPrevious__Add), @"mvc.1.0.view", @"/Areas/Records/Views/PregnanciesPrevious/_Add.cshtml")]
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
#line 1 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
using PRENATALv2.Areas.Records.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a61fd48fe9b2fd390c7b84dd196274c9a17b06c7", @"/Areas/Records/Views/PregnanciesPrevious/_Add.cshtml")]
    public class Areas_Records_Views_PregnanciesPrevious__Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PregnanciesPreviousMR.Details>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"container border-bottom\">\r\n\r\n        <h3><strong class=\"text-uppercase\">Add previous pregnancy:</strong></h3>\r\n");
#nullable restore
#line 7 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
         using (Html.BeginForm("Save", "PregnanciesPrevious", FormMethod.Post, new { @class = "form-group" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
                                    ;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <fieldset class=\"align-content-lg-around\">\r\n                ");
#nullable restore
#line 11 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
           Write(Html.HiddenFor(Model => Model.MedicalRecordId, new { @class = "d-none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 13 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
               Write(Html.LabelFor(Model => Model.PregnancyDate, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 14 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
               Write(Html.TextBoxFor(Model => Model.PregnancyDate, new { @type = "date", @class = "datepicker form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 15 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.PregnancyDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 18 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
               Write(Html.LabelFor(Model => Model.GestationWeeks, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 19 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
               Write(Html.TextBoxFor(Model => Model.GestationWeeks, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 20 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.GestationWeeks, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
               Write(Html.LabelFor(Model => Model.DeliveryType, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 24 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
               Write(Html.TextBoxFor(Model => Model.DeliveryType, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 25 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.DeliveryType, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
               Write(Html.LabelFor(Model => Model.Complications, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 29 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
               Write(Html.TextBoxFor(Model => Model.Complications, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 30 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.Complications, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
               Write(Html.LabelFor(Model => Model.Outcome, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 34 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
               Write(Html.DropDownListFor(Model => Model.Outcome, new SelectList(Model.Outcomes, "Value", "Text"), "Select:", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 35 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.Outcome, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""d-inline"">
                    <button id=""add_cancel"" class=""btn btn-small form-control"">Cancel</button>
                    <input type=""submit"" class=""btn btn-small form-control"" value=""Save"" />
                </div>

            </fieldset>
");
#nullable restore
#line 43 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\PregnanciesPrevious\_Add.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n<script>\r\n    $(\'#add_cancel\').click(function () {\r\n\r\n        $(this).parent().parent().parent().parent().parent().empty();\r\n    });\r\n</script>");
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
