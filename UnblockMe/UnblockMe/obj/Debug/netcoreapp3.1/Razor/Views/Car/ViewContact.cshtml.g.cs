#pragma checksum "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f812b5e911fc749d996b7a47597ed28104809721"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_ViewContact), @"mvc.1.0.view", @"/Views/Car/ViewContact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f812b5e911fc749d996b7a47597ed28104809721", @"/Views/Car/ViewContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9da95a8eb7ebad05f369e90021df8c2247ebe8a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_ViewContact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ValueTuple<Car, User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewContact.cshtml"
  
    ViewData["Title"] = "View Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<p>\r\n    ");
#nullable restore
#line 8 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewContact.cshtml"
Write(Model.Item1.LicencePlate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 9 "C:\Users\motro\Desktop\New folder\UnblockMe\UnblockMe\Views\Car\ViewContact.cshtml"
Write(Model.Item2.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
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
