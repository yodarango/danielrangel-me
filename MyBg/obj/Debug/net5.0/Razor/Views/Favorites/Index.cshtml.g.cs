#pragma checksum "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Favorites\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32686c3811b87e69bdf5c6dff3e10cada3133911"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Favorites_Index), @"mvc.1.0.view", @"/Views/Favorites/Index.cshtml")]
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
#line 1 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\_ViewImports.cshtml"
using MyBg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\_ViewImports.cshtml"
using MyBg.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32686c3811b87e69bdf5c6dff3e10cada3133911", @"/Views/Favorites/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5dbcb0184da424cb338a8e1ab3a5366afac376", @"/Views/_ViewImports.cshtml")]
    public class Views_Favorites_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyBg.Models.FavoriteModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Favorites", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Favorites\Index.cshtml"
  
    ViewData["Title"] = "My Favorites";
    IEnumerable<CategoryModel> allTags = ViewData["Tags"] as IEnumerable<CategoryModel>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-wrapper main-type_favorite"">
    <section>
        <span class=""post-type post-type_header""></span>
        <h1>FAVORITES</h1>
    </section>

    <p class=""std-p"">
    This is my very dummy description for now! ustry. 
    Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
    when an unknown printer took a galley of type and scrambled it to make 
    a type specimen book. It has survived not only five centuries, 
    but also the leap into electronic typesetting, remaining 
    essentially unchanged. It was popularised in the 1960s with 
    the release of Letraset sheets containing Lorem Ipsum passages, 
    and more recently with desktop publishing software like 
    Aldus PageMaker including versions of Lorem Ipsu
    </p>

    <div>
");
#nullable restore
#line 27 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Favorites\Index.cshtml"
         foreach(CategoryModel tag in allTags)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"category-tag\">#");
#nullable restore
#line 29 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Favorites\Index.cshtml"
                                       Write(tag.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 30 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Favorites\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n");
#nullable restore
#line 33 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Favorites\Index.cshtml"
     foreach (var post in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"favorite-post-wrapper\">\r\n            <aside class=\"favorite-post-info-wrapper\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32686c3811b87e69bdf5c6dff3e10cada31339115910", async() => {
                WriteLiteral("\r\n                    <h3 class=\"std-header-h3 header-h3_favorite\">");
#nullable restore
#line 38 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Favorites\Index.cshtml"
                                                            Write(post.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                    <p class=\"std-quiet-p\">");
#nullable restore
#line 39 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Favorites\Index.cshtml"
                                      Write(post.DatePosted);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n                    <div class=\"tag-footer\">\r\n\r\n");
#nullable restore
#line 43 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Favorites\Index.cshtml"
                         if (post.PostType == "Favorite")
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span class=\"post-type type_favorite\">favorite</span>\r\n");
#nullable restore
#line 46 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Favorites\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Favorites\Index.cshtml"
                         if (post.PostType == "Blog")
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span class=\"post-type type_blog\">blog</span>\r\n");
#nullable restore
#line 51 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Favorites\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"category-wrapper\">\r\n");
#nullable restore
#line 53 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Favorites\Index.cshtml"
                             if (!String.IsNullOrEmpty(post.Categories))
                            {
                                string[] tags = post.Categories.Split(" ");
                                foreach (string tag in tags)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <span class=\"category-tag\">");
#nullable restore
#line 58 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Favorites\Index.cshtml"
                                                          Write(tag);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 59 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Favorites\Index.cshtml"
                                }

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Favorites\Index.cshtml"
                                                                  WriteLiteral(post.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <p class=\"std-p std-p_favorite-desc\">\r\n                    ");
#nullable restore
#line 66 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Favorites\Index.cshtml"
               Write(post.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </aside>\r\n        </div>\r\n");
#nullable restore
#line 70 "C:\Users\danielr\source\repos\MyBg\MyBg\Views\Favorites\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyBg.Models.FavoriteModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
