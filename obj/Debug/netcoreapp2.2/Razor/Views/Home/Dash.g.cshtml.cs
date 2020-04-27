#pragma checksum "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Dash.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0bbc7b668cf4b0ec7ad635470a70e0bc8700584"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dash), @"mvc.1.0.view", @"/Views/Home/Dash.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dash.cshtml", typeof(AspNetCore.Views_Home_Dash))]
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
#line 1 "/Users/alexandershvyrev/Desktop/MyProject/Views/_ViewImports.cshtml"
using MyProject;

#line default
#line hidden
#line 2 "/Users/alexandershvyrev/Desktop/MyProject/Views/_ViewImports.cshtml"
using MyProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0bbc7b668cf4b0ec7ad635470a70e0bc8700584", @"/Views/Home/Dash.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6fe18bfd33a53b99196e5f743c625163e36f2af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dash : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Nav", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imageThumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(20, 49, true);
            WriteLiteral("\n\n<div class=\"jumbotron p-0 pb-5 pl-5 pr-5\">\n    ");
            EndContext();
            BeginContext(69, 22, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0bbc7b668cf4b0ec7ad635470a70e0bc87005843993", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(91, 69, true);
            WriteLiteral("\n    <h4 style=\"text-align:center;\">Welcome to All Moviezz database, ");
            EndContext();
            BeginContext(161, 17, false);
#line 7 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Dash.cshtml"
                                                               Write(ViewBag.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(178, 93, true);
            WriteLiteral("!</h4>\n    <h5 style=\"text-align:center;\">Here are 3 recently uploaded movies:</h5>\n    <hr>\n");
            EndContext();
#line 10 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Dash.cshtml"
         foreach(Movie m in Model)
        {
            var ImagePath="~/images/" + (m.ImagePath ?? "skitterphoto.jpg");

#line default
#line hidden
            BeginContext(393, 124, true);
            WriteLiteral("            <div class=\"card mb-3\">\n                <div class=\"card-body\">\n                    <div class=\"card-title\"><h4>");
            EndContext();
            BeginContext(518, 7, false);
#line 15 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Dash.cshtml"
                                           Write(m.Title);

#line default
#line hidden
            EndContext();
            BeginContext(525, 81, true);
            WriteLiteral("</h4></div>\n                    <div class=\"card-image\">\n                        ");
            EndContext();
            BeginContext(606, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0bbc7b668cf4b0ec7ad635470a70e0bc87005846619", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#line 17 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Dash.cshtml"
                                             WriteLiteral(ImagePath);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 17 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Dash.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(678, 73, true);
            WriteLiteral("\n                    </div>\n                    <p><strong>Year </strong>");
            EndContext();
            BeginContext(752, 6, false);
#line 19 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Dash.cshtml"
                                        Write(m.Year);

#line default
#line hidden
            EndContext();
            BeginContext(758, 54, true);
            WriteLiteral("</p>\n                    <p><strong>Director </strong>");
            EndContext();
            BeginContext(813, 10, false);
#line 20 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Dash.cshtml"
                                            Write(m.Director);

#line default
#line hidden
            EndContext();
            BeginContext(823, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 21 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Dash.cshtml"
                      
                        string Rating=$"{m.Rating}";
                    

#line default
#line hidden
            BeginContext(926, 47, true);
            WriteLiteral("                    <p><strong>Rating </strong>");
            EndContext();
            BeginContext(974, 21, false);
#line 24 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Dash.cshtml"
                                          Write(Rating.Substring(0,3));

#line default
#line hidden
            EndContext();
            BeginContext(995, 50, true);
            WriteLiteral("</p>\n                    <p><strong>Cast </strong>");
            EndContext();
            BeginContext(1046, 7, false);
#line 25 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Dash.cshtml"
                                        Write(m.Stars);

#line default
#line hidden
            EndContext();
            BeginContext(1053, 57, true);
            WriteLiteral("</p>\n                    <p><strong>Description </strong>");
            EndContext();
            BeginContext(1111, 13, false);
#line 26 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Dash.cshtml"
                                               Write(m.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1124, 57, true);
            WriteLiteral("</p>\n                    <p><strong>Uploaded on </strong>");
            EndContext();
            BeginContext(1182, 31, false);
#line 27 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Dash.cshtml"
                                               Write(m.CreatedAt.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1213, 47, true);
            WriteLiteral("</p>\n                </div>\n            </div>\n");
            EndContext();
#line 30 "/Users/alexandershvyrev/Desktop/MyProject/Views/Home/Dash.cshtml"
        }

#line default
#line hidden
            BeginContext(1270, 7, true);
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591