#pragma checksum "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28aec5cfb156a10094f68b4a38fac7c620e5fe68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayGathering), @"mvc.1.0.view", @"/Views/Home/DisplayGathering.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28aec5cfb156a10094f68b4a38fac7c620e5fe68", @"/Views/Home/DisplayGathering.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e339c4346f16b3c5483ad512c481a4e17eb8f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayGathering : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gathering>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark btn-sm bg-secondary text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ToggleStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-status", "leave", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<a href=\"/logout\" class=\"btn btn-lg btn-dark mb-5\">Logout</a>\n<a href=\"/dashboard\" class=\"btn btn-lg btn-primary mb-5\">Dashboard</a>\n\n<div class=\"card-header bg-primary text-white\">\n    <h3>");
#nullable restore
#line 7 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n</div>\n<div class=\"card-body\">\n    <div class=\"row\">\n        <div class=\"col-sm-8\">\n            <h6><b>Location:</b> ");
#nullable restore
#line 12 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml"
                            Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n            <h6><b>Event Coordinator:</b> ");
#nullable restore
#line 13 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml"
                                     Write(Model.Planner.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n            <h6><b>Date:</b> ");
#nullable restore
#line 14 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml"
                        Write(Model.Date.ToString("dddd, MMMM dd yyyy h:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n            <h6><b>Duration:</b> ");
#nullable restore
#line 15 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml"
                            Write(Model.DurationInt);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml"
                                               Write(Model.DurationStr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n            <h6><b>Description:</b> ");
#nullable restore
#line 16 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml"
                               Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n        </div>\n        <div class=\"col mt-2 \">\n");
#nullable restore
#line 19 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml"
             if (ViewBag.User.UserId == Model.Planner.UserId)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 829, "\"", 872, 3);
            WriteAttributeValue("", 836, "/gathering/", 836, 11, true);
#nullable restore
#line 21 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml"
WriteAttributeValue("", 847, Model.GatheringId, 847, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 865, "/delete", 865, 7, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\n");
#nullable restore
#line 22 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml"
            }
            else
            {
                if (Model.Guests.Any(gl => gl.UserId == ViewBag.User.UserId))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28aec5cfb156a10094f68b4a38fac7c620e5fe688274", async() => {
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
#line 28 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml"
                                   WriteLiteral(Model.GatheringId);

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
#line 29 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28aec5cfb156a10094f68b4a38fac7c620e5fe6811309", async() => {
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
#line 32 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml"
                                                                                           WriteLiteral(Model.GatheringId);

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
#line 34 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"col-sm-4\">\n                <ul class=\"list-group\">\n                    <li class=\"list-group-item bg-dark text-white\">Participants: </li>\n");
#nullable restore
#line 41 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml"
                     foreach (var g in Model.Guests)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item\">");
#nullable restore
#line 43 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml"
                                       Write(g.Participants.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 43 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml"
                                                                 Write(g.Participants.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 44 "/Users/greg/Documents/CodingDojo/C#/EXAM/ActivityCenter/Views/Home/DisplayGathering.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gathering> Html { get; private set; }
    }
}
#pragma warning restore 1591
