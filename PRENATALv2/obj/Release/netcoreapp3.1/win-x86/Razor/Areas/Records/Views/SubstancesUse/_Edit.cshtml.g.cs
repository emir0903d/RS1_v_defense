#pragma checksum "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beb1657043fb2cd5c47f701d8a4fdbf1d1cc879f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Records_Views_SubstancesUse__Edit), @"mvc.1.0.view", @"/Areas/Records/Views/SubstancesUse/_Edit.cshtml")]
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
#line 1 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
using PRENATALv2.Areas.Records.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beb1657043fb2cd5c47f701d8a4fdbf1d1cc879f", @"/Areas/Records/Views/SubstancesUse/_Edit.cshtml")]
    public class Areas_Records_Views_SubstancesUse__Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SubstancesUseMR.Details>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"container border-bottom\">\r\n        <h3><strong class=\"text-uppercase\">Edit substance</strong></h3>\r\n");
#nullable restore
#line 6 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
         using (Html.BeginForm("SaveExisting", "SubstancesUse", FormMethod.Post, new { @class = "form-group" }))
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
                                    ;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <fieldset class=\"align-content-lg-around\">\r\n\r\n                ");
#nullable restore
#line 12 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
           Write(Html.HiddenFor(Model => Model.MedicalRecordId, new { @class = "d-none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 13 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
           Write(Html.HiddenFor(Model => Model.Id, new { @class = "d-none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 16 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
               Write(Html.LabelFor(Model => Model.Description, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 17 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
               Write(Html.EditorFor(Model => Model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 18 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
               Write(Html.LabelFor(Model => Model.Note, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 22 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
               Write(Html.EditorFor(Model => Model.Note, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 23 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.Note, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <br /><hr />\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
               Write(Html.LabelFor(Model => Model.PriorToPregnancy, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 28 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
               Write(Html.CheckBoxFor(Model => Model.PriorToPregnancy, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 29 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.PriorToPregnancy, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
               Write(Html.LabelFor(Model => Model.StillUsing, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 33 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
               Write(Html.CheckBoxFor(Model => Model.StillUsing, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 34 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.StillUsing, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-inline-block\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
               Write(Html.LabelFor(Model => Model.NumberOfYears, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 38 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
               Write(Html.EditorFor(Model => Model.NumberOfYears, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    ");
#nullable restore
#line 39 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
               Write(Html.ValidationMessageFor(Model => Model.NumberOfYears, "", new { @class = "text-danger" }));

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
#line 49 "C:\Users\user\Desktop\_rs1 -verz\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\SubstancesUse\_Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SubstancesUseMR.Details> Html { get; private set; }
    }
}
#pragma warning restore 1591