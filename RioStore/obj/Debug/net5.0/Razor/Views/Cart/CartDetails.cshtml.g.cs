#pragma checksum "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/CartDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33beec9a1c39cc54451cd5d4b5f9c8de713e6588"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_CartDetails), @"mvc.1.0.view", @"/Views/Cart/CartDetails.cshtml")]
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
#line 1 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/_ViewImports.cshtml"
using RioStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/_ViewImports.cshtml"
using RioStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33beec9a1c39cc54451cd5d4b5f9c8de713e6588", @"/Views/Cart/CartDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05e928f0eb6f0d75d8ec306fe3762cc9c6d55093", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_CartDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/CartDetails.cshtml"
  
    var Cart = (Cart)ViewData["CartById"];
    Layout = "_LayoutForDetails"; // to use another layout ,other than the defult, that has been created.


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<br />
<div class=""card mb-3"" style=""max-width: 700px; position: center; margin:0 auto; border:hidden"">
    <div class=""row g-0"">
        <div class=""col-md-4"" style=""position: relative;"">
            <img style="" border-radius: 12px;
        width: 235px;
        height: 250px;
        margin: 0;
        margin-left:10px;
        position: absolute;
        top: 50%;
        -ms-transform: translateY(-50%);
        transform: translateY(-50%);"" src=""https://ezellohub.com/wp-content/uploads/2020/02/y2.jpg"" alt=""..."">
        </div>
        <div class=""col-md-8"">
            <div class=""card-body"" style=""text-align: center; margin-left: 28px;"">
                <h5 class=""card-title"">The Details of Cart Id# ");
#nullable restore
#line 24 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/CartDetails.cshtml"
                                                          Write(Cart.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                <p class=\"card-text\">\n                    It has been ordered by the user Id#   <span style=\"font-weight: bold;\"> ");
#nullable restore
#line 26 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/CartDetails.cshtml"
                                                                                       Write(Cart.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </span>.\n                </p>\n                <p class=\"card-text\">\n                    <span style=\"font-weight: bold;\">Time: </span>\n                    ");
#nullable restore
#line 30 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/CartDetails.cshtml"
               Write(Cart.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </p>\n                <p class=\"card-text\">\n                    <span style=\"font-weight: bold;\">With The Foloowing order: </span>\n                </p>\n");
#nullable restore
#line 35 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/CartDetails.cshtml"
                 foreach (var item in Cart.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text\">\n                        <span style=\"font-weight: bold;\"> - Item Id: </span>\n                        ");
#nullable restore
#line 39 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/CartDetails.cshtml"
                   Write(item.productId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <span style=\"font-weight: bold;\"> | quantity: </span>\n                        ");
#nullable restore
#line 41 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/CartDetails.cshtml"
                   Write(item.quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n");
#nullable restore
#line 43 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/CartDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>

    </div>
    <div style=""position:absolute; margin-left:10px;"">
        <button type=""button"" class=""close"" aria-label=""Close"">
            <a href=""/Cart"" class=""stretched-link"">

            </a>
            <span aria-hidden=""true"">&times;</span>
        </button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
