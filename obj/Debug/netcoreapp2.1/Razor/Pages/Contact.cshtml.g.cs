#pragma checksum "/Users/paranoid/Projects/VideoStreamingService/VideoStreamingService/Pages/Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bde1dc7177dc2644a6b34a5879d91bb7650e1648"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VideoStreamingService.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Contact.cshtml", typeof(VideoStreamingService.Pages.Pages_Contact), null)]
namespace VideoStreamingService.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/paranoid/Projects/VideoStreamingService/VideoStreamingService/Pages/_ViewImports.cshtml"
using VideoStreamingService;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bde1dc7177dc2644a6b34a5879d91bb7650e1648", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c69779284404c16f2cc264ed0c373d8643af9a52", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/paranoid/Projects/VideoStreamingService/VideoStreamingService/Pages/Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(71, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(76, 17, false);
#line 6 "/Users/paranoid/Projects/VideoStreamingService/VideoStreamingService/Pages/Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(93, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(105, 13, false);
#line 7 "/Users/paranoid/Projects/VideoStreamingService/VideoStreamingService/Pages/Contact.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(118, 117, true);
            WriteLiteral("</h3>\r\n\r\n<address>\r\n    <br />\r\n    <abbr title=\"Email\">E:</abbr>\r\n    hello@videostreamingservice.io\r\n</address>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel>)PageContext?.ViewData;
        public ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
