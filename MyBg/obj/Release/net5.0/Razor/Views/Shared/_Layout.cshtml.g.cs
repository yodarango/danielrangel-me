#pragma checksum "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d55f34d8fc1c34fa81e50e3943c6c2570c4bba2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d55f34d8fc1c34fa81e50e3943c6c2570c4bba2d", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5dbcb0184da424cb338a8e1ab3a5366afac376", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/global.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("global-wrapper"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d55f34d8fc1c34fa81e50e3943c6c2570c4bba2d6655", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""keywords""
          content=""bible, word of God, Jesus Christ, Daniel Rangel, Christian, Theology, apologetics, Technology, Tech, Developer, Software Engineer"" />
    <meta name=""description""");
                BeginWriteAttribute("content", "\r\n          content=\"", 343, "\"", 393, 2);
#nullable restore
#line 9 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 364, ViewData["MetaDescription"], 364, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 392, "", 393, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" />
    <meta name=""robots"" content=""index,follow"" />
    <meta name=""url"" content=""http://www.danielrangel.me"" />
    <meta name=""identifier-URL""
          content=""http://www.danielrangel.me"" />

    <!--Change this-->
    <meta name=""directory"" content=""submission"" />
    <meta name=""category"" content=""Blog"" />
    <meta name=""coverage"" content=""Worldwide"" />
    <meta name=""rating"" content=""General"" />

    <!-- OG TAGS -->
    <meta name=""og:title""");
                BeginWriteAttribute("content", " content=\"", 864, "\"", 895, 2);
#nullable restore
#line 22 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 874, ViewData["OGTitle"], 874, 20, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 894, "", 895, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta property=\"og:url\"");
                BeginWriteAttribute("content", " content=\"", 928, "\"", 958, 2);
#nullable restore
#line 23 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 938, ViewData["OGUrl "], 938, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 957, "", 958, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <!--Change this-->\r\n    <meta property=\"og:image\"");
                BeginWriteAttribute("content", " content=\"", 1019, "\"", 1050, 2);
#nullable restore
#line 26 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1029, ViewData["OGImage"], 1029, 20, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1049, "", 1050, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <!--Change this-->\r\n    <meta property=\"og:type\"");
                BeginWriteAttribute("content", " content=\"", 1108, "\"", 1138, 2);
#nullable restore
#line 28 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1118, ViewData["OGType"], 1118, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1137, "", 1138, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta property=\"og:description\"");
                BeginWriteAttribute("content", "\r\n          content=\"", 1179, "\"", 1227, 2);
#nullable restore
#line 30 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1200, ViewData["OGDescription"], 1200, 26, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1226, "", 1227, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta property=\"og:locale\" content=\"en_GB\" />\r\n    <meta name=\"og:site_name\"");
                BeginWriteAttribute("content", " content=\"", 1313, "\"", 1346, 1);
#nullable restore
#line 32 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1323, ViewData["OGSiteName"], 1323, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
    <meta property=”article:author” content=""https://danielrangel.com/me"" />

    <!--Change this-->
    <meta name=""og:region"" content=""TN"" />

    <!--Change this-->
    <meta name=""og:postal-code"" content=""37777"" />

    <!--Change this-->
    <meta name=""og:country-name"" content=""USA"" />

    <!--Change this-->
    <!-- BLOG CATALOG -->
    <meta name=""blogcatalog"" />

    <!--Twitter Tags-->
    <meta name=""twitter:title""");
                BeginWriteAttribute("content", " content=\"", 1798, "\"", 1828, 1);
#nullable restore
#line 49 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1808, ViewData["TWTitle"], 1808, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"twitter:description\"");
                BeginWriteAttribute("content", " content=\"", 1868, "\"", 1904, 1);
#nullable restore
#line 50 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1878, ViewData["TWDescription"], 1878, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"twitter:image\"");
                BeginWriteAttribute("content", " content=\"", 1938, "\"", 1968, 1);
#nullable restore
#line 51 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1948, ViewData["TWImage"], 1948, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"twitter:site\"");
                BeginWriteAttribute("content", " content=\"", 2001, "\"", 2030, 1);
#nullable restore
#line 52 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2011, ViewData["TWSite"], 2011, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"twitter:creator\"");
                BeginWriteAttribute("content", " content=\"", 2066, "\"", 2098, 1);
#nullable restore
#line 53 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2076, ViewData["TWCreator"], 2076, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0 maximum-scale=1\" />\r\n\r\n    <title>");
#nullable restore
#line 57 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | Daniel Rangel</title>\r\n\r\n    <link rel=\"icon\" type=\"image/x-icon\" href=\"/images/logo.png\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d55f34d8fc1c34fa81e50e3943c6c2570c4bba2d14134", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
                WriteLiteral(@"    <script async src=""https://www.googletagmanager.com/gtag/js?id=G-D1H2VVPPTM""></script>
    <script>
        window.dataLayer = window.dataLayer || [];
        function gtag() { dataLayer.push(arguments); }
        gtag('js', new Date());

        gtag('config', 'G-D1H2VVPPTM');
    </script>

    ");
#nullable restore
#line 72 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
Write(ViewData["Styles"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d55f34d8fc1c34fa81e50e3943c6c2570c4bba2d16591", async() => {
                WriteLiteral("\r\n    <header>\r\n    </header>\r\n\r\n    <main role=\"main\" class=\"page-wrapper\">\r\n        ");
#nullable restore
#line 79 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"bottom-spacer\"></div>\r\n    </main>\r\n\r\n");
#nullable restore
#line 84 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
      string currViewHome = "";
        string currViewBlogs = "";
        string currViewFavorites = "";
        string currViewTools = "";

        string viewDataHome = ViewData["MenuBtnTitle"].ToString();
        if (viewDataHome.Contains("Home"))
        {
            currViewHome = "view-home";
        }
        else if (viewDataHome.Contains("Favorite"))
        {
            currViewBlogs = "view-favorites";
        }
        else if (viewDataHome.Contains("Article"))
        {
            currViewFavorites = "view-blogs";
        }
        else if (viewDataHome.Contains("Tool"))
        {
            currViewTools = "view-tools";
        }

        string newClassHome = currViewHome;
        string newClassBlog = currViewBlogs;
        string newClassFavorite = currViewFavorites;
        string newClassTool = currViewTools;
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <section class=\"nav-wrapper\">\r\n        <nav class=\"menu\">\r\n            <span");
                BeginWriteAttribute("class", " class=\"", 4000, "\"", 4038, 3);
                WriteAttributeValue("", 4008, "menu-button", 4008, 11, true);
                WriteAttributeValue(" ", 4019, "home", 4020, 5, true);
#nullable restore
#line 114 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 4024, newClassHome, 4025, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"menu-bttn\" onclick=\"menuRedirect(\'/home\')\"></span>\r\n            <span");
                BeginWriteAttribute("class", " class=\"", 4113, "\"", 4156, 3);
                WriteAttributeValue("", 4121, "menu-button", 4121, 11, true);
                WriteAttributeValue(" ", 4132, "favorites", 4133, 10, true);
#nullable restore
#line 115 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 4142, newClassBlog, 4143, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"menu-bttn\" onclick=\"menuRedirect(\'/favorites\')\"></span>\r\n            <span");
                BeginWriteAttribute("class", " class=\"", 4236, "\"", 4278, 3);
                WriteAttributeValue("", 4244, "menu-button", 4244, 11, true);
                WriteAttributeValue(" ", 4255, "blog", 4256, 5, true);
#nullable restore
#line 116 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 4260, newClassFavorite, 4261, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"menu-bttn\" onclick=\"menuRedirect(\'/articles\')\"></span>\r\n            <span");
                BeginWriteAttribute("class", " class=\"", 4357, "\"", 4396, 3);
                WriteAttributeValue("", 4365, "menu-button", 4365, 11, true);
                WriteAttributeValue(" ", 4376, "tools", 4377, 6, true);
#nullable restore
#line 117 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 4382, newClassTool, 4383, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"menu-bttn\" onclick=\"menuRedirect(\'/tools\')\"></span>\r\n        </nav>\r\n    </section>\r\n\r\n");
                WriteLiteral(@"    <button class=""menu-button-desktop--trigger"" id=""menu-button""></button>
    <button class=""theme-button"" id=""theme-button"" onclick=""openThemeSelector()""></button>
    <div class=""std-bkg-layer"" id=""dark-layer""></div>
    <nav class=""menu--desktop"" id=""menu-wrapper"">
        <div id=""menu-bttn"" onclick=""menuRedirect('/')"">
            <span");
                BeginWriteAttribute("class", " class=\"", 4922, "\"", 4980, 4);
                WriteAttributeValue("", 4930, "menu-button", 4930, 11, true);
                WriteAttributeValue(" ", 4941, "menu-button-desktop", 4942, 20, true);
                WriteAttributeValue(" ", 4961, "home", 4962, 5, true);
#nullable restore
#line 127 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 4966, newClassHome, 4967, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></span>\r\n            <h4 class=\"std-h4 menu-button--home\">HOME</h4>\r\n        </div>\r\n        <div id=\"menu-bttn\" onclick=\"menuRedirect(\'/favorites\')\">\r\n            <span");
                BeginWriteAttribute("class", " class=\"", 5151, "\"", 5214, 4);
                WriteAttributeValue("", 5159, "menu-button", 5159, 11, true);
                WriteAttributeValue(" ", 5170, "menu-button-desktop", 5171, 20, true);
                WriteAttributeValue(" ", 5190, "favorites", 5191, 10, true);
#nullable restore
#line 131 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 5200, newClassBlog, 5201, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></span>\r\n            <h4 class=\"std-h4 menu-button--favorite\">FAVORITES</h4>\r\n        </div>\r\n        <div id=\"menu-bttn\" onclick=\"menuRedirect(\'/articles\')\">\r\n            <span");
                BeginWriteAttribute("class", " class=\"", 5393, "\"", 5455, 4);
                WriteAttributeValue("", 5401, "menu-button", 5401, 11, true);
                WriteAttributeValue(" ", 5412, "menu-button-desktop", 5413, 20, true);
                WriteAttributeValue(" ", 5432, "blog", 5433, 5, true);
#nullable restore
#line 135 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 5437, newClassFavorite, 5438, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></span>\r\n            <h4 class=\"std-h4 menu-button--blogs\">ARTICLES</h4>\r\n        </div>\r\n        <div id=\"menu-bttn\" onclick=\"menuRedirect(\'/tools\')\">\r\n            <span");
                BeginWriteAttribute("class", " class=\"", 5627, "\"", 5686, 4);
                WriteAttributeValue("", 5635, "menu-button", 5635, 11, true);
                WriteAttributeValue(" ", 5646, "menu-button-desktop", 5647, 20, true);
                WriteAttributeValue(" ", 5666, "tools", 5667, 6, true);
#nullable restore
#line 139 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 5672, newClassTool, 5673, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></span>\r\n            <h4 class=\"std-h4 menu-button--tools\">TOOLS</h4>\r\n        </div>\r\n    </nav>\r\n\r\n");
                WriteLiteral("    <footer class=\"border-top footer text-muted\">\r\n        <div class=\"container\">\r\n            &copy; 2021 - MyBg - ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d55f34d8fc1c34fa81e50e3943c6c2570c4bba2d24561", async() => {
                    WriteLiteral("Privacy");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </footer>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d55f34d8fc1c34fa81e50e3943c6c2570c4bba2d26243", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d55f34d8fc1c34fa81e50e3943c6c2570c4bba2d27343", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d55f34d8fc1c34fa81e50e3943c6c2570c4bba2d28443", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 152 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 153 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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