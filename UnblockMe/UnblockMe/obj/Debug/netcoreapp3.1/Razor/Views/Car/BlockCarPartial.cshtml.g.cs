#pragma checksum "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\BlockCarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c7264f98dd81ba27c985df0cc1189cae639ad7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_BlockCarPartial), @"mvc.1.0.view", @"/Views/Car/BlockCarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c7264f98dd81ba27c985df0cc1189cae639ad7f", @"/Views/Car/BlockCarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9da95a8eb7ebad05f369e90021df8c2247ebe8a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_BlockCarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlockCarAuxiliary>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<style>
    .modal {
        position: absolute;
        float: left;
        left: 50%;
        top: 50%;
        transform: translate(-50%, -50%);
    }

    .modal-tall .modal-dialog {
        height: 90%;
    }

    .modal-tall .modal-content {
        height: 100%;
    }

    /* fix SO stick navigation ;) */

</style>

<div class=""modal"" id=""BlockCarPartial"" style=""width:50% "">

    <div class=""moda-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""test"">Block a car</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">
                    <span>X</span>
                </button>
            </div>
            <div class=""modal-body"">
");
#nullable restore
#line 36 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\BlockCarPartial.cshtml"
                 if (Model.OwnCars.Count == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>You dont currently have any cars registered.</p>\r\n");
#nullable restore
#line 39 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\BlockCarPartial.cshtml"
                }
                else
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\BlockCarPartial.cshtml"
                     using (Html.BeginForm("BlockCar", "Car", FormMethod.Get))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n                            <div>\r\n");
#nullable restore
#line 45 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\BlockCarPartial.cshtml"
                                 if (Model.OwnCars.Count > 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <label for=\"SelectedOwnCar\">Select own car</label>\r\n                                    <select id=\"SelectOwnPlate\" name=\"ownCar\">\r\n");
#nullable restore
#line 49 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\BlockCarPartial.cshtml"
                                         foreach (var item in Model.OwnCars)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c7264f98dd81ba27c985df0cc1189cae639ad7f5560", async() => {
#nullable restore
#line 51 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\BlockCarPartial.cshtml"
                                                             Write(item);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\BlockCarPartial.cshtml"
                                               WriteLiteral(item);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 52 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\BlockCarPartial.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </select>\r\n");
#nullable restore
#line 54 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\BlockCarPartial.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"hidden\" id=\"SelectOtherCar\" name=\"otherCar\"");
            BeginWriteAttribute("value", " value=\"", 1921, "\"", 1951, 1);
#nullable restore
#line 57 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\BlockCarPartial.cshtml"
WriteAttributeValue("", 1929, Model.OwnCars.First(), 1929, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 58 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\BlockCarPartial.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <div>\r\n");
#nullable restore
#line 61 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\BlockCarPartial.cshtml"
                                 if (Model.OtherCar == null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <textarea id=\"SelectOtherCar\" name=\"otherCar\">");
#nullable restore
#line 63 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\BlockCarPartial.cshtml"
                                                                             Write(Model.OtherCar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n");
#nullable restore
#line 64 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\BlockCarPartial.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"hidden\" id=\"SelectOtherCar\" name=\"otherCar\"");
            BeginWriteAttribute("value", " value=\"", 2470, "\"", 2493, 1);
#nullable restore
#line 67 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\BlockCarPartial.cshtml"
WriteAttributeValue("", 2478, Model.OtherCar, 2478, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 68 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\BlockCarPartial.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <input type=\"submit\" class=\"btn btn-primary\" value=\"Submit\" />\r\n                        </div>\r\n");
#nullable restore
#line 72 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\BlockCarPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlockCarAuxiliary> Html { get; private set; }
    }
}
#pragma warning restore 1591
