#pragma checksum "C:\Users\User\Desktop\BackEnd all tasks\RaufHomework09.12\EduHomeAPanel\EduHomeAPanel\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b602cfcf1e49bb7476b7cbb8eca3b11194cac23"
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
#line 1 "C:\Users\User\Desktop\BackEnd all tasks\RaufHomework09.12\EduHomeAPanel\EduHomeAPanel\Views\_ViewImports.cshtml"
using EduHomeAPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\BackEnd all tasks\RaufHomework09.12\EduHomeAPanel\EduHomeAPanel\Views\_ViewImports.cshtml"
using EduHomeAPanel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b602cfcf1e49bb7476b7cbb8eca3b11194cac23", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab971aa04eed642c963b8d2db94355e7270cf5a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://devitems.us11.list-manage.com/subscribe/post?u=6bbb9b6f5827bd842d9640c82&amp;id=05d85f18ef"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mc-embedded-subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("mc-embedded-subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("validate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html class=\"no-js\" lang=\"en\">\r\n\r\n<!-- Mirrored from preview.hasthemes.com/eduhome/index-2.html by HTTrack Website Copier/3.x [XR&CO\'2014], Thu, 09 Dec 2021 20:22:53 GMT -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b602cfcf1e49bb7476b7cbb8eca3b11194cac237702", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"x-ua-compatible\" content=\"ie=edge\">\r\n    <title>Eduhome - Educational HTML Template</title>\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 371, "\"", 381, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <link rel=""apple-touch-icon"" href=""apple-touch-icon.png"">
    <!-- Place favicon.ico in the root directory -->

    <link rel=""stylesheet"" href=""css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""css/animate.css"">
    <link rel=""stylesheet"" href=""css/meanmenu.css"">
    <link rel=""stylesheet"" href=""css/magnific-popup.css"">
    <link rel=""stylesheet"" href=""css/owl.carousel.min.css"">
    <link rel=""stylesheet"" href=""css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""css/et-line-icon.css"">
    <link rel=""stylesheet"" href=""css/reset.css"">
    <link rel=""stylesheet"" href=""css/ionicons.min.css"">
    <link rel=""stylesheet"" href=""css/material-design-iconic-font.min.css"">
    <link rel=""stylesheet"" href=""css/style.css"">
    <link rel=""stylesheet"" href=""css/responsive.css"">
    <script src=""js/vendor/modernizr-2.8.3.min.js""></script>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b602cfcf1e49bb7476b7cbb8eca3b11194cac2310017", async() => {
                WriteLiteral(@"
    <!--[if lt IE 8]>
        <p class=""browserupgrade"">You are using an <strong>outdated</strong> browser. Please <a href=""http://browsehappy.com/"">upgrade your browser</a> to improve your experience.</p>
    <![endif]-->
    <!-- Header Area Start -->
    <header class=""top"">
        <div class=""header-top"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-8 col-sm-8 col-xs-12"">
                        <div class=""header-top-left"">
                            <p>HAVE ANY QUESTION ?  +880 5698  598  6587</p>
                        </div>
                    </div>
                    <div class=""col-md-4 col-sm-4 col-xs-12"">
                        <div class=""header-top-right text-right"">
                            <ul>
                                <li><a href=""login.html"">login</a></li>
                                <li><a href=""signup.html"">signup</a></li>
                            </ul>
                        </div");
                WriteLiteral(@">
                    </div>
                </div>
            </div>
        </div>
        <div class=""header-area two header-sticky"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-3 col-sm-3 col-xs-6"">
                        <div class=""logo"">
                            <a href=""index.html""><img src=""img/logo/logo2.png"" alt=""eduhome"" /></a>
                        </div>
                    </div>
                    <div class=""col-md-9 col-sm-9 col-xs-6"">
                        <div class=""content-wrapper text-right"">
                            <!-- Main Menu Start -->
                            <div class=""main-menu"">
                                <nav>
                                    <ul>
                                        <li>
                                            <a href=""index.html"">Home</a>
                                            <ul>
                                                <li><a");
                WriteLiteral(@" href=""index.html"">Home One</a></li>
                                                <li><a href=""index-2.html"">Home Two</a></li>
                                                <li><a href=""index-3.html"">Home Three</a></li>
                                                <li><a href=""index-4.html"">Home Four</a></li>
                                                <li><a href=""index-5.html"">Home Five</a></li>
                                            </ul>
                                        </li>
                                        <li><a href=""about.html"">About</a></li>
                                        <li>
                                            <a href=""course.html"">courses</a>
                                            <ul>
                                                <li><a href=""course.html"">courses</a></li>
                                                <li><a href=""course-details.html"">courses details</a></li>
                                            </ul>
 ");
                WriteLiteral(@"                                       </li>
                                        <li>
                                            <a href=""event.html"">event</a>
                                            <ul>
                                                <li><a href=""event.html"">event</a></li>
                                                <li><a href=""event-left-side-bar.html"">event left sidebar</a></li>
                                                <li><a href=""event-right-side-bar.html"">event right sidebar</a></li>
                                                <li><a href=""event-details.html"">event details</a></li>
                                            </ul>
                                        </li>
                                        <li class=""hidden-sm"">
                                            <a href=""teacher.html"">teacher</a>
                                            <ul>
                                                <li><a href=""teacher.html"">teacher</a>");
                WriteLiteral(@"</li>
                                                <li><a href=""teacher-details.html"">teacher details</a></li>
                                            </ul>
                                        </li>
                                        <li>
                                            <a href=""blog.html"">blog</a>
                                            <ul>
                                                <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b602cfcf1e49bb7476b7cbb8eca3b11194cac2315035", async() => {
                    WriteLiteral("blog");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</li>
                                                <li><a href=""blog-left-side-bar.html"">blog left sidebar</a></li>
                                                <li><a href=""blog-right-side-bar.html"">blog righ sidebar</a></li>
                                                <li><a href=""blog-details.html"">blog details</a></li>
                                            </ul>
                                        </li>
                                        <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b602cfcf1e49bb7476b7cbb8eca3b11194cac2316951", async() => {
                    WriteLiteral("Contact");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</li>
                                        <li><a href=""#"">Buy Now</a>
                                    </ul>
                                </nav>
                            </div>
                            <!--Search Form Start-->
                            <div class=""search-btn"">
                                <ul data-toggle=""dropdown"" class=""header-search search-toggle"">
                                    <li class=""search-menu"">
                                        <i class=""fa fa-search""></i>
                                    </li>
                                </ul>
                                <div class=""search"">
                                    <div class=""search-form"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b602cfcf1e49bb7476b7cbb8eca3b11194cac2319170", async() => {
                    WriteLiteral(@"
                                            <input type=""search"" placeholder=""Search here..."" name=""search"" />
                                            <button type=""submit"">
                                                <span><i class=""fa fa-search""></i></span>
                                            </button>
                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
                            <!--End of Search Form-->
                            <!-- Main Menu End -->
                        </div>
                    </div>
                    <div class=""col-xs-12"">
                        <div class=""mobile-menu hidden-lg hidden-md hidden-sm""></div>
                    </div>
                </div>
            </div>
        </div>
    </header>
    <!-- Header Area End -->
    ");
#nullable restore
#line 146 "C:\Users\User\Desktop\BackEnd all tasks\RaufHomework09.12\EduHomeAPanel\EduHomeAPanel\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <!-- Subscribe Start -->
    <div class=""subscribe-area pt-60 pb-70"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-8 col-md-offset-2"">
                    <div class=""subscribe-content section-title text-center"">
                        <h2>subscribe our newsletter</h2>
                        <p>I must explain to you how all this mistaken idea </p>
                    </div>
                    <div class=""newsletter-form mc_embed_signup"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b602cfcf1e49bb7476b7cbb8eca3b11194cac2322377", async() => {
                    WriteLiteral("\r\n                            <div id=\"mc_embed_signup_scroll\" class=\"mc-form\">\r\n                                <input type=\"email\"");
                    BeginWriteAttribute("value", " value=\"", 9126, "\"", 9134, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" name=""EMAIL"" class=""email"" id=""mce-EMAIL"" placeholder=""Enter your e-mail address"" required>
                                <!-- real people should not fill this in and expect good things - do not remove this or risk form bot signups-->
                                <div class=""mc-news"" aria-hidden=""true""><input type=""text"" name=""b_6bbb9b6f5827bd842d9640c82_05d85f18ef"" tabindex=""-1""");
                    BeginWriteAttribute("value", " value=\"", 9525, "\"", 9533, 0);
                    EndWriteAttribute();
                    WriteLiteral("></div>\r\n                                <button id=\"mc-embedded-subscribe\" class=\"default-btn\" type=\"submit\" name=\"subscribe\"><span>subscribe</span></button>\r\n                            </div>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <!-- mailchimp-alerts Start -->
                        <div class=""mailchimp-alerts"">
                            <div class=""mailchimp-submitting""></div><!-- mailchimp-submitting end -->
                            <div class=""mailchimp-success""></div><!-- mailchimp-success end -->
                            <div class=""mailchimp-error""></div><!-- mailchimp-error end -->
                        </div>
                        <!-- mailchimp-alerts end -->
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Subscribe End -->
    <!-- Footer Start -->
    <footer class=""footer-area"">
        <div class=""main-footer"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-4 col-sm-6 col-xs-12"">
                        <div class=""single-widget pr-60"">
                            <div class=""footer-logo pb-25"">
                                <a href=""index.htm");
                WriteLiteral(@"l""><img src=""img/logo/footer-logo.png"" alt=""eduhome""></a>
                            </div>
                            <p>I must explain to you how all this mistaken idea of denoung pleure and praising pain was born and give you a coete account of the system. </p>
                            <div class=""footer-social"">
                                <ul>
                                    <li><a href=""#""><i class=""zmdi zmdi-facebook""></i></a></li>
                                    <li><a href=""#""><i class=""zmdi zmdi-pinterest""></i></a></li>
                                    <li><a href=""#""><i class=""zmdi zmdi-vimeo""></i></a></li>
                                    <li><a href=""#""><i class=""zmdi zmdi-twitter""></i></a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-3 col-sm-6 col-xs-12"">
                        <div class=""single-widget"">
                       ");
                WriteLiteral(@"     <h3>information</h3>
                            <ul>
                                <li><a href=""#"">addmission</a></li>
                                <li><a href=""#"">Academic Calender</a></li>
                                <li><a href=""event.html"">Event List</a></li>
                                <li><a href=""#"">Hostel &amp; Dinning</a></li>
                                <li><a href=""#"">TimeTable</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-md-2 col-sm-6 col-xs-12"">
                        <div class=""single-widget"">
                            <h3>useful links</h3>
                            <ul>
                                <li><a href=""course.html"">our courses</a></li>
                                <li><a href=""about.html"">about us</a></li>
                                <li><a href=""teacher.html"">teachers &amp; faculty</a></li>
                                <li><a href=""#"">t");
                WriteLiteral(@"eams &amp; conditions</a></li>
                                <li><a href=""event.html"">our events</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-md-3 col-sm-6 col-xs-12"">
                        <div class=""single-widget"">
                            <h3>get in touch</h3>
                            <p>Your address goes here, Street<br>City, Roadno 785 New York</p>
                            <p>+880  548  986  898  87<br>+880  659  785  658  98</p>
                            <p>info@eduhome.com<br>www.eduhome.com</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""footer-bottom text-center"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <p>Copyright © <a href=""#"" target=""_blank"">HasTech</a> 2017. All Right Reserved By Hast");
                WriteLiteral(@"ech.</p>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <!-- Footer End -->


    <script src=""js/vendor/jquery-1.12.0.min.js""></script>
    <script src=""js/bootstrap.min.js""></script>
    <script src=""js/jquery.meanmenu.js""></script>
    <script src=""js/jquery.magnific-popup.js""></script>
    <script src=""js/ajax-mail.js""></script>
    <script src=""js/owl.carousel.min.js""></script>
    <script src=""js/jquery.mb.YTPlayer.js""></script>
    <script src=""js/jquery.nicescroll.min.js""></script>
    <script src=""js/plugins.js""></script>
    <script src=""js/main.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- Mirrored from preview.hasthemes.com/eduhome/index-2.html by HTTrack Website Copier/3.x [XR&CO\'2014], Thu, 09 Dec 2021 20:26:31 GMT -->\r\n</html>");
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
