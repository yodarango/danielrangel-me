#pragma checksum "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_carrousel_Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4be0b30f369cbaed86b3bec7ab87b20ee2cd6a20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__carrousel_Blog), @"mvc.1.0.view", @"/Views/Shared/_carrousel_Blog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be0b30f369cbaed86b3bec7ab87b20ee2cd6a20", @"/Views/Shared/_carrousel_Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5dbcb0184da424cb338a8e1ab3a5366afac376", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__carrousel_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"std-image-carrousel carrousel-blog\">\r\n");
#nullable restore
#line 2 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_carrousel_Blog.cshtml"
      
        string[] images = Model.Tumbnails.Split(" ");

        foreach (string image in images)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img");
            BeginWriteAttribute("src", " src=\"", 184, "\"", 196, 1);
#nullable restore
#line 7 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_carrousel_Blog.cshtml"
WriteAttributeValue("", 190, image, 190, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"carrousel-image\"");
            BeginWriteAttribute("alt", " alt=\"", 221, "\"", 266, 6);
            WriteAttributeValue("", 227, "thumbnail", 227, 9, true);
            WriteAttributeValue(" ", 236, "for", 237, 4, true);
            WriteAttributeValue(" ", 240, "a", 241, 2, true);
            WriteAttributeValue(" ", 242, "post", 243, 5, true);
            WriteAttributeValue(" ", 247, "about", 248, 6, true);
#nullable restore
#line 7 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_carrousel_Blog.cshtml"
WriteAttributeValue(" ", 253, Model.Title, 254, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 8 "C:\Users\danielr\source\repos\Mine\MyBg\MyBg\Views\Shared\_carrousel_Blog.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
