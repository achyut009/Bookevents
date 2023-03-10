#pragma checksum "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "321427ca81a68837b79a8a7259cbc49601b633fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"321427ca81a68837b79a8a7259cbc49601b633fb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e70d551f249b802a5cfbc79893e502a35af368f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
  
        var datum = ViewData["data"] as IEnumerable<EventModel>;




#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"





<section class="" jumbotron bg-light text-center"">
    <div class=""container"">
        <h1 class=""display-4"">Welcome To Books Events</h1>

        <p class=""lead text-muted"">Lorem ipsum dheujd uejfidjrifbr jdefinkjbcjr vfjrfcjr fhfcjedie jjc</p>
    </div>
</section>

<div class=""py-5 bg-light"">
    <div class=""container"">



        <h3 class=""text-center py-2"">Book Events</h3>
        <div class=""row"">
            <table class=""table table-hover table-dark"">

                    <thead>
                        <tr>
                            <th>
                                Past Events
                            </th>
                            <th>
                                Upcoming Events
                            </th>
                            <th>
                                Type
                            </th>
                            </tr>
                    </thead>
                    <tbody>
                        <tr>
");
#nullable restore
#line 52 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                             if (_signedin.IsSignedIn(User))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 56 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                         foreach (var item in datum)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                             if ((item.Date < DateTime.Now.Date) || ((item.Date == DateTime.Now.Date) && (item.Date.TimeOfDay < DateTime.Now.TimeOfDay)))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"list-unstyled\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "321427ca81a68837b79a8a7259cbc49601b633fb6756", async() => {
                WriteLiteral(" ");
#nullable restore
#line 60 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                                                                                                                                                      Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 61 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                </td>\r\n                                <td>\r\n                                    <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 66 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                         foreach (var item in datum)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                             if ((item.Date > DateTime.Now.Date) || ((item.Date == DateTime.Now.Date) && (item.Date.TimeOfDay > DateTime.Now.TimeOfDay)))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"list-unstyled\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "321427ca81a68837b79a8a7259cbc49601b633fb11092", async() => {
                WriteLiteral(" ");
#nullable restore
#line 70 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                                                                                                                                                      Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 71 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                </td>\r\n                                <td>\r\n                                    <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 76 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                         foreach (var item in datum)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                             if ((item.Date > DateTime.Now.Date) || ((item.Date == DateTime.Now.Date) && (item.Date.TimeOfDay > DateTime.Now.TimeOfDay)))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"list-unstyled\"><a class=\"text-secondary\"> ");
#nullable restore
#line 80 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                                                                                Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 81 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                </td>\r\n");
#nullable restore
#line 84 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                              
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 90 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                         foreach (var item in datum)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                             if ((item.Type == "public" && item.Date < DateTime.Now.Date) || ((item.Date == DateTime.Now.Date) && (item.Date.TimeOfDay < DateTime.Now.TimeOfDay)))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"list-unstyled\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "321427ca81a68837b79a8a7259cbc49601b633fb17589", async() => {
                WriteLiteral(" ");
#nullable restore
#line 94 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                                                                                                                                                      Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 95 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                </td>\r\n                                <td>\r\n                                    <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 100 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                         foreach (var item in datum)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                             if (item.Type == "public" && (item.Date > DateTime.Now.Date) || ((item.Date == DateTime.Now.Date) && (item.Date.TimeOfDay > DateTime.Now.TimeOfDay)))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"list-unstyled\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "321427ca81a68837b79a8a7259cbc49601b633fb21953", async() => {
                WriteLiteral(" ");
#nullable restore
#line 104 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                                                                                                                                                      Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 105 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                </td>\r\n                                <td>\r\n                                    <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 110 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                         foreach (var item in datum)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                             if (item.Type == "public" && (item.Date > DateTime.Now.Date) || ((item.Date == DateTime.Now.Date) && (item.Date.TimeOfDay > DateTime.Now.TimeOfDay)))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"list-unstyled\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "321427ca81a68837b79a8a7259cbc49601b633fb26321", async() => {
                WriteLiteral(" ");
#nullable restore
#line 114 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                                                                                                         Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 115 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                </td>\r\n");
#nullable restore
#line 118 "C:\Users\achyutpandey\Desktop\assignments\BooksEvents\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Identity.SignInManager<UserModel> _signedin { get; private set; }
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
