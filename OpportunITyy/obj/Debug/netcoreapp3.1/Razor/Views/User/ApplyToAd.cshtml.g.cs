#pragma checksum "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e94ebd4b111eb3c95c22a6435c24e893a0329428"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ApplyToAd), @"mvc.1.0.view", @"/Views/User/ApplyToAd.cshtml")]
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
#line 1 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\_ViewImports.cshtml"
using OpportunITyy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\_ViewImports.cshtml"
using OpportunITyy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e94ebd4b111eb3c95c22a6435c24e893a0329428", @"/Views/User/ApplyToAd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2742b0b44006567c734fc1a19e7cf221a78b9696", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ApplyToAd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ad>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApplyToAd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
  




    Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n    \r\n\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e94ebd4b111eb3c95c22a6435c24e893a03294285298", async() => {
                WriteLiteral(@"

            <div class=""cover-container d-flex h-100 p-3 mx-auto flex-column"">
                <header class=""masthead mb-auto"">
                    <div class=""inner"">
                        
                        <div class=""span_box justify-content-center"">


                        </div>

                        <nav class=""nav nav-masthead justify-content-center"">


                        </nav>
                    </div>
                </header>

                <main role=""main"" class=""inner cover"">
                   

");
#nullable restore
#line 37 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
                     if (Model.TypeOfJob == "Programming")
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("<h1 class=\"cover-heading text-danger\">");
#nullable restore
#line 38 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
                                                      Write(Model.TypeOfJob);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1> ");
#nullable restore
#line 38 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
                                                                                 }
                else if (Model.TypeOfJob == "Practise")
                
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("<h1 class=\"cover-heading text-success\">");
#nullable restore
#line 41 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
                                                       Write(Model.TypeOfJob);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1> ");
#nullable restore
#line 41 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
                                                                                  }

                    else if (Model.TypeOfJob == "Menagment")

                {

#line default
#line hidden
#nullable disable
                WriteLiteral("<h1 class=\"cover-heading text-primary\">");
#nullable restore
#line 45 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
                                                   Write(Model.TypeOfJob);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1> ");
#nullable restore
#line 45 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
                                                                              }
            else if (Model.TypeOfJob == "UX designer")


            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<h1 class=\"cover-heading text-info\">");
#nullable restore
#line 49 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
                                            Write(Model.TypeOfJob);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1> ");
#nullable restore
#line 49 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
                                                                       }
            else if (Model.TypeOfJob == "Support")

            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<h1 class=\"cover-heading text-warning\">");
#nullable restore
#line 52 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
                                               Write(Model.TypeOfJob);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1> ");
#nullable restore
#line 52 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
                                                                          }
            else
            
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<h1 class=\"cover-heading text-secondary\">");
#nullable restore
#line 55 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
                                                 Write(Model.TypeOfJob);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1> ");
#nullable restore
#line 55 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
                                                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        \r\n\r\n                 <h3>at</h3> <h1 class=\"cover-heading text-primary\"> ");
#nullable restore
#line 60 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
                                                                Write(ViewBag.nameoffirm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e94ebd4b111eb3c95c22a6435c24e893a032942810992", async() => {
                    WriteLiteral("\r\n                    ");
#nullable restore
#line 62 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
               Write(Html.HiddenFor(model => model.IdAd));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    ");
#nullable restore
#line 63 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
               Write(Html.HiddenFor(model => model.TypeOfJob));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    <hr />\r\n                    <h5 class=\"cover-heading\">Your email addres: ");
#nullable restore
#line 65 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
                                                            Write(ViewBag.loggeduser);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </h5>\r\n                    <p class=\"lead\"> Upload your CV </p>\r\n                    <p class=\"lead\">\r\n                        <input class=\"form-control\" name=\"files\" type=\"file\" />\r\n                        ");
#nullable restore
#line 69 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\ApplyToAd.cshtml"
                   Write(Html.ValidationMessageFor(model => model.file, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        <hr />\r\n\r\n                    </p>\r\n                    <p class=\"lead\">\r\n                        <input type=\"submit\" class=\"btn btn-primary\" />\r\n                    </p>\r\n\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          </main>\r\n\r\n\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
        <script>window.jQuery || document.write('<script src=""../../assets/js/vendor/jquery-slim.min.js""><\/script>')</script>
        <script src=""../../assets/js/vendor/popper.min.js""></script>
        <script src=""../../dist/js/bootstrap.min.js""></script>








   
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ad> Html { get; private set; }
    }
}
#pragma warning restore 1591
