#pragma checksum "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Shop\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a04145b669e3cfe8c2b6fb7fc946ff58e3b0e7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Details), @"mvc.1.0.view", @"/Views/Shop/Details.cshtml")]
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
#line 1 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\_ViewImports.cshtml"
using TeknolojikAletSatisSitesi.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\_ViewImports.cshtml"
using TeknolojikAletSatisSitesi.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a04145b669e3cfe8c2b6fb7fc946ff58e3b0e7a", @"/Views/Shop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac31612f76d3951e549d2c2432cb6f596241179d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Shop\Details.cshtml"
   
    ViewData["Title"] = "Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-3\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9a04145b669e3cfe8c2b6fb7fc946ff58e3b0e7a3840", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 133, "~/img/", 133, 6, true);
#nullable restore
#line 8 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Shop\Details.cshtml"
AddHtmlAttributeValue("", 139, Model.Product.ImageUrl, 139, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 8 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Shop\Details.cshtml"
AddHtmlAttributeValue("", 169, Model.Product.Name, 169, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n    <div class=\"col-md-9\">\n        <h1 class=\"mb-3\">\n            ");
#nullable restore
#line 12 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Shop\Details.cshtml"
       Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </h1>\n        <hr />\n");
#nullable restore
#line 15 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Shop\Details.cshtml"
         foreach (var category in Model.Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"#\" class=\"btn btn-link p-0 mb-3\">");
#nullable restore
#line 17 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Shop\Details.cshtml"
                                                 Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 18 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Shop\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"mb-3\">\n            <h4 class=\"text-primary mb-3\">\n                ");
#nullable restore
#line 21 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Shop\Details.cshtml"
           Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL\n            </h4>\n            <button type=\"submit\" class=\"btn btn-primary btn-lg\">Add To Cart</button>\n        </div>\n    </div>\n</div>\n\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <p class=\"p-3\">\n            ");
#nullable restore
#line 31 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Shop\Details.cshtml"
       Write(Html.Raw(Model.Product.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591