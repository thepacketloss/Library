#pragma checksum "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35e1c8784368d08aac08adb941f1298c3822b352"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Book_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Book/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Book/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Book_Index))]
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
#line 1 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
using Library.PublicModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35e1c8784368d08aac08adb941f1298c3822b352", @"/Areas/Admin/Views/Book/Index.cshtml")]
    public class Areas_Admin_Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Library.Models.ViewModels.BookListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("showbookgroup"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("showeditbook"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("showdeletebook"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/adminPanelScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(233, 11, true);
            WriteLiteral("<div>\r\n    ");
            EndContext();
            BeginContext(245, 27, false);
#line 10 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
Write(Html.Partial("_adminPanel"));

#line default
#line hidden
            EndContext();
            BeginContext(272, 309, true);
            WriteLiteral(@"
</div>

<div class=""col-md-9"">
    <div class=""top-buffer""></div>

    <div class=""card bg-primary"">
        <div class=""card-header panel-head text-right"" id=""userListCard"">لیست کتاب ها</div>
        <div class=""card-body bg-white"">
            <div class=""btn-group float-right"">
                ");
            EndContext();
            BeginContext(581, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35e1c8784368d08aac08adb941f1298c3822b3527379", async() => {
                BeginContext(648, 11, true);
                WriteLiteral("افزودن کتاب");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(663, 193, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div></div>\r\n            <table class=\"table table-bordered table-striped table-sm\">\r\n                <thead>\r\n                <tr>\r\n                    <th>");
            EndContext();
            BeginContext(857, 44, false);
#line 27 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.BookName));

#line default
#line hidden
            EndContext();
            BeginContext(901, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(933, 49, false);
#line 28 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.BookGroupName));

#line default
#line hidden
            EndContext();
            BeginContext(982, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1014, 46, false);
#line 29 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.AuthorName));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1092, 49, false);
#line 30 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.BookPageCount));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1173, 45, false);
#line 31 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.BookImage));

#line default
#line hidden
            EndContext();
            BeginContext(1218, 118, true);
            WriteLiteral("</th>\r\n                    <th>عملیات</th>\r\n                </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 36 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1401, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1456, 13, false);
#line 39 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
                       Write(item.BookName);

#line default
#line hidden
            EndContext();
            BeginContext(1469, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1505, 18, false);
#line 40 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
                       Write(item.BookGroupName);

#line default
#line hidden
            EndContext();
            BeginContext(1523, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1559, 15, false);
#line 41 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
                       Write(item.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(1574, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1610, 18, false);
#line 42 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
                       Write(item.BookPageCount);

#line default
#line hidden
            EndContext();
            BeginContext(1628, 69, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1697, "\"", 1735, 2);
#line 44 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
WriteAttributeValue("", 1703, ViewBag.Rootpath, 1703, 17, false);

#line default
#line hidden
#line 44 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
WriteAttributeValue("", 1720, item.BookImage, 1720, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1736, 93, true);
            WriteLiteral("/>\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1829, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35e1c8784368d08aac08adb941f1298c3822b35213841", async() => {
                BeginContext(1921, 6, true);
                WriteLiteral("ویرایش");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
                                                                                              WriteLiteral(item.BookID);

#line default
#line hidden
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
            EndContext();
            BeginContext(1931, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1961, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35e1c8784368d08aac08adb941f1298c3822b35216426", async() => {
                BeginContext(2059, 3, true);
                WriteLiteral("حذف");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
                                                                                                    WriteLiteral(item.BookID);

#line default
#line hidden
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
            EndContext();
            BeginContext(2066, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 51 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2145, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(2380, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2401, 114, true);
                WriteLiteral("\r\n    <script src=\"js/modal-js/book-index.js\"></script>\r\n    <script src=\"js/ckeditor/ckeditor.js\"></script>\r\n    ");
                EndContext();
                BeginContext(2515, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35e1c8784368d08aac08adb941f1298c3822b35219786", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2563, 954, true);
                WriteLiteral(@"
    <script>
            $(document).on('click',
                '#submitdata',
                function(evt) {
                    evt.preventDefault();
                    var fileupload = $(""#files"").get(0);
                    var files = fileupload.files;
                    var data = new FormData();
                    for (var i = 0; i < files.length; i++) {
                        data.append('files', files[i]);
                    }
    
                    $('input', 'select').each(function(x,y) {
                        data.append($(y).attr('name'), $(y).val());
                    });
    //                var editorVal = CKEDITOR.instances['BookDescription'].getData();
                    var editorVal = $('textarea#BookDescription').val();
                    data.append('BookDescription', editorVal);
    
                    $.ajax({
                        type: ""post"",
                        url: '");
                EndContext();
                BeginContext(3518, 55, false);
#line 89 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
                         Write(Url.Action("AddEditBook", "Book", new {area = "Admin"}));

#line default
#line hidden
                EndContext();
                BeginContext(3573, 331, true);
                WriteLiteral(@"',
                        contentType: false,
                        processData: false,
                        data: data
                    }).done(function(res) {
                        if (res.status === ""success"") {
                            alert(res.message);
                            window.location.href='");
                EndContext();
                BeginContext(3905, 27, false);
#line 96 "C:\Users\Ghost\RiderProjects\Library\Library\Areas\Admin\Views\Book\Index.cshtml"
                                             Write(Url.Action("Index", "Book"));

#line default
#line hidden
                EndContext();
                BeginContext(3932, 359, true);
                WriteLiteral(@"';
                        } else {
                            $.each(res.error,function(a,b) {
                              alert(b);
                            });
                        }
                    }).fail(function(xhr, b, error) {
                        alert(error);
                    });
                })
        </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Library.Models.ViewModels.BookListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
