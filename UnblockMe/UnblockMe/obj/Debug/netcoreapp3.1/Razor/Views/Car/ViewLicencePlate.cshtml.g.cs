#pragma checksum "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17ac290cc32cec7228b33682c5b4088102f550d4"
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
#line 1 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\_ViewImports.cshtml"
using UnblockMe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\_ViewImports.cshtml"
using UnblockMe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17ac290cc32cec7228b33682c5b4088102f550d4", @"/Views/Car/ViewLicencePlate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9da95a8eb7ebad05f369e90021df8c2247ebe8a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_ViewLicencePlate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Car>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportCarsCSV", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Car", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
  
    ViewData["Title"] = "View Licence Plate";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17ac290cc32cec7228b33682c5b4088102f550d44965", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <style>
        .btn{
            
        }
        table {
            border-collapse: collapse;
            width: 100%;
        }

        th.buttons {
            width: 0%;
            padding: 0;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17ac290cc32cec7228b33682c5b4088102f550d46732", async() => {
                WriteLiteral("\r\n    <div id=\"PlaceHolderHere\"></div>\r\n");
#nullable restore
#line 41 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
     if (!(Model.Count == 0) && (!Model.Equals(null)))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <table>

            <tr>
                <th class=""licence"">Licence Plate</th>
                <th class=""blocked"">Is blocked by</th>
                <th class=""blocks"">Is blocking</th>
                <th class=""buttons"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17ac290cc32cec7228b33682c5b4088102f550d47568", async() => {
                    WriteLiteral("Download Cars");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <button class=\"btn btn-link\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1420, "\"", 1476, 5);
                WriteAttributeValue("", 1430, "location.href", 1430, 13, true);
                WriteAttributeValue(" ", 1443, "=", 1444, 2, true);
                WriteAttributeValue(" ", 1445, "\'", 1446, 2, true);
#nullable restore
#line 51 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
WriteAttributeValue("", 1447, Url.Action("AddCar", "Car"), 1447, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1475, "\'", 1475, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <i class=\"fa fa-plus\" style=\"color:lawngreen\" aria-hidden=\"true\"></i>\r\n                    </button>\r\n                </th>\r\n            </tr>\r\n\r\n");
#nullable restore
#line 57 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td class=\"licence\">\r\n                        <button type=\"button\" class=\"btn btn-link\" data-toggle=\"ajax-modal\" data-target=\"#Car\"\r\n                                data-url=\"");
#nullable restore
#line 62 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
                                     Write(Url.Action("ViewContact", "Car", new { text=item.LicencePlate }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-id=\"");
#nullable restore
#line 62 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
                                                                                                                 Write(item.LicencePlate);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                            ");
#nullable restore
#line 63 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
                       Write(item.LicencePlate);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </button>

                    </td>

                    <td class=""blocked"">
                        <button type=""button"" class=""btn btn-link"" data-toggle=""ajax-modal"" data-target=""#Car""
                                data-url=""");
#nullable restore
#line 70 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
                                     Write(Url.Action("ViewContact", "Car", new { text=item.BockedBy }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-id=\"");
#nullable restore
#line 70 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
                                                                                                             Write(item.LicencePlate);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                            ");
#nullable restore
#line 71 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
                       Write(item.BockedBy);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </button>
                    </td>
                    <td class=""blocks"">
                        <button type=""button"" class=""btn btn-link"" data-toggle=""ajax-modal"" data-target=""#Car""
                                data-url=""");
#nullable restore
#line 76 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
                                     Write(Url.Action("ViewContact", "Car", new { text=item.Blocks }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-id=\"");
#nullable restore
#line 76 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
                                                                                                           Write(item.LicencePlate);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                            ");
#nullable restore
#line 77 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
                       Write(item.Blocks);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </button>
                    </td>
                    <td class=""buttons"">
                        <div id=""PlaceHolderHere""></div>
                        <button type=""button"" class=""btn btn-link"" data-toggle=""ajax-modal"" data-target=""#Car""
                                data-url=""");
#nullable restore
#line 83 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
                                     Write(Url.Action("EditCar", "Car", new { text=item.LicencePlate }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-id=\"");
#nullable restore
#line 83 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
                                                                                                             Write(item.LicencePlate);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                            <i class=\"fa fa-edit\"></i>\r\n                        </button>\r\n                        \r\n");
#nullable restore
#line 87 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
                         using (Html.BeginForm("RemoveCar", "Car", FormMethod.Post))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <input type=\"hidden\" name=\"text\"");
                BeginWriteAttribute("value", " value=\"", 3562, "\"", 3588, 1);
#nullable restore
#line 89 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
WriteAttributeValue("", 3570, item.LicencePlate, 3570, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <button type=\"submit\" class=\"btn btn-link\">\r\n                                <i class=\"fa fa-trash\" style=\"color:red\" aria-hidden=\"true\"></i>\r\n                            </button>\r\n");
#nullable restore
#line 93 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 96 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n");
#nullable restore
#line 99 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h5>None found.</h5>\r\n");
#nullable restore
#line 103 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewLicencePlate.cshtml"
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
