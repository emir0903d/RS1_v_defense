#pragma checksum "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21f97a24af55cc9fae4341f0f541a2d26b69c744"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Records_Views_Ultrasounds__Edit), @"mvc.1.0.view", @"/Areas/Records/Views/Ultrasounds/_Edit.cshtml")]
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
#line 1 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
using PRENATALv2.Areas.Records.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21f97a24af55cc9fae4341f0f541a2d26b69c744", @"/Areas/Records/Views/Ultrasounds/_Edit.cshtml")]
    public class Areas_Records_Views_Ultrasounds__Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UltrasoundsMR.Details>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"container border-bottom\">\r\n        <h3><strong class=\"text-uppercase\">Edit ultrasound</strong></h3>\r\n");
#nullable restore
#line 6 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
         using (Html.BeginForm("SaveExisting", "Ultrasounds", FormMethod.Post, new { @class = "form-group" }))
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
                                    ;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <fieldset class=\"align-content-lg-around\">\r\n\r\n                ");
#nullable restore
#line 12 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
           Write(Html.HiddenFor(Model => Model.MedicalRecordId, new { @class = "d-none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 13 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
           Write(Html.HiddenFor(Model => Model.Id, new { @class = "d-none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 16 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.LabelFor(Model => Model.Date, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 17 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.EditorFor(Model => Model.Date, new { htmlAttributes = new { @type = "date", @class = " datepicker form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 18 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.Date, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.LabelFor(Model => Model.HeartBeats, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 22 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.EditorFor(Model => Model.HeartBeats, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 23 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.HeartBeats, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.LabelFor(Model => Model.Movement, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 27 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.CheckBoxFor(Model => Model.Movement, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 28 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.Movement, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 31 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.LabelFor(Model => Model.Length, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 32 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.EditorFor(Model => Model.Length, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 33 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.Length, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.LabelFor(Model => Model.NuchalScan, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 37 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.CheckBoxFor(Model => Model.NuchalScan, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 38 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.NuchalScan, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.LabelFor(Model => Model.Anomalies, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 42 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.CheckBoxFor(Model => Model.Anomalies, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 43 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.Anomalies, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 46 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.LabelFor(Model => Model.HeadDiameter, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 47 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.EditorFor(Model => Model.HeadDiameter, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 48 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.HeadDiameter, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 51 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.LabelFor(Model => Model.HeadCircumference, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 52 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.EditorFor(Model => Model.HeadCircumference, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 53 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.HeadCircumference, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 56 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.LabelFor(Model => Model.AbdominalCircumference, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 57 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.EditorFor(Model => Model.AbdominalCircumference, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 58 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.AbdominalCircumference, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 61 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.LabelFor(Model => Model.FemurLength, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 62 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.EditorFor(Model => Model.FemurLength, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 63 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.FemurLength, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 66 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.LabelFor(Model => Model.Note, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 67 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.EditorFor(Model => Model.Note, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 68 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.Note, "", new { @class = "text-danger" }));

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
#line 76 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n<script>\r\n    $(\'#edit_cancel\').click(function () {\r\n        $(this).parent().parent().parent().parent().parent().empty();\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UltrasoundsMR.Details> Html { get; private set; }
    }
}
#pragma warning restore 1591
