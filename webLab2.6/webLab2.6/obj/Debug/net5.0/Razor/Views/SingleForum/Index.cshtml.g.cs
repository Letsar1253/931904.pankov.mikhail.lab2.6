#pragma checksum "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c0d5c771acb0304fd3e8284876e55d84d55c6fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SingleForum_Index), @"mvc.1.0.view", @"/Views/SingleForum/Index.cshtml")]
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
#line 1 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
using webLab2._6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c0d5c771acb0304fd3e8284876e55d84d55c6fe", @"/Views/SingleForum/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69f0acbba30622098203fdadec85f52da9760be3", @"/Views/_ViewImports.cshtml")]
    public class Views_SingleForum_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ForumCategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-FId", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ForumCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OpenTopic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
  
    ViewData["Title"] = "Forum";
    var user = Context.User;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 9 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h5>");
#nullable restore
#line 10 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
 if (user.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c0d5c771acb0304fd3e8284876e55d84d55c6fe5572", async() => {
                WriteLiteral("Create New Topic");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-FId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["FId"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<span>   |   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c0d5c771acb0304fd3e8284876e55d84d55c6fe7258", async() => {
                WriteLiteral("Back To Forum Categories");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n    </p>\r\n");
#nullable restore
#line 17 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c0d5c771acb0304fd3e8284876e55d84d55c6fe8868", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n    <br />\r\n");
#nullable restore
#line 22 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n<table class=\"table table-bordered table-striped\">\r\n");
#nullable restore
#line 26 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
     foreach (var item in Model.Topics)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"align-middle\">\r\n                <h5>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c0d5c771acb0304fd3e8284876e55d84d55c6fe10828", async() => {
#nullable restore
#line 30 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-TopicId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TopicId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-TopicId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TopicId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5>            \r\n                <div><span class=\"font-weight-bold\">Created by: </span> ");
#nullable restore
#line 31 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.Author.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div><span class=\"font-weight-bold\">Creation date: </span> ");
#nullable restore
#line 32 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </td>\r\n            <td class=\"align-middle\">\r\n                <div><span class=\"font-weight-bold\">Replies:</span> ");
#nullable restore
#line 35 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.ReplyCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 36 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                 if (user.Identity.IsAuthenticated)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                     if (user.HasClaim("RoleId", "1") || item.Author.Email == user.Identity.Name)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 41 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                                                                                  ;
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td class=\"align-middle\">\r\n");
#nullable restore
#line 46 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                 if (item.ReplyCount == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div><span class=\"font-weight-bold\">Last reply: no replies</span></div>\r\n");
#nullable restore
#line 49 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                     if (item.LastReplyId == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div><span class=\"font-weight-bold\">Last reply: deleted</span></div>\r\n");
#nullable restore
#line 55 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div><span class=\"font-weight-bold\">Last reply: ");
#nullable restore
#line 58 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.Replies.FirstOrDefault(r => r.Id == item.LastReplyId).Author.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                        <div><span class=\"font-weight-bold\">at: </span> ");
#nullable restore
#line 59 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.Replies.FirstOrDefault(r => r.Id == item.LastReplyId).DateEdited));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 60 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\User\source\repos\webLab2.6\webLab2.6\Views\SingleForum\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForumCategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
