#pragma checksum "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ac6d7f41ea1555732e2b7fac4e8ca0481763f74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ForumCategory_Index), @"mvc.1.0.view", @"/Views/ForumCategory/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ac6d7f41ea1555732e2b7fac4e8ca0481763f74", @"/Views/ForumCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69f0acbba30622098203fdadec85f52da9760be3", @"/Views/_ViewImports.cshtml")]
    public class Views_ForumCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<webLab2._6.Models.ForumCategoryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SingleForum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PreIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
  
    ViewData["Title"] = "Categories";
    var user = Context.User;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>All Forum Categories</h1>\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
 if (user.Identity.IsAuthenticated && user.HasClaim("RoleId", "1"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ac6d7f41ea1555732e2b7fac4e8ca0481763f744637", async() => {
                WriteLiteral("Create New Category");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 17 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 19 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
 if (Model.Count<ForumCategoryModel>() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 28 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-hover\">\r\n                    <td style=\"width: 15%;\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ac6d7f41ea1555732e2b7fac4e8ca0481763f747457", async() => {
                WriteLiteral(" ");
#nullable restore
#line 38 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
                                                                                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-FId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["FId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-FId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["FId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("style", " style=\"", 1093, "\"", 1101, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 41 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"width: 180px;\">\r\n");
#nullable restore
#line 44 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
                         if (user.Identity.IsAuthenticated)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
                             if (user.HasClaim("RoleId", "1"))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
                           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 48 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
                                                                                                       
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
                       Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
                             if (user.HasClaim("RoleId", "1"))
                            {
                                

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 53 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
                                            Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
                                                                                                           
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 59 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 62 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Forum doesn\'t contain any category yet! :(</p>\r\n");
#nullable restore
#line 66 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\ForumCategory\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<webLab2._6.Models.ForumCategoryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
