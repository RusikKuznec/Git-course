#pragma checksum "C:\Users\Ruslan\Desktop\code\git cours\Web first\Views\Gallery\ShowImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8fe1a99440495443be35f79c91b7357744ffb20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_ShowImage), @"mvc.1.0.view", @"/Views/Gallery/ShowImage.cshtml")]
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
#line 1 "C:\Users\Ruslan\Desktop\code\git cours\Web first\Views\_ViewImports.cshtml"
using Web_first;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ruslan\Desktop\code\git cours\Web first\Views\_ViewImports.cshtml"
using Web_first.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8fe1a99440495443be35f79c91b7357744ffb20", @"/Views/Gallery/ShowImage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"963241663edacae86afd4c75192ad40008541c3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Gallery_ShowImage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ImageUrlIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Gallery/AddComment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Ruslan\Desktop\code\git cours\Web first\Views\Gallery\ShowImage.cshtml"
  
    Layout = "/Views/Shared/_LayoutGallery.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n  <div class=\"gallery\">\r\n      <div class=\"image\">\r\n          <img");
            BeginWriteAttribute("src", " src=\"", 171, "\"", 187, 1);
#nullable restore
#line 12 "C:\Users\Ruslan\Desktop\code\git cours\Web first\Views\Gallery\ShowImage.cshtml"
WriteAttributeValue("", 177, Model.Url, 177, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n      </div>\r\n      <div>\r\n");
#nullable restore
#line 15 "C:\Users\Ruslan\Desktop\code\git cours\Web first\Views\Gallery\ShowImage.cshtml"
           foreach (var comment in Model.Comments)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <div>\n                 ");
#nullable restore
#line 18 "C:\Users\Ruslan\Desktop\code\git cours\Web first\Views\Gallery\ShowImage.cshtml"
            Write(comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n             </div>\n");
#nullable restore
#line 20 "C:\Users\Ruslan\Desktop\code\git cours\Web first\Views\Gallery\ShowImage.cshtml"
             
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>\r\n  </div> \r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8fe1a99440495443be35f79c91b7357744ffb205145", async() => {
                WriteLiteral("\r\n    <input name=\"imageId\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 487, "\"", 504, 1);
#nullable restore
#line 31 "C:\Users\Ruslan\Desktop\code\git cours\Web first\Views\Gallery\ShowImage.cshtml"
WriteAttributeValue("", 495, Model.Id, 495, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    Add Comment<input name=\"Text\" />\r\n    <input type=\"submit\" value=\"comment\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ImageUrlIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
