#pragma checksum "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0584092cb569cc604e2c7b82ba21fde51588adc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Records_Views_MedicalRecords_AddOne), @"mvc.1.0.view", @"/Areas/Records/Views/MedicalRecords/AddOne.cshtml")]
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
#line 1 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
using PRENATALv2.Areas.Records.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0584092cb569cc604e2c7b82ba21fde51588adc", @"/Areas/Records/Views/MedicalRecords/AddOne.cshtml")]
    public class Areas_Records_Views_MedicalRecords_AddOne : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MR>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h3><strong class=\"text-uppercase\">Add medical record</strong></h3>\r\n");
#nullable restore
#line 9 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
     using (Html.BeginForm("SaveNew", "MedicalRecords", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <fieldset class=\"align-content-lg-around\">\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 13 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.LabelFor(Model => Model.MedicalRecordNumber, new { @class = "col-sm-12", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 14 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.DisplayFor(Model => Model.MedicalRecordNumber, new { @class = "thead-light col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 15 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.HiddenFor(Model => Model.MedicalRecordNumber, new { @class = "d-none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 19 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.LabelFor(Model => Model.DoctorId, new { @class = "col-sm-12", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.DisplayFor(Model => Model.DoctorId, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.HiddenFor(Model => Model.DoctorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 25 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.LabelFor(Model => Model.Doctor, new { @class = "col-sm-12", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 26 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.DisplayFor(Model => Model.Doctor, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 27 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.HiddenFor(Model => Model.Doctor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 31 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.LabelFor(Model => Model.Id, new { @class = "col-sm-12", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 32 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.DisplayFor(Model => Model.Id, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 33 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.HiddenFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <hr />\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 38 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.LabelFor(Model => Model.Name, new { @class = "col-sm-12", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 39 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.DisplayFor(Model => Model.Name, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 43 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.LabelFor(Model => Model.Surname, new { @class = "col-sm-12", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 44 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.DisplayFor(Model => Model.Surname, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 48 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.LabelFor(Model => Model.Email, new { @class = "col-sm-12", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 49 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.DisplayFor(Model => Model.Email, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 53 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.LabelFor(Model => Model.PhoneNumber, new { @class = "col-sm-12", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 54 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.DisplayFor(Model => Model.PhoneNumber, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <hr />\r\n\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 60 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.LabelFor(Model => Model.MartialStatus, new { @class = "col-sm-12", style = "width:200px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 61 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.DropDownListFor(model => model.MartialStatus, new SelectList(Model.StatusList, "Value", "Text"), "MartialStatus:", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                ");
#nullable restore
#line 62 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.ValidationMessageFor(model => model.MartialStatus, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 65 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.LabelFor(Model => Model.BloodType, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 66 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.DropDownListFor(model => model.BloodType, new SelectList(Model.BloodTypes, "Value", "Text"), "BloodType:", new { @class = "form-control", style = "width:200px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                ");
#nullable restore
#line 67 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.ValidationMessageFor(model => model.BloodType, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 71 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.LabelFor(Model => Model.RhFactor, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 72 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.DropDownListFor(model => model.RhFactor, new SelectList(Model.RhFactors, "Value", "Text"), "RhFactor:", new { @class = "form-control", style = "width:200px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                ");
#nullable restore
#line 73 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.ValidationMessageFor(model => model.BloodType, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <br />\r\n            <hr />\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 79 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.LabelFor(Model => Model.BirthDate, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 80 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.EditorFor(model => model.BirthDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                ");
#nullable restore
#line 81 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.ValidationMessageFor(model => model.BirthDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 84 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.LabelFor(Model => Model.MaidenName, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 85 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.EditorFor(model => model.MaidenName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                ");
#nullable restore
#line 86 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.ValidationMessageFor(model => model.MaidenName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"d-inline-block\">\r\n                ");
#nullable restore
#line 90 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.LabelFor(Model => Model.PersonalIdentificationNumber, new { @class = "col-sm-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 91 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.EditorFor(model => model.PersonalIdentificationNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                ");
#nullable restore
#line 92 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
           Write(Html.ValidationMessageFor(model => model.PersonalIdentificationNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <br />\r\n            <hr />\r\n            <div class=\"d-inline\"><input type=\"submit\" class=\"form-control btn btn-small\" value=\"Save\" /></div>\r\n        </fieldset>\r\n");
#nullable restore
#line 99 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\AddOne.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MR> Html { get; private set; }
    }
}
#pragma warning restore 1591
