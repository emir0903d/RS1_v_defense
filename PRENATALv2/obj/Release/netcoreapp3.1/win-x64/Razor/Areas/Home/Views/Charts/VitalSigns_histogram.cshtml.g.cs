#pragma checksum "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Charts\VitalSigns_histogram.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bee404ec41cb83402b39fa4e863f17e211ce23c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Home_Views_Charts_VitalSigns_histogram), @"mvc.1.0.view", @"/Areas/Home/Views/Charts/VitalSigns_histogram.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bee404ec41cb83402b39fa4e863f17e211ce23c", @"/Areas/Home/Views/Charts/VitalSigns_histogram.cshtml")]
    public class Areas_Home_Views_Charts_VitalSigns_histogram : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script type=\"text/javascript\" src=\"https://www.gstatic.com/charts/loader.js\"></script>\r\n<script type=\"text/javascript\" src=\"//ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js\"></script>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Charts\VitalSigns_histogram.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Charts\VitalSigns_histogram.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">

        google.charts.load(""current"", { packages: [""corechart""] });
        google.charts.setOnLoadCallback(drawChart);
        function drawChart() {
            var jsonData = $.ajax({
                url: ""/Home/Charts/GetVSdata?Id=");
#nullable restore
#line 15 "C:\Users\user\Desktop\_rs1 -nova16 -referrals -publishver\_rs1 -nova16 -referrals -publishver\PRENATALv2\PRENATALv2\Areas\Home\Views\Charts\VitalSigns_histogram.cshtml"
                                           Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                dataType: ""json"",
                async: false
            }).responseText;

            var data = new google.visualization.DataTable(jsonData);

            data = google.visualization.arrayToDataTable($.parseJSON(jsonData));


            var options = {
                title: 'Histogram of VitalSigns',
                legend: { position: 'top', maxLines: 8 },
                hAxis: {
                    title: 'date'
                },
                isStacked: true,
                orientation: 'horizontal',
                series: {
                    0: { color: 'black', visibleInLegend: true },
                    1: { color: 'red', visibleInLegend: true },
                    2: { color: 'black', visibleInLegend: true },
                    3: { color: 'red', visibleInLegend: true },
                    4: { color: 'black', visibleInLegend: true },
                    5: { color: 'red', visibleInLegend: true },
                    6: { color: 'black', vis");
            WriteLiteral(@"ibleInLegend: true },
                    7: { color: 'red', visibleInLegend: true },
                    8: { color: 'black', visibleInLegend: true }
                },
                vAxes:{
                    series: {
                        2: {
                            targetAxisIndex: 1
                        }
                    }
                }
            };

                var chart = new google.visualization.Histogram(document.getElementById('chart_div'));
                chart.draw(data, options);
        }
</script>


<div id=""chart_div"" style=""width: 900px; height: 500px;""></div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
