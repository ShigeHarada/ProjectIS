#pragma checksum "/home/shige/Project/ProjectIS/ProjectIS/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a0db165e84c12ef1478a3e118ff09ac424c3083"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/home/shige/Project/ProjectIS/ProjectIS/Views/_ViewImports.cshtml"
using ProjectIS;

#line default
#line hidden
#line 2 "/home/shige/Project/ProjectIS/ProjectIS/Views/_ViewImports.cshtml"
using ProjectIS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a0db165e84c12ef1478a3e118ff09ac424c3083", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d61c267a61f26622935f59876278ff06b2a12fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/shige/Project/ProjectIS/ProjectIS/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 502, true);
            WriteLiteral(@"
<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""6000"">
    <ol class=""carousel-indicators"">
        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#myCarousel"" data-slide-to=""1""></li>
        <li data-target=""#myCarousel"" data-slide-to=""2""></li>
        <li data-target=""#myCarousel"" data-slide-to=""3""></li>
    </ol>
    <div class=""carousel-inner"" role=""listbox"">
        <div class=""item active"">
            ");
            EndContext();
            BeginContext(547, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c708cc9fbcb3472ab2f8da7a0c3607d8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/images/banner1.svg");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("src", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral("ASP.NET");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("alt", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral("img-responsive");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("class", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(618, 432, true);
            WriteLiteral(@"
            <div class=""carousel-caption"" role=""option"">
                <p>
                    Learn how to build ASP.NET apps that can run anywhere.
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525028&clcid=0x409"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
        <div class=""item"">
            ");
            EndContext();
            BeginContext(1050, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "85819f91bf744a5d80fea3070a0179db", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/images/banner2.svg");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("src", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral("Visual Studio");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("alt", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral("img-responsive");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("class", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1127, 456, true);
            WriteLiteral(@"
            <div class=""carousel-caption"" role=""option"">
                <p>
                    There are powerful new features in Visual Studio for building modern web apps.
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525030&clcid=0x409"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
        <div class=""item"">
            ");
            EndContext();
            BeginContext(1583, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c82571ae9b94487786e461c33dabe612", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/images/banner3.svg");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("src", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral("Package Management");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("alt", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral("img-responsive");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("class", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1665, 456, true);
            WriteLiteral(@"
            <div class=""carousel-caption"" role=""option"">
                <p>
                    Bring in libraries from NuGet and npm, and automate tasks using Grunt or Gulp.
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525029&clcid=0x409"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
        <div class=""item"">
            ");
            EndContext();
            BeginContext(2121, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "59e0d8005764425ba3f0d5a9715aa10c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/images/banner4.svg");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("src", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral("Microsoft Azure");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("alt", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral("img-responsive");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("class", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2200, 3236, true);
            WriteLiteral(@"
            <div class=""carousel-caption"" role=""option"">
                <p>
                    Learn how Microsoft's Azure cloud platform allows you to build, deploy, and scale web apps.
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525027&clcid=0x409"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
    </div>
    <a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
        <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
        <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>

<div class=""row"">
    <div class=""col-md-3"">
        <h2>Application uses</h2>
        <ul>
            <li>Sam");
            WriteLiteral(@"ple pages using ASP.NET Core MVC</li>
            <li>Theming using <a href=""https://go.microsoft.com/fwlink/?LinkID=398939"">Bootstrap</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>How to</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=398600"">Add a Controller and View</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699315"">Manage User Secrets using Secret Manager.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699316"">Use logging to log a message.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699317"">Add packages using NuGet.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699319"">Target development, staging or production environment.</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>Overview</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=518008"">Conceptual overview o");
            WriteLiteral(@"f what is ASP.NET Core</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699320"">Fundamentals of ASP.NET Core such as Startup and middleware.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=398602"">Working with Data</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=398603"">Security</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=699321"">Client side development</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=699322"">Develop on different platforms</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=699323"">Read more on the documentation site</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>Run &amp; Deploy</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=517851"">Run your app</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=517853"">Run tools such as EF migrations and more<");
            WriteLiteral("/a></li>\r\n            <li><a href=\"https://go.microsoft.com/fwlink/?LinkID=398609\">Publish to Microsoft Azure Web Apps</a></li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
