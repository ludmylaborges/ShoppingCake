#pragma checksum "C:\Projetos\ShoppingCake\ShoppingCake.MVC\Views\Menu\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "909e104be4c2ed424594f2fa14d53f37dc311a1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Detail), @"mvc.1.0.view", @"/Views/Menu/Detail.cshtml")]
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
#line 1 "C:\Projetos\ShoppingCake\ShoppingCake.MVC\Views\_ViewImports.cshtml"
using ShoppingCake.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos\ShoppingCake\ShoppingCake.MVC\Views\_ViewImports.cshtml"
using ShoppingCake.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"909e104be4c2ed424594f2fa14d53f37dc311a1b", @"/Views/Menu/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85924e1f2316ced71dcbc6075294876e28a12d79", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCake.MVC.Models.Products.ProductModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projetos\ShoppingCake\ShoppingCake.MVC\Views\Menu\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detail</h1>\r\n\r\n<div class=\"row m-auto text-center w-75\">\r\n    <div class=\"img-wrap\"><img");
            BeginWriteAttribute("src", " src=", 191, "", 208, 1);
#nullable restore
#line 9 "C:\Projetos\ShoppingCake\ShoppingCake.MVC\Views\Menu\Detail.cshtml"
WriteAttributeValue("", 196, Model.Image, 196, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n    <div class=\"card-body bg-white mt-0 shadow\">\r\n        <ul class=\"list-unstyled mb-5 position-relative\">\r\n            <li>");
#nullable restore
#line 12 "C:\Projetos\ShoppingCake\ShoppingCake.MVC\Views\Menu\Detail.cshtml"
           Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><b>");
#nullable restore
#line 13 "C:\Projetos\ShoppingCake\ShoppingCake.MVC\Views\Menu\Detail.cshtml"
              Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> R$</li>\r\n            <li><b>50</b> fatias</li>\r\n            <li><b>");
#nullable restore
#line 15 "C:\Projetos\ShoppingCake\ShoppingCake.MVC\Views\Menu\Detail.cshtml"
              Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></li>\r\n        </ul>\r\n        <button type=\"button\" class=\"btn btn-lg btn-block  btn-custom \">Comprar</button>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCake.MVC.Models.Products.ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591