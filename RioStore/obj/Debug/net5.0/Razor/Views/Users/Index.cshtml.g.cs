#pragma checksum "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Users/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0c958a5bbea0c618d0a260a7c8e01547a054b24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c958a5bbea0c618d0a260a7c8e01547a054b24", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05e928f0eb6f0d75d8ec306fe3762cc9c6d55093", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Users/Index.cshtml"
  
    var allUsers = (List<User>)ViewData["Users"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""height:350px; z-index:-1"">
    <div class=""card bg-dark text-white"" style=""position:absolute; top: 23%; left: 48%; transform: translate(-50%, -50%);border:hidden"">
        <img src=""https://img.freepik.com/free-photo/large-group-figurines-people-yellow-background-social-survey-public-opinion_72572-1927.jpg?size=626&ext=jpg"" class=""card-img"" alt=""..."" style=""width:750px;height:350px;"" />
        <div class=""card-img-overlay"">
        </div>
    </div>
    <div style="" height: 100px;
        position: absolute;
        top: 18%;
        left: 48%;
        transform: translate(-50%, -50%);
    "">
        <h1 style=""vertical-align: middle;"">List of all Cotumers</h1>
    </div>
</div>


<br />
<br />

<table class=""table table-hover"">
    <thead style=""background-color: gold; color: white"">
        <tr>
            <th width=""400px"">
                Id
            </th>
            <th width=""400px"">
                Full name
            </th>

            <th width=""400px"">
                Info
     ");
            WriteLiteral("       </th>\n\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 43 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Users/Index.cshtml"
         foreach (var p in allUsers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"align-items:center\">\n                <td style=\"vertical-align: middle;\">\n                    ");
#nullable restore
#line 47 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Users/Index.cshtml"
               Write(p.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td style=\"vertical-align: middle;\">\n                    ");
#nullable restore
#line 50 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Users/Index.cshtml"
               Write(p.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n\n                <td style=\"vertical-align: middle;\">\n                    <button type=\"button\" class=\"btn btn-warning\" style=\"background-color:lightgoldenrodyellow;\">\n                        <a style=\" color: darkgoldenrod\"");
            BeginWriteAttribute("href", " href=\"", 1656, "\"", 1687, 2);
            WriteAttributeValue("", 1663, "/Users/UserDetails/", 1663, 19, true);
#nullable restore
#line 55 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Users/Index.cshtml"
WriteAttributeValue("", 1682, p.Id, 1682, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            Show Details\n                        </a>\n                    </button>\n                </td>\n            </tr>\n");
#nullable restore
#line 61 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/RioStore/RioStore/Views/Users/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
