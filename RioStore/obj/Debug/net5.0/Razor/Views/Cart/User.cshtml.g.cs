#pragma checksum "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7561b0415ac993533e8e961cc019297eeca3ddb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_User), @"mvc.1.0.view", @"/Views/Cart/User.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7561b0415ac993533e8e961cc019297eeca3ddb5", @"/Views/Cart/User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05e928f0eb6f0d75d8ec306fe3762cc9c6d55093", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_User : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/User.cshtml"
  
    var CartsByUserId = (List<Cart>)ViewData["CartsByUserId"];
    Layout = "_LayoutForDetails";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<br />\n<br />\n\n<br />\n<div class=\"card mb-3\" style=\"max-width: 700px; position: center; margin:0 auto; border:hidden\">\n");
#nullable restore
#line 15 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/User.cshtml"
     foreach (var p in CartsByUserId)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div>
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
#line 33 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/User.cshtml"
                                                              Write(p.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <p class=\"card-text\">\n                        It has been ordered by the user Id#   <span style=\"font-weight: bold;\"> ");
#nullable restore
#line 35 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/User.cshtml"
                                                                                           Write(p.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </span>.\n                    </p>\n                    <p class=\"card-text\">\n                        <span style=\"font-weight: bold;\">Time: </span>\n                        ");
#nullable restore
#line 39 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/User.cshtml"
                   Write(p.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                    <p class=\"card-text\">\n                        <span style=\"font-weight: bold;\">With The Foloowing order: </span>\n                    </p>\n");
#nullable restore
#line 44 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/User.cshtml"
                     foreach (var item in p.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"card-text\">\n                            <span style=\"font-weight: bold;\"> - Item Id: </span>\n                            ");
#nullable restore
#line 48 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/User.cshtml"
                       Write(item.productId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <span style=\"font-weight: bold;\"> | quantity: </span>\n                            ");
#nullable restore
#line 50 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/User.cshtml"
                       Write(item.quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </p>\n");
#nullable restore
#line 52 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/User.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
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
        <br />
");
#nullable restore
#line 68 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Cart/User.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n\n\n");
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