#pragma checksum "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "828ac0ae9cbe1c82243c7f37df4ce80943b16d00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Records_Views_VitalSigns__Add), @"mvc.1.0.view", @"/Areas/Records/Views/VitalSigns/_Add.cshtml")]
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
#line 1 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
using PRENATALv2.Areas.Records.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"828ac0ae9cbe1c82243c7f37df4ce80943b16d00", @"/Areas/Records/Views/VitalSigns/_Add.cshtml")]
    public class Areas_Records_Views_VitalSigns__Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VitalSignsMR.Details>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"container border-bottom\">\r\n\r\n        <h3><strong class=\"text-uppercase\">Add vitalsigns</strong></h3>\r\n");
#nullable restore
#line 7 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
         using (Html.BeginForm("Save", "VitalSigns", FormMethod.Post, new { @class = "form-group" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
                                    ;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <fieldset class=\"align-content-lg-around\">\r\n                ");
#nullable restore
#line 11 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
           Write(Html.HiddenFor(Model => Model.MedicalRecordId, new { @class = "d-none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 13 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.LabelFor(Model => Model.Date, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 14 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.TextBoxFor(Model => Model.Date, new { @type = "date", @class = " datepicker form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 15 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.Date, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 18 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.LabelFor(Model => Model.Temperature, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 19 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.TextBoxFor(Model => Model.Temperature, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 20 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.Temperature, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.LabelFor(Model => Model.SystolicPressure, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 24 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.TextBoxFor(Model => Model.SystolicPressure, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 25 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.SystolicPressure, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.LabelFor(Model => Model.DiastolicPressure, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 29 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.TextBoxFor(Model => Model.DiastolicPressure, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 30 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.DiastolicPressure, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.LabelFor(Model => Model.HeartBeats, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 34 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.TextBoxFor(Model => Model.HeartBeats, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 35 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.HeartBeats, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.LabelFor(Model => Model.RespiratoryRate, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 39 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.TextBoxFor(Model => Model.RespiratoryRate, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 40 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.RespiratoryRate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 43 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.LabelFor(Model => Model.Height, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 44 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.TextBoxFor(Model => Model.Height, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 45 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.Height, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 48 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.LabelFor(Model => Model.Weight, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 49 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.TextBoxFor(Model => Model.Weight, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 50 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.Weight, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 54 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.LabelFor(Model => Model.Note, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 55 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.TextAreaFor(Model => Model.Note, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 56 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.Note, "", new { @class = "text-danger" }));

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
#line 64 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\VitalSigns\_Add.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VitalSignsMR.Details> Html { get; private set; }
    }
}
#pragma warning restore 1591
