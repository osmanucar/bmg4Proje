#pragma checksum "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Cart\GetOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "436303a79aa063d73f9f88a50a812802e0b81629"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_GetOrders), @"mvc.1.0.view", @"/Views/Cart/GetOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"436303a79aa063d73f9f88a50a812802e0b81629", @"/Views/Cart/GetOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac31612f76d3951e549d2c2432cb6f596241179d", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_GetOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Cart\GetOrders.cshtml"
  
    ViewData["Title"] = "GetOrders";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Orders</h1>\r\n<hr />\r\n\r\n");
#nullable restore
#line 9 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Cart\GetOrders.cshtml"
 foreach(var order in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-bordered table-sm-mb-3"">
        <thead class=""bg-primary text-white"">
            <tr>
                <td colspan=""2""Order Id: #@order.OrderId></td>
                <th>Price</th>
                <th>Quantity</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Cart\GetOrders.cshtml"
             foreach(var orderItem in order.OrderItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td style=\"width:60px;\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "436303a79aa063d73f9f88a50a812802e0b816294755", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 604, "~/img/", 604, 6, true);
#nullable restore
#line 24 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Cart\GetOrders.cshtml"
AddHtmlAttributeValue("", 610, orderItem.ImageUrl, 610, 19, false);

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
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 27 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Cart\GetOrders.cshtml"
               Write(orderItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Cart\GetOrders.cshtml"
               Write(orderItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Cart\GetOrders.cshtml"
               Write(orderItem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Cart\GetOrders.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"2\">Customer Name:</td>\r\n                <td>");
#nullable restore
#line 41 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 41 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Cart\GetOrders.cshtml"
                                Write(order.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td rowspan=\"3\">Total: ");
#nullable restore
#line 42 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Cart\GetOrders.cshtml"
                                  Write(order.TotalPrice());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Adres:</td>\r\n                <td>");
#nullable restore
#line 46 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Phone:</td>\r\n                <td>");
#nullable restore
#line 50 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Email:</td>\r\n                <td>");
#nullable restore
#line 54 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Payment Status:</td>\r\n                <td>");
#nullable restore
#line 58 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.PaymentTypes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\">Order Status:</td>\r\n                <td>");
#nullable restore
#line 62 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Cart\GetOrders.cshtml"
               Write(order.OrderState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 66 "D:\source\repos\TeknolojikAletSatisSitesi\TeknolojikAletSatisSitesi.WebUI\Views\Cart\GetOrders.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
