#pragma checksum "/home/nathan/Desktop/dotnethomepage/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b056afa5ffd0ed0997443b376ad38327effd7881"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(dotnethomepage.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace dotnethomepage.Pages
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
#line 1 "/home/nathan/Desktop/dotnethomepage/Pages/_ViewImports.cshtml"
using dotnethomepage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b056afa5ffd0ed0997443b376ad38327effd7881", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca7834c0fa0f6af5aa5ee7f72124c162ad5224dd", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/nathan/Desktop/dotnethomepage/Pages/Index.cshtml"
  
    ViewData["Title"] = "Nathan's Blog";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <p class=""sub-header"">
        I suggest checking out the <a href=""/about"" class=""link-text"">about</a> page for a summary.
    </p>
    <p class=""sub-header"">
        My email is <a href=""mailto:nathan@nr5p.com"" class=""link-text"">nathan@nr5p.com</a>.
    </p class=""sub-header"">
        Download my <a href=""/images/Nathan_Rigg_Resume.pdf"" target = ""_blank"" class=""link-text"" id=""resume-text"">resume here</a>
    </p>
    ");
#nullable restore
#line 16 "/home/nathan/Desktop/dotnethomepage/Pages/Index.cshtml"
Write(await Html.PartialAsync("_BlogPostsPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
