#pragma checksum "D:\.netCore\BusFinal\BusFinal\Views\Home\Trips.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64a1239d123ba5c9367df55ecdfe1174c02f75d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Trips), @"mvc.1.0.view", @"/Views/Home/Trips.cshtml")]
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
#line 1 "D:\.netCore\BusFinal\BusFinal\Views\_ViewImports.cshtml"
using BusFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.netCore\BusFinal\BusFinal\Views\_ViewImports.cshtml"
using BusFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.netCore\BusFinal\BusFinal\Views\_ViewImports.cshtml"
using BusFinal.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.netCore\BusFinal\BusFinal\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64a1239d123ba5c9367df55ecdfe1174c02f75d4", @"/Views/Home/Trips.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c192a4270b812520e3d26a9e2409ad799cdb93da", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Trips : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusFinal.Models.Trip>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TicketBooking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\.netCore\BusFinal\BusFinal\Views\Home\Trips.cshtml"
  
    ViewData["Title"] = "Trips";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Trips</h1>\n\n<p>\n    ");
#nullable restore
#line 10 "D:\.netCore\BusFinal\BusFinal\Views\Home\Trips.cshtml"
Write(ViewBag.pickUp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <i class=\"fas fa-arrow-right\"></i>\n    ");
#nullable restore
#line 12 "D:\.netCore\BusFinal\BusFinal\Views\Home\Trips.cshtml"
Write(ViewBag.dropoff);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n</p>\n<p>\n    ");
#nullable restore
#line 16 "D:\.netCore\BusFinal\BusFinal\Views\Home\Trips.cshtml"
Write(ViewBag.departureDate.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>\n<table id=\"dataTable\" class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 22 "D:\.netCore\BusFinal\BusFinal\Views\Home\Trips.cshtml"
           Write(Html.DisplayName("Departure Time"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "D:\.netCore\BusFinal\BusFinal\Views\Home\Trips.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 28 "D:\.netCore\BusFinal\BusFinal\Views\Home\Trips.cshtml"
           Write(Html.DisplayNameFor(model => model.AvailableSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 31 "D:\.netCore\BusFinal\BusFinal\Views\Home\Trips.cshtml"
           Write(Html.DisplayNameFor(model => model.Bus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 37 "D:\.netCore\BusFinal\BusFinal\Views\Home\Trips.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 40 "D:\.netCore\BusFinal\BusFinal\Views\Home\Trips.cshtml"
           Write(item.StartDateTime.ToString("t"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 43 "D:\.netCore\BusFinal\BusFinal\Views\Home\Trips.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 46 "D:\.netCore\BusFinal\BusFinal\Views\Home\Trips.cshtml"
           Write(Html.DisplayFor(modelItem => item.AvailableSeatsCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 49 "D:\.netCore\BusFinal\BusFinal\Views\Home\Trips.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bus.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64a1239d123ba5c9367df55ecdfe1174c02f75d47556", async() => {
                WriteLiteral("Choose Trip");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tripID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "D:\.netCore\BusFinal\BusFinal\Views\Home\Trips.cshtml"
                                                    WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tripID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tripID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tripID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "D:\.netCore\BusFinal\BusFinal\Views\Home\Trips.cshtml"
                                                                                    WriteLiteral(ViewBag.Passengers);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["passengers"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-passengers", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["passengers"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \n                \n            </td>\n        </tr>\n");
#nullable restore
#line 56 "D:\.netCore\BusFinal\BusFinal\Views\Home\Trips.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusFinal.Models.Trip>> Html { get; private set; }
    }
}
#pragma warning restore 1591
