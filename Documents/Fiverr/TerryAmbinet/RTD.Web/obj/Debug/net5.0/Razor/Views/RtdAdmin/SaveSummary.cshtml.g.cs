#pragma checksum "C:\Users\hp\Documents\Fiverr\TerryAmbinet\RTD.Web\Views\RtdAdmin\SaveSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b6a101f8ebf0413b15992119579e13eded73570"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RtdAdmin_SaveSummary), @"mvc.1.0.view", @"/Views/RtdAdmin/SaveSummary.cshtml")]
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
#line 1 "C:\Users\hp\Documents\Fiverr\TerryAmbinet\RTD.Web\Views\_ViewImports.cshtml"
using RTD.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Documents\Fiverr\TerryAmbinet\RTD.Web\Views\_ViewImports.cshtml"
using RTD.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b6a101f8ebf0413b15992119579e13eded73570", @"/Views/RtdAdmin/SaveSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a5d4690231751929e1e069345eee43b89074f27", @"/Views/_ViewImports.cshtml")]
    public class Views_RtdAdmin_SaveSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\hp\Documents\Fiverr\TerryAmbinet\RTD.Web\Views\RtdAdmin\SaveSummary.cshtml"
  
    ViewData["Title"] = "SaveSummary";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\hp\Documents\Fiverr\TerryAmbinet\RTD.Web\Views\RtdAdmin\SaveSummary.cshtml"
Write(Html.Partial("~/Views/RtdAdmin/_SectionNav.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Start of Summary form -->
<section class=""container rounded bg-forms p-2 mt-1 lm-user"">
    <div class=""projdetailsform rounded mx-auto"">
        <h4 class=""color-myblue py-0"">
            Section 5: <i class=""far fa-arrow-alt-circle-right pl-2 pr-2 color-mygreen""></i>
            Summary
        </h4>
        <hr>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b6a101f8ebf0413b15992119579e13eded735704482", async() => {
                WriteLiteral(@"
            <h6>Are you able to carry out normal duties?</h6>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle ml-3"">
                <input type=""radio"" class=""custom-control-input"" id=""yes"" name=""rb1"" value=""2"">
                <label class=""custom-control-label"" for=""yes"">Yes</label>
            </div>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle"">
                <input type=""radio"" class=""custom-control-input"" id=""no"" name=""rb1"" value=""2"">
                <label class=""custom-control-label"" for=""no"">No</label>
            </div>
            <hr>

            <h6>GP Accessed?</h6>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle ml-3"">
                <input type=""radio"" class=""custom-control-input"" id=""yes2"" name=""rb2"" value=""2"">
                <label class=""custom-control-label"" for=""yes2"">Yes</label>
            </div>
            <div class=""custom-control cust");
                WriteLiteral(@"om-radio custom-control-inline formstextstyle mr-5"">
                <input type=""radio"" class=""custom-control-input"" id=""no2"" name=""rb2"" value=""2"">
                <label class=""custom-control-label"" for=""no2"">No</label>
            </div>

            <h6>Support Accessed?</h6>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle ml-3"">
                <input type=""radio"" class=""custom-control-input"" id=""yes3"" name=""rb3"" value=""2"">
                <label class=""custom-control-label"" for=""yes3"">Yes</label>
            </div>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle mr-5"">
                <input type=""radio"" class=""custom-control-input"" id=""no3"" name=""rb3"" value=""2"">
                <label class=""custom-control-label"" for=""no3"">No</label>
            </div>

            <textarea class=""form-control formstextstyle"" rows=""2"" id=""description""
                      placeholder=""Additional information""></textarea>");
                WriteLiteral(@"

            <hr>
            <h6>Are you on medication?</h6>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle ml-3"">
                <input type=""radio"" class=""custom-control-input"" id=""yes4"" name=""rb4"" value=""2"">
                <label class=""custom-control-label"" for=""yes4"">Yes</label>
            </div>

            <div class=""custom-control custom-radio custom-control-inline formstextstyle mr-5"">
                <input type=""radio"" class=""custom-control-input"" id=""no4"" name=""rb4"" value=""2"">
                <label class=""custom-control-label"" for=""no4"">No</label>
            </div>

            <h6>Did it help?</h6>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle ml-3"">
                <input type=""radio"" class=""custom-control-input"" id=""yes5"" name=""rb5"" value=""2"">
                <label class=""custom-control-label"" for=""yes5"">Yes</label>
            </div>
            <div class=""custom-control custom-rad");
                WriteLiteral(@"io custom-control-inline formstextstyle mr-5"">
                <input type=""radio"" class=""custom-control-input"" id=""no5"" name=""rb5"" value=""2"">
                <label class=""custom-control-label"" for=""no5"">No</label>
            </div>

            <textarea class=""form-control formstextstyle"" rows=""2"" id=""description""
                      placeholder=""Additional information""></textarea>

            <hr>
            <h6>Personal Stress and Anxiety?</h6>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle ml-3"">
                <input type=""radio"" class=""custom-control-input"" id=""yes9"" name=""rb9"" value=""2"">
                <label class=""custom-control-label"" for=""yes9"">Yes</label>
            </div>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle mr-5"">
                <input type=""radio"" class=""custom-control-input"" id=""no9"" name=""rb9"" value=""2"">
                <label class=""custom-control-label"" for=""no9"">No</labe");
                WriteLiteral(@"l>
            </div>

            <h6>Personal Risk Assessment Completed?</h6>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle ml-3"">
                <input type=""radio"" class=""custom-control-input"" id=""yes6"" name=""rb6"" value=""2"">
                <label class=""custom-control-label"" for=""yes6"">Yes</label>
            </div>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle mr-5"">
                <input type=""radio"" class=""custom-control-input"" id=""no6"" name=""rb6"" value=""2"">
                <label class=""custom-control-label"" for=""no6"">No</label>
            </div>

            <h6>Support offered OH / EAP wellbeing?</h6>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle ml-3"">
                <input type=""radio"" class=""custom-control-input"" id=""yes7"" name=""rb7"" value=""2"">
                <label class=""custom-control-label"" for=""yes7"">Yes</label>
            </div>
          ");
                WriteLiteral(@"  <div class=""custom-control custom-radio custom-control-inline formstextstyle mr-5"">
                <input type=""radio"" class=""custom-control-input"" id=""no7"" name=""rb7"" value=""2"">
                <label class=""custom-control-label"" for=""no7"">No</label>
            </div>

            <h6>Did you access it?</h6>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle ml-3"">
                <input type=""radio"" class=""custom-control-input"" id=""yes8"" name=""rb8"" value=""2"">
                <label class=""custom-control-label"" for=""yes8"">Yes</label>
            </div>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle mr-5"">
                <input type=""radio"" class=""custom-control-input"" id=""no8"" name=""rb8"" value=""2"">
                <label class=""custom-control-label"" for=""no8"">No</label>
            </div>

            <h6>Was it useful?</h6>
            <div class=""custom-control custom-radio custom-control-inline formstextst");
                WriteLiteral(@"yle ml-3"">
                <input type=""radio"" class=""custom-control-input"" id=""yes10"" name=""rb10"" value=""2"">
                <label class=""custom-control-label"" for=""yes10"">Yes</label>
            </div>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle mr-5"">
                <input type=""radio"" class=""custom-control-input"" id=""no10"" name=""rb10"" value=""2"">
                <label class=""custom-control-label"" for=""no10"">No</label>
            </div>

            <hr>
            <h6>Have staff been informed of health and wellbeing resources?</h6>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle ml-3"">
                <input type=""radio"" class=""custom-control-input"" id=""yes11"" name=""rb11"" value=""2"">
                <label class=""custom-control-label"" for=""yes11"">Yes</label>
            </div>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle mr-5"">
                <input type=""ra");
                WriteLiteral(@"dio"" class=""custom-control-input"" id=""no11"" name=""rb11"" value=""2"">
                <label class=""custom-control-label"" for=""no11"">No</label>
            </div>

            <h6>Is this sickness related to a third party insurance claim?</h6>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle ml-3"">
                <input type=""radio"" class=""custom-control-input"" id=""yes12"" name=""rb12"" value=""2"" data-toggle=""tooltip""
                       data-placement=""top"" title=""i.e a non-fault road traffic accindent"">
                <label class=""custom-control-label"" for=""yes12"">Yes</label>
            </div>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle mr-5"">
                <input type=""radio"" class=""custom-control-input"" id=""no12"" name=""rb12"" value=""2"">
                <label class=""custom-control-label"" for=""no12"">No</label>
            </div>

            <h6>Was the sickness caused by a work related incident?</h6>
   ");
                WriteLiteral(@"         <div class=""custom-control custom-radio custom-control-inline formstextstyle ml-3"">
                <input type=""radio"" class=""custom-control-input"" id=""yes13"" name=""rb13"" value=""2"" data-toggle=""tooltip""
                       data-placement=""top"" title=""For incidents causing absences over 7 days please liaise with the H & S Team"">
                <label class=""custom-control-label"" for=""yes13"">Yes</label>
            </div>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle mr-5"">
                <input type=""radio"" class=""custom-control-input"" id=""no13"" name=""rb13"" value=""2"">
                <label class=""custom-control-label"" for=""no13"">No</label>
            </div>

            <h6>If yes, has the Trust Incidient from been completed?</h6>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle ml-3"">
                <input type=""radio"" class=""custom-control-input"" id=""yes14"" name=""rb14"" value=""2"">
                ");
                WriteLiteral(@"<label class=""custom-control-label"" for=""yes14"">Yes</label>
            </div>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle mr-5"">
                <input type=""radio"" class=""custom-control-input"" id=""no14"" name=""rb14"" value=""2"">
                <label class=""custom-control-label"" for=""no14"">No</label>
            </div>

            <h6>Has a risk assessment been completed or reviewed following this absence?</h6>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle ml-3"">
                <input type=""radio"" class=""custom-control-input"" id=""yes15"" name=""rb15"" value=""2"">
                <label class=""custom-control-label"" for=""yes15"">Yes</label>
            </div>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle mr-5"">
                <input type=""radio"" class=""custom-control-input"" id=""no15"" name=""rb15"" value=""2"">
                <label class=""custom-control-label"" for=""no15"">No");
                WriteLiteral(@"</label>
            </div>
            <hr>

            <!-- Editor -->

            <h6 class=""pb-2 color-mygreendark"">Summary of Return to Work Interview - Please enter any relevant information discussed during return to work interview</h6>
            <textarea class=""form-control formstextstyle"" rows=""12"" id=""description""
                      placeholder=""Additional Notes""></textarea>

            <hr>
            <h6>Does this episode of sickness require further action under the Attendance Policy?</h6>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle ml-3"">
                <input type=""radio"" class=""custom-control-input"" id=""yes16"" name=""rb16"" value=""2"" data-toggle=""tooltip""
                       data-placement=""top""
                       title=""If yes, please consider the following as part of the Return to Work discussion:"">
                <label class=""custom-control-label"" for=""yes16"">Yes</label>
            </div>

            <div clas");
                WriteLiteral(@"s=""custom-control custom-radio custom-control-inline formstextstyle mr-5"">
                <input type=""radio"" class=""custom-control-input"" id=""no16"" name=""rb16"" value=""2"">
                <label class=""custom-control-label"" for=""no16"">No</label>
            </div>

            <h6>
                Is there any mitigation which would mean it is not appropiate tp progress to the next stage formal meeting
                and the manager is applying discretion
            </h6>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle ml-3"">
                <input type=""radio"" class=""custom-control-input"" id=""yes17"" name=""rb17"" value=""2"">
                <label class=""custom-control-label"" for=""yes17"">Yes</label>
            </div>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle mr-5"">
                <input type=""radio"" class=""custom-control-input"" id=""no17"" name=""rb17"" value=""2"">
                <label class=""custom-control-");
                WriteLiteral(@"label"" for=""no17"">No</label>
            </div>
            <textarea class=""form-control formstextstyle"" rows=""2"" id=""description""
                      placeholder=""Additional information""></textarea>

            <h6>
                Would the employee like you to seek support from a Trade Union Representative or Colleague when arranging
                any meetings ? If so, who?
            </h6>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle ml-3"">
                <input type=""radio"" class=""custom-control-input"" id=""yes18"" name=""rb18"" value=""2"">
                <label class=""custom-control-label"" for=""yes18"">Yes</label>
            </div>
            <div class=""custom-control custom-radio custom-control-inline formstextstyle mr-5"">
                <input type=""radio"" class=""custom-control-input"" id=""no18"" name=""rb18"" value=""2"">
                <label class=""custom-control-label"" for=""no18"">No</label>
            </div>
            <textarea clas");
                WriteLiteral(@"s=""form-control formstextstyle"" rows=""2"" id=""description""
                      placeholder=""Additional information""></textarea>

            <div class=""text-right mt-3"">
                <button class=""btn btn-success"" type=""button"">Save / Update</button>
            </div>

        ");
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
            WriteLiteral("\r\n    </div>\r\n\r\n</section>\r\n<!-- End Summary Form -->-- End Sumamry RTW details -->\r\n");
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
