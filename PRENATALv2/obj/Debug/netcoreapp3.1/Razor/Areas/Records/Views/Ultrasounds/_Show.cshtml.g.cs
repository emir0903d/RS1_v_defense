#pragma checksum "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c5a1ce35e59406732b6f05f108d8009a581680d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Records_Views_Ultrasounds__Show), @"mvc.1.0.view", @"/Areas/Records/Views/Ultrasounds/_Show.cshtml")]
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
#line 1 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
using PRENATALv2.Areas.Records.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c5a1ce35e59406732b6f05f108d8009a581680d", @"/Areas/Records/Views/Ultrasounds/_Show.cshtml")]
    public class Areas_Records_Views_Ultrasounds__Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UltrasoundsMR>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.min.css\" />\r\n\r\n<div class=\"container\">\r\n    <div class=\"text-left\" style=\"vertical-align:middle;\">\r\n");
#nullable restore
#line 8 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
           if (User.IsInRole("Nurse") || User.IsInRole("Doctor"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button style=\"vertical-align:middle; font-size:20px;\" id=\"_ultrasound_add\" class=\"btn fas fa-plus-square d-inline\"></button>\r\n");
#nullable restore
#line 11 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <h5 style=\"vertical-align:middle;\" class=\"d-inline\"><strong class=\"text-uppercase\">Ultrasounds:</strong></h5>\r\n    </div>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
      
        if (Model.Ultrasounds.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""container"">
                <div class=""row row_head"">
                    <div class=""col"" hidden>Id</div>
                    <div class=""col"">Date</div>

                    <div class=""col"">H.Beats</div>
                    <div class=""col"">Movem.</div>
                    <div class=""col"">Length</div>
                    <div class=""col"">Nuchal</div>
                    <div class=""col"">Anomal.</div>
                    <div class=""col"">HeadDiam.</div>
                    <div class=""col"">HeadCirc.</div>
                    <div class=""col"">Abdom.Circ.</div>
                    <div class=""col"">Femur</div>
                    <div class=""col"">Note</div>
                    <div class=""col"">Actions</div>
                </div>

");
#nullable restore
#line 38 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
                 foreach (UltrasoundsMR.Details x in Model.Ultrasounds)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row row_data\" style=\"border-bottom:0\">\r\n                        <div class=\"col\" hidden>");
#nullable restore
#line 41 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
                                           Write(x.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"col\">");
#nullable restore
#line 42 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
                                    Write(x.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                        <div class=\"col\">");
#nullable restore
#line 44 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
                                    Write(x.HeartBeats);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"col\">");
#nullable restore
#line 45 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
                                    Write(x.Movement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"col\">");
#nullable restore
#line 46 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
                                    Write(x.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"col\">");
#nullable restore
#line 47 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
                                    Write(x.NuchalScan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"col\">");
#nullable restore
#line 48 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
                                    Write(x.Anomalies);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"col\">");
#nullable restore
#line 49 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
                                    Write(x.HeadDiameter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"col\">");
#nullable restore
#line 50 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
                                    Write(x.HeadCircumference);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"col\">");
#nullable restore
#line 51 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
                                    Write(x.AbdominalCircumference);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"col\">");
#nullable restore
#line 52 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
                                    Write(x.FemurLength);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"col\">");
#nullable restore
#line 53 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
                                    Write(x.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"col\">\r\n");
#nullable restore
#line 55 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
                               if (User.IsInRole("Nurse") || User.IsInRole("Doctor"))
                                {
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i style=\"font-size:20px;\" class=\"_ultrasound_edit fas fa-edit a_icon\"></i>\r\n                                    <a style=\"font-size:20px;\" class=\"_ultrasound_delete fas fa-trash-alt a_icon\"");
            BeginWriteAttribute("href", " href=\"", 2877, "\"", 2920, 2);
            WriteAttributeValue("", 2884, "/Records/Ultrasounds/Delete?Id=", 2884, 31, true);
#nullable restore
#line 59 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
WriteAttributeValue("", 2915, x.Id, 2915, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n");
#nullable restore
#line 60 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
                                }
                                else
                                { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>N/A</div>\r\n");
#nullable restore
#line 64 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 68 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 71 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"

        }

    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"" id=""_ultrasounds_add""></div>
    <div class=""container"" id=""_ultrasounds_edit""></div>
</div>


<script>
    $('._ultrasound_edit').click(function () {
        if ($('#_ultrasounds_edit').html() == """") {
            var i = $(this).parent().parent().children().html();
            $.ajax({
                url: ""/Records/Ultrasounds/Edit?Id="" + i,
                type: ""GET"",
                dataType: ""html"",
                success: function (data) {
                    $(""#_ultrasounds_edit"").html(data);
                },
                complete: function () {
                    $(""form"").each(function () { $.data($(this)[0], 'validator', false); });
                    $.validator.unobtrusive.parse(""form"");
                }
            });
        } else {
            $('#_ultrasounds_edit').empty();
        }

    });
        $('#_ultrasound_add').click(function () {
            if ($('#_ultrasounds_add').html() == """") {

            $.ajax({
     ");
            WriteLiteral("           url: \"/Records/Ultrasounds/Add?Id=\"+");
#nullable restore
#line 105 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\Ultrasounds\_Show.cshtml"
                                               Write(Model.MedicalRecordId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                type: ""GET"",
                dataType: ""html"",
                success: function (data) {

                    $(""#_ultrasounds_add"").html(data);

                },
                complete: function () {
                    $(""form"").each(function () { $.data($(this)[0], 'validator', false); });
                    $.validator.unobtrusive.parse(""form"");

                }
            });
        } else {
                $('#_ultrasounds_add').empty();
        }
    });
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UltrasoundsMR> Html { get; private set; }
    }
}
#pragma warning restore 1591
