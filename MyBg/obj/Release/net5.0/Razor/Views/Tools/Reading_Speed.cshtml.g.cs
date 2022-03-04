#pragma checksum "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Tools\Reading_Speed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac6e7519f659e45adcc1527ce9bdd476dc4250b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tools_Reading_Speed), @"mvc.1.0.view", @"/Views/Tools/Reading_Speed.cshtml")]
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
#line 1 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\_ViewImports.cshtml"
using MyBg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\_ViewImports.cshtml"
using MyBg.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac6e7519f659e45adcc1527ce9bdd476dc4250b0", @"/Views/Tools/Reading_Speed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5dbcb0184da424cb338a8e1ab3a5366afac376", @"/Views/_ViewImports.cshtml")]
    public class Views_Tools_Reading_Speed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReadingSpeed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tools", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("reset-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Tools\Reading_Speed.cshtml"
  
    // metatags
    ViewData["MetaDescription"] = "Measure your reading speed";

    ViewData["OGTitle"] = "Reading Speed Machine";
    ViewData["OGUrl"] = $"http://danielrangel.me/ReadingSpeed";
    ViewData["OGImage"] = "https://res.cloudinary.com/dq6prlmvh/image/upload/v1643904737/danielrangel.me/tools/reading-speed-thumbnail_olnyv6.png";
    ViewData["OGType"] = "app";
    ViewData["OGDescription"] = "Measure your reading speed";
    ViewData["OGSiteName"] = "Daniel Rangel";

    ViewData["TWTitle"] = "Reading Speed Machine";
    ViewData["TWDescription"] = "Measure your reading speed";
    ViewData["TWImage"] = "https://res.cloudinary.com/dq6prlmvh/image/upload/v1643904737/danielrangel.me/tools/reading-speed-thumbnail_olnyv6.png";
    ViewData["TWSite"] = "@Yodarango";
    ViewData["TWCreator"] = "@Yodarango";

    ViewData["Title"] = "Reading Speed Machine";

    ViewData["MenuBtnTitle"] = "Tool";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main-wrapper""> 
    <section class=""post-title-wrapper wrapper-favorite"">
        <span class=""post-type post-type_header--reading-speed std-icon""></span>
        <h1 class=""std-h1 favorites-title"">TEST YOUR READING SPEED</h1>
    </section>

    <section class=""reader-wrapper"">
        <div class=""reader-header"">
            <h3 class=""std-h3 h3-reader-title"">Select an animal to read about</h3>
            <div class=""topics-wrapper"">
                <span class=""std-icon reader-topic-icon"" onclick=""choseTopic('wolf')"" id=""button-wolf"">Wolf🐺</span>
                <span class=""std-icon reader-topic-icon"" onclick=""choseTopic('eagle')"" id=""button-eagle"">Eagle 🦅</span>
                <span class=""std-icon reader-topic-icon"" onclick=""choseTopic('rhino')"" id=""button-rhino"">Rhino 🦏</span>
                <span class=""std-icon reader-topic-icon"" onclick=""choseTopic('bison')"" id=""button-bison"">Bison 🦬</span>
                <span class=""std-icon reader-topic-icon"" onclick=""choseTopic('");
            WriteLiteral(@"mammoth')"" id=""button-mammoth"">Mammoth 🦣</span>
                <span class=""std-icon reader-topic-icon"" onclick=""choseTopic('mamba')"" id=""button-mamba"">Mamba 🐍</span>
                <span class=""std-icon reader-topic-icon"" onclick=""choseTopic('shark')"" id=""button-shark"">Shark 🦈</span>
            </div>
        </div>
        <p class=""reader-text-box""></p>
        <div class=""container"">
            <div class=""box"">
                <div class=""clock""></div>
            </div>
        </div>
        <div class=""botton-wrapper"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac6e7519f659e45adcc1527ce9bdd476dc4250b06813", async() => {
                WriteLiteral(" <span class=\"read-reset std-icon\"></span>RESET");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <button class=""reset-button"" onclick=""startReading()""> <span class=""read-start std-icon""></span>START</button>
            <button class=""reset-button"" onclick=""stopReading()""><span class=""read-stop std-icon""></span>STOP</button>
        </div>
    </section>

    <div class=""reading-result-wrapper"">
        <h3 class=""std-h3 h3-reader-title"">Your results: </h3>
        <div class=""reading-results-img""></div>
        <div class=""std-p reading-time-result"" id=""reading-time-result"">
            <p class=""reading-time-result_important"" id=""reading-time-result_top-p""></p>
            <p class=""std-p"" id=""reading-time-result_bottom-p""></p>
        </div>

        <h3 class=""std-h3"">Share it on your social </h3>
        <p class=""std-p "">Click the button below to expand it and take a screenshot!😊</p>
        <button class=""std-button share-results-button"" onclick=""expandResults()"">Expand</button>
    </div>

    <div class=""reading-result-wrapper-fulls"">
        <h3 class=""std-h3 h");
            WriteLiteral(@"3-reader-title"">MY READING SPEED IS</h3>
        <div class=""reading-results-img""></div>
        <div class=""std-p reading-time-result"" id=""reading-time-result"">
            <h3 class=""reading-time-result_important"" id=""reading-time-result_top-p-fulls""></h3>
        </div>

        <p class=""std-p "">Take yours at danielrangel.me/tools 😊</p>
        <button class=""std-button share-results-button"" onclick=""closeResults()"">Exit</button>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/js/reading-speed.js\"></script>\r\n");
            }
            );
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