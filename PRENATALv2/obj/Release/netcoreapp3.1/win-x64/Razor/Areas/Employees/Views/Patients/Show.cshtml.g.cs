#pragma checksum "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63510089c21d371ad26199e6cd3d5ca5c1f181aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Employees_Views_Patients_Show), @"mvc.1.0.view", @"/Areas/Employees/Views/Patients/Show.cshtml")]
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
#line 1 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
using PRENATALv2.Areas.Employees.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63510089c21d371ad26199e6cd3d5ca5c1f181aa", @"/Areas/Employees/Views/Patients/Show.cshtml")]
    public class Areas_Employees_Views_Patients_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Patient>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.min.css"" />
<div class=""container"">
    <div class=""text-left"" style=""vertical-align:middle;"">
        <a href=""/Employees/Patients/Add"" style=""vertical-align:middle; font-size:20px;"" class=""btn fas fa-plus-square d-inline a_icon""></a>

        <h5 style=""vertical-align:middle;"" class=""d-inline""><strong class=""text-uppercase"">ALL PATIENTS:</strong></h5>
    </div>

    <table class=""table"">
        <tr><th>Id</th><th>UserName</th><th>Name</th><th>Surname</th><th>PhoneNumber</th><th>E-mail</th><th>Gender</th><th>Assigned doctor</th><th>MRnumber</th><th>Actions</th></tr>
");
#nullable restore
#line 17 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
         foreach (Patient x in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
               Write(x.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
               Write(x.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
               Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
               Write(x.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
               Write(x.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
               Write(x.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
               Write(x.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 27 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
                 if (x.DoctorId == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>N/A</td>\r\n");
#nullable restore
#line 30 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 33 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
                   Write(x.Doctor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 34 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
                   if (x.MedicalRecordNumber != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><a class=\"btn btn-small\"");
            BeginWriteAttribute("href", " href=\"", 1471, "\"", 1518, 2);
            WriteAttributeValue("", 1478, "/Records/MedicalRecords/ShowOne?Id=", 1478, 35, true);
#nullable restore
#line 38 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
WriteAttributeValue("", 1513, x.Id, 1513, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 38 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
                                                                                                Write(x.MedicalRecordNumber.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n");
#nullable restore
#line 39 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><a class=\"btn btn-small\"");
            BeginWriteAttribute("href", " href=\"", 1688, "\"", 1734, 2);
            WriteAttributeValue("", 1695, "/Records/MedicalRecords/AddOne?Id=", 1695, 34, true);
#nullable restore
#line 42 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
WriteAttributeValue("", 1729, x.Id, 1729, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Create MR</a></td>\r\n");
#nullable restore
#line 43 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    <a class=\"fas fa-edit a_icon\"");
            BeginWriteAttribute("href", " href=\"", 1869, "\"", 1909, 2);
            WriteAttributeValue("", 1876, "/Employees/Patients/Edit?Id=", 1876, 28, true);
#nullable restore
#line 46 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
WriteAttributeValue("", 1904, x.Id, 1904, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                    <a class=\"fas fa-trash-alt a_icon\"");
            BeginWriteAttribute("href", " href=\"", 1971, "\"", 2013, 2);
            WriteAttributeValue("", 1978, "/Employees/Patients/Delete?Id=", 1978, 30, true);
#nullable restore
#line 47 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
WriteAttributeValue("", 2008, x.Id, 2008, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 50 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Employees\Views\Patients\Show.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
