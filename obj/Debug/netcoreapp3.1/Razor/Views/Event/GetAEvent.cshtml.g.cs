#pragma checksum "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Event\GetAEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a8def070e1a9e6bb556d805cfc15b8212bc7412"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_GetAEvent), @"mvc.1.0.view", @"/Views/Event/GetAEvent.cshtml")]
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
#line 1 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\_ViewImports.cshtml"
using BooksEvents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\_ViewImports.cshtml"
using BooksEvents.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a8def070e1a9e6bb556d805cfc15b8212bc7412", @"/Views/Event/GetAEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e70d551f249b802a5cfbc79893e502a35af368f", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_GetAEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"



<div class=""container"">
    <div class=""row mt-5"">
        <div class=""col-md-6"">
            <div class=""text-center"">
                <img src=""https://picsum.photos/200"" />
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""row"">
                <div class=""col-12"">
                    <h1>");
#nullable restore
#line 21 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Event\GetAEvent.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12 text-primary\">\r\n                    <label class=\"label label-primary\">BY:</label>\r\n                    <label class=\"text-monospace\">");
#nullable restore
#line 27 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Event\GetAEvent.cshtml"
                                             Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <div>\r\n                        <label class=\"text-monospace\">");
#nullable restore
#line 29 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Event\GetAEvent.cshtml"
                                                 Write(Model.OtherDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<label>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-8"">
                    bhbrvhurvh uvirfcirnf ujfijdrjfb uhcirvfrbv lorem ufhrivhcruvbjurfbd jekjdbehhbc hbcujhqdibue dcdjiejdwbsd esjdhwijix
                </div>
                <div class=""col-md-8"">
                    bhbrvhurvh uvirfcirnf ujfijdrjfb uhcirvfrbv lorem ufhrivhcruvbjurfbd jekjdbehhbc hbcujhqdibue dcdjiejdwbsd esjdhwijix
                </div>
            </div>
            <div class=""row"">
            </div>
        </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
