#pragma checksum "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d652cb8410e8fe97fa2c56dd493e312c5ce349f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_ViewContactPartial), @"mvc.1.0.view", @"/Views/Car/ViewContactPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d652cb8410e8fe97fa2c56dd493e312c5ce349f", @"/Views/Car/ViewContactPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9da95a8eb7ebad05f369e90021df8c2247ebe8a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_ViewContactPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ValueTuple<Car, User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
    <style>
        .modal {
            position: absolute;
            float: left;
            left: 50%;
            top: 50%;
            transform: translate(-50%, -50%);
        }
    </style>

    <div class=""modal"" id=""ViewContact"" style=""width:50%; align-content:center "">

        <div class=""moda-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"" id=""test"">Contact details</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">
                        <span>X</span>
                    </button>
                </div>
                
                <div class=""modal-body"">
                    <div>
");
#nullable restore
#line 27 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
 if (!Model.Equals(default))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h4>Car</h4>\r\n                        <hr />\r\n                        <dl class=\"row\">\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 33 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                           Write(Html.DisplayNameFor(model => model.Item1.Maker));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 36 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                           Write(Html.DisplayFor(model => model.Item1.Maker));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 39 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                           Write(Html.DisplayNameFor(model => model.Item1.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 42 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                           Write(Html.DisplayFor(model => model.Item1.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 45 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                           Write(Html.DisplayNameFor(model => model.Item1.Colour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 48 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                           Write(Html.DisplayFor(model => model.Item1.Colour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 51 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                           Write(Html.DisplayNameFor(model => model.Item1.BockedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 54 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                           Write(Html.DisplayFor(model => model.Item1.BockedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 57 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                           Write(Html.DisplayNameFor(model => model.Item1.Blocks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 60 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                           Write(Html.DisplayFor(model => model.Item1.Blocks));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </dd>

                        </dl>
                        <h4>Owner</h4>
                        <hr />
                        <dl class=""row"">
                            <dt class=""col-sm-2"">
                                ");
#nullable restore
#line 68 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                           Write(Html.DisplayNameFor(model => model.Item2.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 71 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                           Write(Html.DisplayFor(model => model.Item2.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 74 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                           Write(Html.DisplayNameFor(model => model.Item2.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 77 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                           Write(Html.DisplayFor(model => model.Item2.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 80 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                           Write(Html.DisplayNameFor(model => model.Item2.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 83 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                           Write(Html.DisplayFor(model => model.Item2.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                        </dl>\r\n");
#nullable restore
#line 86 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
}
else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>The slected car is not registered.</p>\r\n                <p>You can help extend ourreach by sharing. </p>\r\n                <button class=\"btn btn-primary\" onclick=\"copyToClipboard(\'https://localhost:44333/\')\">Copy site adress</button>\r\n");
#nullable restore
#line 92 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>

                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ValueTuple<Car, User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
