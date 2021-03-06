#pragma checksum "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "744d0e0abd72d9a3542baa13534a67c6893c0a78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FileSystem_Delete), @"mvc.1.0.view", @"/Views/FileSystem/Delete.cshtml")]
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
#line 1 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\_ViewImports.cshtml"
using webLab2._6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\_ViewImports.cshtml"
using webLab2._6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"744d0e0abd72d9a3542baa13534a67c6893c0a78", @"/Views/FileSystem/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69f0acbba30622098203fdadec85f52da9760be3", @"/Views/_ViewImports.cshtml")]
    public class Views_FileSystem_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<webLab2._6.Models.FolderModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OpenFolder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml"
  
    ViewData["Title"] = "Delete Folder";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete Folder</h1>\r\n\r\n<h3>Are you sure you want to delete this folder with all its content?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr />\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Folders));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 24 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml"
             if (Model.Folders.Any())
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul style=\"list-style-type:none;padding-left:0px;\">\r\n");
#nullable restore
#line 28 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml"
                     foreach (FolderModel folder in Model.Folders.Reverse())
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>");
#nullable restore
#line 31 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml"
                       Write(folder.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 32 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n");
#nullable restore
#line 35 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>No folders.</span>\r\n");
#nullable restore
#line 39 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <hr />\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Files));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 46 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml"
             if (Model.Files.Any())
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul style=\"list-style-type:none;padding-left:0px;\">\r\n");
#nullable restore
#line 50 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml"
                 foreach (FileModel file in Model.Files.Reverse())
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 53 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml"
                   Write(file.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 54 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n");
#nullable restore
#line 57 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml"
            } else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>No files.</span>\r\n");
#nullable restore
#line 60 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <hr />\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "744d0e0abd72d9a3542baa13534a67c6893c0a789002", async() => {
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger btn-sm\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "744d0e0abd72d9a3542baa13534a67c6893c0a789356", async() => {
                    WriteLiteral("Back");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\FileSystem\Delete.cshtml"
                                     WriteLiteral(Model.Id);

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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<webLab2._6.Models.FolderModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
