#pragma checksum "C:\Users\Muaz\Documents\code\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\VideoBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ed1ae3d9c8324fa85583d5314946b21a9a84067"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_DisplayTemplates_VideoBlock), @"mvc.1.0.view", @"/Views/Cms/DisplayTemplates/VideoBlock.cshtml")]
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
#line 1 "C:\Users\Muaz\Documents\code\PracticalApps\NorthwindCms\Views\_ViewImports.cshtml"
using Piranha.AspNetCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muaz\Documents\code\PracticalApps\NorthwindCms\Views\_ViewImports.cshtml"
using NorthwindCms.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ed1ae3d9c8324fa85583d5314946b21a9a84067", @"/Views/Cms/DisplayTemplates/VideoBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6678a70b82dc05f14c5ff659ec3564cb98c831e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_DisplayTemplates_VideoBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Piranha.Extend.Blocks.VideoBlock>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<video class=\"mw-100\" controls>\n    <source");
            BeginWriteAttribute("src", " src=\"", 84, "\"", 114, 1);
#nullable restore
#line 4 "C:\Users\Muaz\Documents\code\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\VideoBlock.cshtml"
WriteAttributeValue("", 90, Url.Content(Model.Body), 90, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    Your browser does not support the video tag.\n</video>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Authorization.IAuthorizationService Auth { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.AspNetCore.Services.IApplicationService WebApp { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Piranha.Extend.Blocks.VideoBlock> Html { get; private set; }
    }
}
#pragma warning restore 1591
