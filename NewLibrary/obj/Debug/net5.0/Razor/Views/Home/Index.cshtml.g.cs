#pragma checksum "C:\Users\nanan\Desktop\NewLibrary\NewLibrary\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c315c0c82b2cfcb55e3c44555d722e6ab060c1d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\nanan\Desktop\NewLibrary\NewLibrary\Views\_ViewImports.cshtml"
using NewLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nanan\Desktop\NewLibrary\NewLibrary\Views\_ViewImports.cshtml"
using NewLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c315c0c82b2cfcb55e3c44555d722e6ab060c1d7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57d204655bc8a27ddc23f92bff88f84a3d882c1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("boxed-btn3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""slider_area"">
    <div class=""single_slider  d-flex align-items-center slider_bg_1"">
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-lg-7 col-md-6"">
                    <div class=""slider_text"">
                        <h5 class=""wow fadeInLeft"" data-wow-duration=""1s"" data-wow-delay="".2s"">");
#nullable restore
#line 12 "C:\Users\nanan\Desktop\NewLibrary\NewLibrary\Views\Home\Index.cshtml"
                                                                                          Write(ViewBag.AllTovars.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"+ ???????? ???? ??????????</h5>
                        <h3 class=""wow fadeInLeft"" data-wow-duration=""1s"" data-wow-delay="".3s"">?????????????? ???? ?????? ????????????</h3>
                        <p class=""wow fadeInLeft"" data-wow-duration=""1s"" data-wow-delay="".4s"">?????????????????????????????????? ?????????? ?????????? ??????????</p>
                        <div class=""sldier_btn wow fadeInLeft"" data-wow-duration=""1s"" data-wow-delay="".5s"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c315c0c82b2cfcb55e3c44555d722e6ab060c1d75414", async() => {
                WriteLiteral("????????????????????????????????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""ilstration_img wow fadeInRight d-none d-lg-block text-right"" data-wow-duration=""1s"" data-wow-delay="".2s"">
        <img src=""img/banner/illustration.png""");
            BeginWriteAttribute("alt", " alt=\"", 1350, "\"", 1356, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    </div>
</div>

<div class=""job_listing_area"">
    <div class=""container"">
        <div class=""row align-items-center"">
            <div class=""col-lg-6"">
                <div class=""section_title"">
                    <h3>?????????????????? ????????????????????</h3>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""brouse_job text-right"">
                    <a href=""/Catalog/AllCatalog"" class=""boxed-btn4"">????????????</a>
                </div>
            </div>
        </div>
        <div class=""job_lists"">
            <div class=""row"">
");
#nullable restore
#line 44 "C:\Users\nanan\Desktop\NewLibrary\NewLibrary\Views\Home\Index.cshtml"
                 foreach (var item in ViewBag.AllTovars)
                {
                    if (ViewBag.It < 5)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-lg-12 col-md-12"">
                            <div class=""single_jobs white-bg d-flex justify-content-between"">
                                <div class=""jobs_left d-flex align-items-center"">
                                    <div class=""thumb"" style=""display: table;"">
                                        <img height=""80"" width=""auto""");
            BeginWriteAttribute("href", " href=\"", 2487, "\"", 2516, 2);
            WriteAttributeValue("", 2494, "/Catalog/More/", 2494, 14, true);
#nullable restore
#line 52 "C:\Users\nanan\Desktop\NewLibrary\NewLibrary\Views\Home\Index.cshtml"
WriteAttributeValue("", 2508, item.Id, 2508, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=", 2517, "", 2537, 1);
#nullable restore
#line 52 "C:\Users\nanan\Desktop\NewLibrary\NewLibrary\Views\Home\Index.cshtml"
WriteAttributeValue("", 2522, item.BookImage, 2522, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2537, "\"", 2543, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"jobs_conetent\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2698, "\"", 2727, 2);
            WriteAttributeValue("", 2705, "/Catalog/More/", 2705, 14, true);
#nullable restore
#line 55 "C:\Users\nanan\Desktop\NewLibrary\NewLibrary\Views\Home\Index.cshtml"
WriteAttributeValue("", 2719, item.Id, 2719, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h4>");
#nullable restore
#line 55 "C:\Users\nanan\Desktop\NewLibrary\NewLibrary\Views\Home\Index.cshtml"
                                                                        Write(item.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4></a>
                                        <div class=""links_locat d-flex align-items-center"">
                                            <div class=""location"">
                                                <p> <i class=""fa fa-map-marker""></i>");
#nullable restore
#line 58 "C:\Users\nanan\Desktop\NewLibrary\NewLibrary\Views\Home\Index.cshtml"
                                                                               Write(item.PlacePublication);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n                                            <div class=\"location\">\r\n                                                <p> <i class=\"fa fa-clock-o\"></i>");
#nullable restore
#line 61 "C:\Users\nanan\Desktop\NewLibrary\NewLibrary\Views\Home\Index.cshtml"
                                                                            Write(item.YearPubl);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""jobs_right"">
                                    <div class=""apply_now"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 3597, "\"", 3626, 2);
            WriteAttributeValue("", 3604, "/Catalog/More/", 3604, 14, true);
#nullable restore
#line 68 "C:\Users\nanan\Desktop\NewLibrary\NewLibrary\Views\Home\Index.cshtml"
WriteAttributeValue("", 3618, item.Id, 3618, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"boxed-btn3\">??????????????????</a>\r\n                                    </div>\r\n\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 74 "C:\Users\nanan\Desktop\NewLibrary\NewLibrary\Views\Home\Index.cshtml"
                        ViewBag.It += 1;
                    }
                    else
                    {
                        break;
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
