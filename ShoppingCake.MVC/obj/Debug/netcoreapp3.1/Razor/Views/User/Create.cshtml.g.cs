#pragma checksum "C:\Projetos\ShoppingCake\ShoppingCake.MVC\Views\User\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "487c505390f6faf30a98fb224855e10855687125"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Create), @"mvc.1.0.view", @"/Views/User/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"487c505390f6faf30a98fb224855e10855687125", @"/Views/User/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85924e1f2316ced71dcbc6075294876e28a12d79", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCake.MVC.Models.Users.UserViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Formulario de cadastro</h1>\r\n");
#nullable restore
#line 3 "C:\Projetos\ShoppingCake\ShoppingCake.MVC\Views\User\Create.cshtml"
 using (Html.BeginForm("Save", "User", null, FormMethod.Post)) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("<fieldset>\r\n\r\n    <!-- Text input-->\r\n    <div class=\"form-group\">\r\n        <label class=\"col-md-4 control-label\" for=\"textinput\">Nome</label>\r\n        <div class=\"col-md-4\">\r\n            ");
#nullable restore
#line 10 "C:\Projetos\ShoppingCake\ShoppingCake.MVC\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Name, new { @class = "form-control input-md" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <!-- Text input-->\r\n    <div class=\"form-group\">\r\n        <label class=\"col-md-4 control-label\"");
            BeginWriteAttribute("for", " for=\"", 550, "\"", 556, 0);
            EndWriteAttribute();
            WriteLiteral(">Telefone</label>\r\n        <div class=\"col-md-4\">\r\n            ");
#nullable restore
#line 18 "C:\Projetos\ShoppingCake\ShoppingCake.MVC\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Telephone, new { @class = "form-control input-md" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <!-- Text input-->\r\n    <div class=\"form-group\">\r\n        <label class=\"col-md-4 control-label\"");
            BeginWriteAttribute("for", " for=\"", 835, "\"", 841, 0);
            EndWriteAttribute();
            WriteLiteral(">E-mail</label>\r\n        <div class=\"col-md-4\">\r\n            ");
#nullable restore
#line 26 "C:\Projetos\ShoppingCake\ShoppingCake.MVC\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Email, new { @class = "form-control input-md" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <!-- Text input-->\r\n    <div class=\"form-group\">\r\n        <label class=\"col-md-4 control-label\" for=\"textinput\">Data de Nascimento</label>\r\n        <div class=\"col-md-4\">\r\n            ");
#nullable restore
#line 34 "C:\Projetos\ShoppingCake\ShoppingCake.MVC\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(model => model.BirthDate, new { @class = "form-control input-md" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <!-- Password input-->\r\n    <div class=\"form-group\">\r\n        <label class=\"col-md-4 control-label\"");
            BeginWriteAttribute("for", " for=\"", 1422, "\"", 1428, 0);
            EndWriteAttribute();
            WriteLiteral(">Senha</label>\r\n        <div class=\"col-md-4\">\r\n            ");
#nullable restore
#line 42 "C:\Projetos\ShoppingCake\ShoppingCake.MVC\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Password, new { @class = "form-control input-md", @type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <!-- Password input-->\r\n    <div class=\"form-group\">\r\n        <label class=\"col-md-4 control-label\"");
            BeginWriteAttribute("for", " for=\"", 1727, "\"", 1733, 0);
            EndWriteAttribute();
            WriteLiteral(">Repetir a senha</label>\r\n        <div class=\"col-md-4\">\r\n            ");
#nullable restore
#line 50 "C:\Projetos\ShoppingCake\ShoppingCake.MVC\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(model => model.ConfirmPassword, new { @class = "form-control input-md", @type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <!-- Button -->\r\n    <div class=\"form-group\">\r\n        <label class=\"col-md-4 control-label\"");
            BeginWriteAttribute("for", " for=\"", 2042, "\"", 2048, 0);
            EndWriteAttribute();
            WriteLiteral("></label>\r\n        <div class=\"col-md-4\">\r\n            <button");
            BeginWriteAttribute("id", " id=\"", 2111, "\"", 2116, 0);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2117, "\"", 2124, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" type=\"submit\">Salvar</button>\r\n        </div>\r\n    </div>\r\n\r\n</fieldset>\r\n");
#nullable restore
#line 63 "C:\Projetos\ShoppingCake\ShoppingCake.MVC\Views\User\Create.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCake.MVC.Models.Users.UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591