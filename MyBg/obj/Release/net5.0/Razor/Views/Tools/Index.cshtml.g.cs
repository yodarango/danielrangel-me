#pragma checksum "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Tools\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8533eda2a2d7cf84e453fbf947a88df7323c629"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tools_Index), @"mvc.1.0.view", @"/Views/Tools/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8533eda2a2d7cf84e453fbf947a88df7323c629", @"/Views/Tools/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5dbcb0184da424cb338a8e1ab3a5366afac376", @"/Views/_ViewImports.cshtml")]
    public class Views_Tools_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReadingSpeed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tools", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CitationMachine", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Tools\Index.cshtml"
  
    // metatags
    ViewData["MetaDescription"] = "Citation Machine, Reading speed, and more fun tools to help your curiosity and productivity";

    ViewData["OGTitle"] = "Just Some Creative Tools";
    ViewData["OGUrl"] = $"http://danielrangel.me/tools";
    ViewData["OGImage"] = "https://res.cloudinary.com/dq6prlmvh/image/upload/v1643904780/danielrangel.me/logo_lnqtd7.png";
    ViewData["OGType"] = "app";
    ViewData["OGDescription"] = "Citation Machine, Reading speed, and more fun tools to help your curiosity and productivity";
    ViewData["OGSiteName"] = "Daniel Rangel";

    ViewData["TWTitle"] = "Just Some Creative Tools";
    ViewData["TWDescription"] = "Citation Machine, Reading speed, and more fun tools to help your curiosity and productivity";
    ViewData["TWImage"] = "https://res.cloudinary.com/dq6prlmvh/image/upload/v1643904780/danielrangel.me/logo_lnqtd7.png";
    ViewData["TWSite"] = "@Yodarango";
    ViewData["TWCreator"] = "@Yodarango";

    ViewData["Title"] = "Just Some Creative Tools";

    ViewData["MenuBtnTitle"] = "Tool";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main-wrapper tools-wrap"">
    <section class=""post-title-wrapper wrapper-favorite"">
        <span class=""post-type post-type_header--tools std-icon""></span>
        <h1 class=""std-h1 favorites-title"">JUST SOME FUN TOOLS</h1>
    </section>

    <div class=""tool-links-wrapper"">
        <section class=""tool-wrapper"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8533eda2a2d7cf84e453fbf947a88df7323c6295578", async() => {
                WriteLiteral(@"
                <div class=""tool-wrapper-header""><h3 class=""std-h3 h3-tools-title"">CHECK YOUR READING SPEED</h3></div>
                <img src=""/images/tools/reading-speed-thumbnail.png"" alt=""reading speed tool thumbnail"" class=""tool-cover-img"" />
                <div class=""tool-wrapper-info-section"">
                    This fun tool that will measure your reading speed!⚡️
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </section>\r\n        <section class=\"tool-wrapper\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8533eda2a2d7cf84e453fbf947a88df7323c6297445", async() => {
                WriteLiteral(@"
                <div class=""tool-wrapper-header""><h3 class=""std-h3 h3-tools-title"">CITATION MACHINE</h3></div>
                <img src="" /images/tools/citation-machine-thumbnail.png"" alt=""citation machine tool thumbnail"" class=""tool-cover-img"" />
                <div class=""tool-wrapper-info-section"">
                    Citating a source can be tricky. <br />
                    Let me do that for you! 📄
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </section>\r\n    </div>\r\n</div>\r\n");
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
