#pragma checksum "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d2583b1169a884d91e950c44c3e6f8b53733340"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserSignedIn), @"mvc.1.0.view", @"/Views/User/UserSignedIn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d2583b1169a884d91e950c44c3e6f8b53733340", @"/Views/User/UserSignedIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2742b0b44006567c734fc1a19e7cf221a78b9696", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserSignedIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ad>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
  
    ViewData["Title"] = "User home page";
    Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"bg-light p-5 rounded mt-3 ad_new\">\r\n    <h1>Newest job and practise ads</h1>\r\n    <p class=\"lead\">Filter ads by pressing the type of job you are searching</p>\r\n    \r\n</div>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
Write(Html.ActionLink("All", "UserSignedIn", new { email = ViewBag.Email, typeofjob = (Ad)null }, new { @class = "btn btn-primary  btn_typeJob" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
Write(Html.ActionLink("Programming", "UserSignedIn", new { email = ViewBag.Email, typeofjob = "Programming" }, new { @class = "btn btn-primary  btn_typeJob" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
Write(Html.ActionLink("System administration", "UserSignedIn", new { email = ViewBag.Email, typeofjob = "Administration" }, new { @class = "btn btn-primary  btn_typeJob" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
Write(Html.ActionLink("Management", "UserSignedIn", new { email = ViewBag.Email, typeofjob = "Management" }, new { @class = "btn btn-primary  btn_typeJob" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
Write(Html.ActionLink("UX designer", "UserSignedIn", new { email = ViewBag.Email, typeofjob = "UX designer" }, new { @class = "btn btn-primary  btn_typeJob" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
Write(Html.ActionLink("Support", "UserSignedIn", new { email = ViewBag.Email, typeofjob = "Support" }, new { @class = "btn btn-primary  btn_typeJob" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
Write(Html.ActionLink("Selling/Adviser", "UserSignedIn", new { email = ViewBag.Email, typeofjob = "Adviser" }, new { @class = "btn btn-primary  btn_typeJob" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
Write(Html.ActionLink("Practice", "UserSignedIn", new { email = ViewBag.Email, typeofjob = "Practice" }, new { @class = "btn btn-primary btn_typeJob" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<hr />\r\n\r\n\r\n");
#nullable restore
#line 24 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-6\">\r\n        <div class=\"row g-0 border rounded overflow-hidden flex-md-row mb-4 shadow-sm h-md-250 position-relative\">\r\n            <div class=\"col p-4 d-flex flex-column position-static\">\r\n");
#nullable restore
#line 30 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                 if (item.TypeOfJob == "Programming")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<strong class=\"d-inline-block mb-2 text-danger\">");
#nullable restore
#line 31 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                            Write(item.TypeOfJob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> ");
#nullable restore
#line 31 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                                                          }
            else if (item.TypeOfJob == "Practise")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <strong class=\"d-inline-block mb-2 text-success\">");
#nullable restore
#line 33 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                          Write(item.TypeOfJob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>");
#nullable restore
#line 33 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                                                       }
        else if (item.TypeOfJob == "Menagment")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <strong class=\"d-inline-block mb-2 text-primary\">");
#nullable restore
#line 35 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                      Write(item.TypeOfJob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>");
#nullable restore
#line 35 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                                                   }
    else if (item.TypeOfJob == "UX designer")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <strong class=\"d-inline-block mb-2 text-info\">");
#nullable restore
#line 37 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                               Write(item.TypeOfJob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>");
#nullable restore
#line 37 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                                            }
else if (item.TypeOfJob == "Support")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(" <strong class=\"d-inline-block mb-2 text-warning\">");
#nullable restore
#line 39 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                              Write(item.TypeOfJob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>");
#nullable restore
#line 39 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                                           }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<strong class=\"d-inline-block mb-2 text-secondary\">");
#nullable restore
#line 41 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                               Write(item.TypeOfJob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>");
#nullable restore
#line 41 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <strong class=\"d-inline-block mb-2 \">");
#nullable restore
#line 42 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                Write(item.TypeOfWork);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                <h3 class=\"mb-0\">");
#nullable restore
#line 43 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                            Write(item.EmailFirm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <div class=\"mb-1 text-muted\">");
#nullable restore
#line 44 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                        Write(item.AdSetted.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 44 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                           Write(item.AdSetted.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 44 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                                                Write(item.AdSetted.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 44 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                                                                    Write(item.AdSetted.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 44 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                                                                                        Write(item.AdSetted.Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"span_box mb-auto\" style=\"display:flex; flex-direction:row; flex-wrap:wrap \">\r\n\r\n");
#nullable restore
#line 47 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                     foreach (var skill in item.Technologies)
                    {

                        var random = new Random();
                        var color = String.Format("#{0:X6}", random.Next(0x1000000));


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge rounded-pill\"");
            BeginWriteAttribute("style", " style=\"", 3232, "\"", 3371, 11);
            WriteAttributeValue("        ", 3240, "background-color:", 3248, 25, true);
#nullable restore
#line 53 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
WriteAttributeValue(" ", 3265, color, 3266, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3272, ";", 3272, 1, true);
            WriteAttributeValue("\r\n        ", 3273, "width:", 3283, 16, true);
            WriteAttributeValue(" ", 3289, "120px;", 3290, 7, true);
            WriteAttributeValue("\r\n        ", 3296, "padding-left:", 3306, 23, true);
            WriteAttributeValue(" ", 3319, "10px;", 3320, 6, true);
            WriteAttributeValue("\r\n        ", 3325, "color:", 3335, 16, true);
            WriteAttributeValue(" ", 3341, "white;", 3342, 7, true);
            WriteAttributeValue("\r\n        ", 3348, "flex-grow:", 3358, 20, true);
            WriteAttributeValue(" ", 3368, "4;", 3369, 3, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 57 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                  Write(skill);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 58 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <hr />\r\n");
#nullable restore
#line 62 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                 if (item.Description == "")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"mb-auto\">Firm posted ad for position: ");
#nullable restore
#line 63 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                            Write(item.TypeOfJob);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with seniority: ");
#nullable restore
#line 63 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                                                            Write(item.Seniority);

#line default
#line hidden
#nullable disable
            WriteLiteral(" working: ");
#nullable restore
#line 63 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                                                                                     Write(item.TypeOfWork);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 63 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                                                                                                              }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"card-text mb-auto\">");
#nullable restore
#line 65 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                     Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 65 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 67 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                 if (item.OnlineInterView == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"card-text mb-auto\">Interview is online!</p>");
#nullable restore
#line 68 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <hr />\r\n                ");
#nullable restore
#line 71 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
           Write(Html.ActionLink("Ad profile", "AdProfile", new { idAd = item.IdAd, typeofJob = item.TypeOfJob }, new { @class = "btn btn-primary " }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
            <div class=""col-auto d-none d-lg-block"" style=""max-width: 25%;"">
                <svg class=""bd-placeholder-img"" width=""200"" height=""100%"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Thumbnail"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"">
                    <title>Placeholder</title> ");
#nullable restore
#line 76 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                if (item.City.ToLower() == "nis")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <rect width=\"100%\" height=\"100%\" fill=\"#b079b9\" />\r\n");
#nullable restore
#line 79 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
 }
                    else if (item.City.ToLower() == "beograd")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <rect width=\"100%\" height=\"100%\" fill=\"#0c7482\" />\r\n");
#nullable restore
#line 83 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
 }
                    else if (item.City.ToLower() == "novi sad")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <rect width=\"100%\" height=\"100%\" fill=\"#607d8b\" />\r\n");
#nullable restore
#line 87 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
 }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <rect width=\"100%\" height=\"100%\" fill=\"#55595c\" />\r\n");
#nullable restore
#line 91 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <text x=\"10%\" y=\"50%\" fill=\"#eceeef\" dy=\".3em\">");
#nullable restore
#line 92 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"
                                                              Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</text>\r\n                </svg>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 98 "C:\Users\nikol\Documents\3.OpportunITy\OpportunITyy2.6\OpportunITyy\Views\User\UserSignedIn.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




<style>
    .button_ad {
        width: fit-content;
    }

    .span_box {
        display: flex;
        flex-direction: row;
    }

    .span_element {
        width: 50px;
        margin-left: 10px;
    }

    .btn_typeJob {
        margin-left: 10px;
        margin-bottom: 20px;
    }
    .ad_new {
        width: 100%;
        border-radius: 3rem;
        margin-bottom: 20px;
    }
</style>
<script>
    var randomColor = Math.floor(Math.random() * 16777215).toString(16);
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ad>> Html { get; private set; }
    }
}
#pragma warning restore 1591
