#pragma checksum "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29da711783de57837fe3a8a9f9e46e57eb3324db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_ViewLicencePlate), @"mvc.1.0.view", @"/Views/Car/ViewLicencePlate.cshtml")]
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
#line 1 "F:\Projects\Git\UnblockMe\UnblockMe\Views\_ViewImports.cshtml"
using UnblockMe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\Git\UnblockMe\UnblockMe\Views\_ViewImports.cshtml"
using UnblockMe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29da711783de57837fe3a8a9f9e46e57eb3324db", @"/Views/Car/ViewLicencePlate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9da95a8eb7ebad05f369e90021df8c2247ebe8a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_ViewLicencePlate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Car>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
  
    ViewData["Title"] = "View Licence Plate";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29da711783de57837fe3a8a9f9e46e57eb3324db3441", async() => {
                WriteLiteral(@"
    <style>
        table {
            border-collapse: collapse;
            width: 100%;
        }

        th.buttons {
            width: 0%;
        }

        .ind-buttons {
            color: blue;
            font-size: 85%;
            vertical-align: bottom;
            
            text-align: left;
        }

        th.blocked, th.blocks, th.licence, td.blocked, td.blocks, td.licence {
            padding: 10px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29da711783de57837fe3a8a9f9e46e57eb3324db4956", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n        function Function(c) { console.log(c); }\r\n    </script>\r\n");
#nullable restore
#line 38 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
     if (!(Model.Count == 0))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <table>

            <tr>
                <th class=""licence"">Licence Plate</th>
                <th class=""blocked"">Is blocked by</th>
                <th class=""blocks"">Is blocking</th>
                <th class=""buttons""></th>
            </tr>

");
#nullable restore
#line 49 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td class=\"licence\">");
#nullable restore
#line 52 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
                                   Write(item.LicencePlate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td class=\"blocked\">");
#nullable restore
#line 53 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
                                   Write(item.BockedBy);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td class=\"blocks\">");
#nullable restore
#line 54 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
                                  Write(item.Blocks);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td class=\"buttons\">\r\n                        <div id=\"Edit\" class=\"ind-buttons\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1399, "\"", 1439, 3);
                WriteAttributeValue("", 1409, "Function(\'", 1409, 10, true);
#nullable restore
#line 56 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
WriteAttributeValue("", 1419, item.LicencePlate, 1419, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1437, "\')", 1437, 2, true);
                EndWriteAttribute();
                WriteLiteral(">Edit</div>\r\n\r\n");
#nullable restore
#line 69 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
                         using (Html.BeginForm("RemoveCar", "Car", FormMethod.Post))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <input type=\"hidden\" name=\"text\"");
                BeginWriteAttribute("value", " value=\"", 2269, "\"", 2295, 1);
#nullable restore
#line 71 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
WriteAttributeValue("", 2277, item.LicencePlate, 2277, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input type=\"submit\" class=\"ind-buttons btn btn-link\" value=\"Remove\">\r\n");
#nullable restore
#line 73 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 76 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n");
#nullable restore
#line 79 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h5>None found.</h5>\r\n");
#nullable restore
#line 83 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591
