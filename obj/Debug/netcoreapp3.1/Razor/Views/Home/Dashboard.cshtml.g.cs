#pragma checksum "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f3067c2b759232b1c9c1195d43531ab8c76ed8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/_ViewImports.cshtml"
using ActivityCenter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/_ViewImports.cshtml"
using ActivityCenter.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f3067c2b759232b1c9c1195d43531ab8c76ed8a", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e339c4346f16b3c5483ad512c481a4e17eb8f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Gathering>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ToggleStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-status", "leave", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-status", "join", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n    <a href=\"logout\" class=\"btn btn-lg btn-dark mb-5\">Logout</a>\n    <a href=\"/gathering/new\" class=\"btn btn-lg btn-success mb-5\">Add Activity </a>\n\n            <div class=\"mx-auto\" >\n                <h1 class=\"display\">Hello ");
#nullable restore
#line 11 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
                                     Write(ViewBag.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"! Welcome to Activity Center!</h1>
                <hr>
            </div>
            <div class=""table-responsive-lg"">
                <table class=""table table-hover table-striped border border-primary"">
                    <thead class=""thead bg-primary text-white"">
                        <tr>
                            <th scope=""col"">Activity</th>
                            <th scope=""col"">Date & Time</th>
                            <th scope=""col"">Duration</th>
                            <th scope=""col"">Event Coordinator</th>
                            <th scope=""col""># of Participants</th>
                            <th scope=""col"">Actions</th>
                        </tr>
                    </thead>
                    <tbody class=""table-hover"">
");
#nullable restore
#line 27 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
                         foreach (Gathering g in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td scope=\"col\"><a");
            BeginWriteAttribute("href", " href=\"", 1256, "\"", 1288, 2);
            WriteAttributeValue("", 1263, "/gathering/", 1263, 11, true);
#nullable restore
#line 30 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1274, g.GatheringId, 1274, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
                                                                               Write(g.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n                                <td scope=\"col\">");
#nullable restore
#line 31 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
                                           Write(g.Date.ToString("MM/dd/yy h:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td scope=\"col\">");
#nullable restore
#line 32 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
                                           Write(g.DurationInt);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 32 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
                                                          Write(g.DurationStr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td scope=\"col\">");
#nullable restore
#line 33 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
                                           Write(g.Planner.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
                                                                Write(g.Planner.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td scope=\"col\">");
#nullable restore
#line 34 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
                                           Write(g.Guests.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td scope=\"col\">\n");
#nullable restore
#line 36 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
                                     if(ViewBag.User.UserId == g.Planner.UserId)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1885, "\"", 1924, 3);
            WriteAttributeValue("", 1892, "/gathering/", 1892, 11, true);
#nullable restore
#line 38 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1903, g.GatheringId, 1903, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1917, "/delete", 1917, 7, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\n");
#nullable restore
#line 39 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
                                    }
                                    else
                                    {
                                        if(g.Guests.Any(gl => gl.UserId == ViewBag.User.UserId))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f3067c2b759232b1c9c1195d43531ab8c76ed8a10568", async() => {
                WriteLiteral("Leave");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gatheringId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
                                                                                                                        WriteLiteral(g.GatheringId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gatheringId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gatheringId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gatheringId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-status", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 45 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f3067c2b759232b1c9c1195d43531ab8c76ed8a13767", async() => {
                WriteLiteral("Want to go?");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gatheringId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
                                                                                                                           WriteLiteral(g.GatheringId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gatheringId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gatheringId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gatheringId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-status", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 49 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\n                            </tr>    \n");
#nullable restore
#line 53 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/Dashboard.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Gathering>> Html { get; private set; }
    }
}
#pragma warning restore 1591
