#pragma checksum "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed09886dabdeff26c8326b4b008ad125e887f2b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Records_Views_MedicalRecords_ShowOne), @"mvc.1.0.view", @"/Areas/Records/Views/MedicalRecords/ShowOne.cshtml")]
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
#line 1 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
using PRENATALv2.Areas.Records.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed09886dabdeff26c8326b4b008ad125e887f2b0", @"/Areas/Records/Views/MedicalRecords/ShowOne.cshtml")]
    public class Areas_Records_Views_MedicalRecords_ShowOne : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MR>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.min.css"" />
<nav style=""font-size:11px; text-align:center;"">
    <ul style=""height:55px"" class=""nav justify-content-center navbar navbar-expand-lg navbar-dark bg-prenatal"">
        <li id=""MedicalRecordId"" class=""navbar-brand"" href=""#""><button class=""btn btn-prenatal""><strong>");
#nullable restore
#line 10 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                                                                                                   Write(Model.MedicalRecordNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></button></li>
        <li id=""_allergy_show"" class=""nav-item"">
            <button class=""nav-link active btn btn-prenatal"">Allergies</button>
        </li>

        <li id=""_medicalhistory_show"" class=""nav-item"">
            <button class=""nav-link active btn btn-prenatal"">History</button>
        </li>
        <li id=""_partner_show"" class=""nav-item"">
            <button class=""nav-link active btn btn-prenatal"">Partners</button>
        </li>

        <li id=""_pregnancy_loss_show"" class=""nav-item"">
            <button class=""nav-link active btn btn-prenatal"">LostPreg.</button>
        </li>
        <li id=""_previous_pregnancies_show"" class=""nav-item"">
            <button class=""active nav-link btn btn-prenatal"">Prev.Preg.</button>
        </li>
        <li id=""_substance_show"" class=""nav-item"">
            <button class=""btn btn-prenatal active nav-link"">Substances</button>
        </li>
        <li id=""_therapy_show"" class=""nav-item"">
            <button class=""nav-link activ");
            WriteLiteral(@"e btn btn-prenatal"">Therapies</button>
        </li>
        <li id=""_ultrasound_show"" class=""nav-item"">
            <button class=""active nav-link btn btn-prenatal"">Ultrasounds</button>
        </li>
        <li id=""_vital_show"" class=""nav-item"">
            <button class=""nav-link active btn btn-prenatal"">VitalSigns</button>
        </li>
        <li id=""_referral_show"" class=""nav-item"">
            <button class=""nav-link active btn btn-prenatal"">Referrals</button>
        </li>
        <li id=""_photo_show"" class=""nav-item"">
            <button class=""nav-link active btn btn-prenatal"">Photos</button>
        </li>
        <li id=""_file_show"" class=""nav-item"">
            <button class=""nav-link active btn btn-prenatal"">Files</button>
        </li>
    </ul>
</nav>

<div class=""container"">
    <div class=""text-left"" style=""padding:5px 0 5px 0;"">
        <h5><strong class=""text-uppercase"">Personal informations:</strong></h5>
    </div>

    <div class=""container"">

        <div cla");
            WriteLiteral(@"ss=""row row_head"">
            <div class=""col"">Assig. Doctor</div>
            <div class=""col"">Name</div>
            <div class=""col"">Surname</div>
            <div class=""col"">MaidenName</div>
            <div class=""col"">PIN</div>
            <div class=""col"">BirthDate</div>
        </div>

        <div class=""row row_data"">
            <div class=""col"">");
#nullable restore
#line 69 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                        Write(Model.Doctor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col\">");
#nullable restore
#line 70 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col\">");
#nullable restore
#line 71 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                        Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col\">");
#nullable restore
#line 72 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                        Write(Model.MaidenName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col\">");
#nullable restore
#line 73 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                        Write(Model.PersonalIdentificationNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col\">");
#nullable restore
#line 74 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                        Write(Model.BirthDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
        </div>


    </div>

    <div class=""container"">

        <div class=""row row_head"">

            <div class=""col"">PhoneNumber</div>
            <div class=""col"">E-mail</div>
            <div class=""col"">MartialStatus</div>
            <div class=""col"">BloodType</div>
            <div class=""col"">RhFactor</div>
            <div class=""col"">
");
#nullable restore
#line 92 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                     if (User.IsInRole("Patient") == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>EMERGENCY SMS</div>\r\n");
#nullable restore
#line 95 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <div class=\"row row_data\">\r\n\r\n        <div class=\"col\">");
#nullable restore
#line 102 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                    Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col\">");
#nullable restore
#line 103 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                    Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <tdiv class=\"col\" d>");
#nullable restore
#line 104 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                       Write(Model.MartialStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</tdiv>\r\n        <div class=\"col\">");
#nullable restore
#line 105 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                    Write(Model.BloodType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <tdiv class=\"col\" d>");
#nullable restore
#line 106 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                       Write(Model.RhFactor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</tdiv>\r\n        <div class=\"col\">\r\n");
#nullable restore
#line 109 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                 if (User.IsInRole("Patient") == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <i class=\"fas fa-sms a_icon\" id=\"send_sms\" ");
            WriteLiteral("></i>\r\n");
#nullable restore
#line 112 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>


</div>

</div>
<div id=""_allergies_show""></div>
<div id=""_medicalhistories_show""></div>
<div id=""_partners_show""></div>
<div id=""_pregnancies_loss_show""></div>
<div id=""_pregnancies_previous_show""></div>
<div id=""_substances_show""></div>
<div id=""_therapies_show""></div>
<div id=""_ultrasounds_show""></div>
<div id=""_vitals_show""></div>
<div id=""_referrals_show""></div>
<div id=""_photos_show""></div>
<div id=""_files_show""></div>
<script>
    //send sms
        $('#send_sms').click(function () {
            var to = ");
#nullable restore
#line 137 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                Write(Html.Raw(Model.DoctorObj.PhoneNumber.ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            var text = \'");
#nullable restore
#line 138 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                   Write(Html.Raw(Model.Name.ToString()+" "+Model.Surname.ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
            var msg = "" EMERGENCY:: Please call me!!!"";
            $.ajax({
                url: ""/Admin/SMS/Send"",
                data:""to=""+to+""&text=""+text+"" ""+msg,
                type: ""POST"",
                dataType: ""JSON"",
                success: function () {
                    alert(""SENT--> To: ""+to);
                }
            });

    });

    //functions one by one
    $('#_file_show').click(function () {
        if ($('#_files_show').html()=="""") {
            $.ajax({
                url: ""/Records/Files/Show?Id=");
#nullable restore
#line 156 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                                        Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""GET"",
                dataType: ""html"",
                success: function (data) {
                    $(""#_files_show"").html(data);
                }
            });
        } else {
            $('#_files_show').empty();
        }
    });

    $('#_photo_show').click(function () {
        if ($('#_photos_show').html()=="""") {
            $.ajax({
                url: ""/Records/Photos/Show?Id=");
#nullable restore
#line 171 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                                         Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""GET"",
                dataType: ""html"",
                success: function (data) {
                    $(""#_photos_show"").html(data);
                }
            });
        } else {
            $('#_photos_show').empty();
        }
    });

    $('#_vital_show').click(function () {
        if ($('#_vitals_show').html()=="""") {
            $.ajax({
                url: ""/Records/VitalSigns/Show?Id=");
#nullable restore
#line 186 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                                             Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""GET"",
                dataType: ""html"",
                success: function (data) {
                    $(""#_vitals_show"").html(data);
                }
            });
        } else {
            $('#_vitals_show').empty();
        }
    });

    $('#_ultrasound_show').click(function () {
        if ($('#_ultrasounds_show').html()=="""") {
            $.ajax({
                url: ""/Records/Ultrasounds/Show?Id=");
#nullable restore
#line 201 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                                              Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""GET"",
                dataType: ""html"",
                success: function (data) {
                    $(""#_ultrasounds_show"").html(data);
                }
            });
        } else {
            $('#_ultrasounds_show').empty();
        }
    });

    $('#_therapy_show').click(function () {
        if ($('#_therapies_show').html()=="""") {
            $.ajax({
                url: ""/Records/Therapies/Show?Id=");
#nullable restore
#line 216 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                                            Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""GET"",
                dataType: ""html"",
                success: function (data) {
                    $(""#_therapies_show"").html(data);
                }
            });
        } else {
            $('#_therapies_show').empty();
        }
    });


    $('#_previous_pregnancies_show').click(function () {
        if ($('#_pregnancies_previous_show').html()=="""") {
            $.ajax({
                url: ""/Records/PregnanciesPrevious/Show?Id=");
#nullable restore
#line 232 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                                                      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""GET"",
                dataType: ""html"",
                success: function (data) {
                    $(""#_pregnancies_previous_show"").html(data);
                }
            });
        } else {
            $('#_pregnancies_previous_show').empty();
        }
    });
    $('#_pregnancy_loss_show').click(function () {
        if ($('#_pregnancies_loss_show').html()=="""") {
            $.ajax({
                url: ""/Records/PregnanciesLoss/Show?Id=");
#nullable restore
#line 246 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                                                  Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""GET"",
                dataType: ""html"",
                success: function (data) {
                    $(""#_pregnancies_loss_show"").html(data);
                }
            });
        } else {
            $('#_pregnancies_loss_show').empty();
        }
    });


        $('#_allergy_show').click(function () {
        if ($('#_allergies_show').html()=="""") {
            $.ajax({
                url: ""/Records/Allergies/Show?Id=");
#nullable restore
#line 262 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                                            Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""GET"",
                dataType: ""html"",
                success: function (data) {
                    $(""#_allergies_show"").html(data);
                }
            });
        } else {
            $('#_allergies_show').empty();
        }
    });

    $('#_partner_show').click(function () {
        if ($('#_partners_show').html()=="""") {
            $.ajax({
                url: ""/Records/Partners/Show?Id=");
#nullable restore
#line 277 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                                           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""GET"",
                dataType: ""html"",
                success: function (data) {
                    $(""#_partners_show"").html(data);
                }
            });
        } else {
            $('#_partners_show').empty();
        }
    });

    $('#_medicalhistory_show').click(function () {
            if ($('#_medicalhistories_show').html()=="""") {
            $.ajax({
                url: ""/Records/MedicalHistories/Show?Id=");
#nullable restore
#line 292 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                                                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""GET"",
                dataType: ""html"",
                success: function (data) {
                    $(""#_medicalhistories_show"").html(data);
                }
            });
        } else {
                $('#_medicalhistories_show').empty();
        }
    });

    $('#_substance_show').click(function () {
        if ($('#_substances_show').html()=="""") {
            $.ajax({
                url: ""/Records/SubstancesUse/Show?Id=");
#nullable restore
#line 307 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                                                Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""GET"",
                dataType: ""html"",
                success: function (data) {
                    $(""#_substances_show"").html(data);
                }
            });
        } else {
            $('#_substances_show').empty();
        }
    });

        $('#_referral_show').click(function () {
        if ($('#_referrals_show').html()=="""") {
            $.ajax({
                url: ""/Records/Referrals/Show?Id=");
#nullable restore
#line 322 "C:\Users\EmirDedic\Desktop\_rs1 za vanju\_rs1 -nova17 -file uploads\_rs1 -nova17 -file uploads\PRENATALv2\PRENATALv2\Areas\Records\Views\MedicalRecords\ShowOne.cshtml"
                                            Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                type: ""GET"",
                dataType: ""html"",
                success: function (data) {
                    $(""#_referrals_show"").html(data);
                }
            });
        } else {
            $('#_referrals_show').empty();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MR> Html { get; private set; }
    }
}
#pragma warning restore 1591
