#pragma checksum "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\AddCar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19be124c04fe60ea01543b61b52bd371c5b26c7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_AddCar), @"mvc.1.0.view", @"/Views/Car/AddCar.cshtml")]
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
#nullable restore
#line 1 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\AddCar.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19be124c04fe60ea01543b61b52bd371c5b26c7c", @"/Views/Car/AddCar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9da95a8eb7ebad05f369e90021df8c2247ebe8a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_AddCar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UnblockMe.Models.Car>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("align-content: center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\AddCar.cshtml"
  
    ViewData["Title"] = "Add Licence Plate";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 11 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\AddCar.cshtml"
 using (Html.BeginForm("AddCar", "Car", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19be124c04fe60ea01543b61b52bd371c5b26c7c4063", async() => {
                WriteLiteral(@"
        <style>

            .box {
                width: 100%;
                float: left;
                margin-right: 10px;
                margin-top: -5px;
                box-sizing: border-box;
                align-content: center;
            }

            span.asterisk {
                color: red;
            }

            html, body {
                height: 100%;
            }

            .wrap {
                padding-top: 20px;
                height: 100%;
                display: flex;
                align-items: center;
                justify-content: center;
            }

            .button {
                width: 140px;
                height: 45px;
                font-family: 'Roboto', sans-serif;
                font-size: 11px;
                text-transform: uppercase;
                letter-spacing: 2.5px;
                font-weight: 500;
                color: #000;
                background-color: #fff;
                border: no");
                WriteLiteral(@"ne;
                border-radius: 45px;
                box-shadow: 0px 8px 15px rgba(0, 0, 0, 0.1);
                transition: all 0.3s ease 0s;
                cursor: pointer;
                outline: none;
            }

                .button:hover {
                    background-color: #2EE59D;
                    box-shadow: 0px 15px 20px rgba(46, 229, 157, 0.4);
                    color: #fff;
                    transform: translateY(-7px);
                }
        </style>

        <h3>Introduce the details of the car that you want to add.</h3>

        <div class=""box"">
            <label style="" float:left; margin-right:20px;"">Licence Plate<span class=""asterisk"">*</span>:</label>
            ");
#nullable restore
#line 71 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\AddCar.cshtml"
       Write(Html.TextBoxFor(x => x.LicencePlate, new { @class = "box", @placeholder = "Licence Plate..." }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            <label style=\" float:left; margin-right:20px;\">Maker: </label>\r\n            ");
#nullable restore
#line 74 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\AddCar.cshtml"
       Write(Html.TextAreaFor(x => x.Maker, new { @class = "box", @placeholder = "Maker..." }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            <label style=\" float:left; margin-right:20px;\">Model: </label>\r\n            ");
#nullable restore
#line 77 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\AddCar.cshtml"
       Write(Html.TextAreaFor(x => x.Model, new { @class = "box", @placeholder = "Model..." }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            <label style=\" float:left; margin-right:20px;\">Colour: </label>\r\n            ");
#nullable restore
#line 80 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\AddCar.cshtml"
       Write(Html.TextAreaFor(x => x.Colour, new { @class = "box", @placeholder = "Colour..." }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            <label style=\" float:left; margin-right:20px;\">Blocks: </label>\r\n            ");
#nullable restore
#line 83 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\AddCar.cshtml"
       Write(Html.TextAreaFor(x => x.Blocks, new { @class = "box", @placeholder = "The licence plate of the car that you are blocking..." }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            <label style=\" float:left; margin-right:20px;\">Blocked by: </label>\r\n            ");
#nullable restore
#line 86 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\AddCar.cshtml"
       Write(Html.TextAreaFor(x => x.BockedBy, new { @class = "box", @placeholder = "The licence plate of the car that blocks you..." }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


            <div class=""warp"" style=""text-align: center; padding-top: 20px"">
                <input type=""submit"" class=""button"" value=""Submit"" />
            </div>

            <p style=""margin-top: 20px"">Every item with <span class=""asterisk"">*</span> is not optional.</p>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 96 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\AddCar.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UnblockMe.Models.Car> Html { get; private set; }
    }
}
#pragma warning restore 1591
