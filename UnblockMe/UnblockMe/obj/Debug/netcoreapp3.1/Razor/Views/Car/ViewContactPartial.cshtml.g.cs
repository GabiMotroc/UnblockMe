#pragma checksum "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4c2d458477693485ee2d952a9b988fbec219912"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4c2d458477693485ee2d952a9b988fbec219912", @"/Views/Car/ViewContactPartial.cshtml")]
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
            WriteLiteral("                            <h4>Car</h4>\r\n                            <hr />\r\n");
#nullable restore
#line 31 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                             if (Model.Item1.Photo != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                                 if (Model.Item1.Photo.Photo != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 1180, "\"", 1232, 2);
            WriteAttributeValue("", 1186, "data:image/png;base64,", 1186, 22, true);
#nullable restore
#line 35 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
WriteAttributeValue("", 1208, Model.Item1.Photo.Photo, 1208, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 36 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <dl class=\"row\">\r\n                                    <dt class=\"col-sm-2\">\r\n                                        ");
#nullable restore
#line 40 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Item1.Maker));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-10\">\r\n                                        ");
#nullable restore
#line 43 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                                   Write(Html.DisplayFor(model => model.Item1.Maker));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt class=\"col-sm-2\">\r\n                                        ");
#nullable restore
#line 46 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Item1.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-10\">\r\n                                        ");
#nullable restore
#line 49 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                                   Write(Html.DisplayFor(model => model.Item1.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt class=\"col-sm-2\">\r\n                                        ");
#nullable restore
#line 52 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Item1.Colour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-10\">\r\n                                        ");
#nullable restore
#line 55 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                                   Write(Html.DisplayFor(model => model.Item1.Colour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt class=\"col-sm-2\">\r\n                                        ");
#nullable restore
#line 58 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Item1.BockedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-10\">\r\n                                        ");
#nullable restore
#line 61 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                                   Write(Html.DisplayFor(model => model.Item1.BockedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt class=\"col-sm-2\">\r\n                                        ");
#nullable restore
#line 64 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Item1.Blocks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-10\">\r\n                                        ");
#nullable restore
#line 67 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
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
#line 75 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Item2.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-10\">\r\n                                        ");
#nullable restore
#line 78 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                                   Write(Html.DisplayFor(model => model.Item2.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt class=\"col-sm-2\">\r\n                                        ");
#nullable restore
#line 81 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Item2.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-10\">\r\n                                        ");
#nullable restore
#line 84 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                                   Write(Html.DisplayFor(model => model.Item2.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt class=\"col-sm-2\">\r\n                                        ");
#nullable restore
#line 87 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Item2.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd class=\"col-sm-10\">\r\n                                        ");
#nullable restore
#line 90 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                                   Write(Html.DisplayFor(model => model.Item2.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </dd>\r\n                                </dl>\r\n");
#nullable restore
#line 93 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <p>The slected car is not registered.</p>
                                <p>You can help extend our reach by sharing. </p>
                                <button class=""btn btn-primary"" onclick=""copyToClipboard('https://localhost:44333/')"">Copy site adress</button>
");
#nullable restore
#line 99 "F:\Projects\Git\UnblockMe\UnblockMe\Views\Car\ViewContactPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
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
