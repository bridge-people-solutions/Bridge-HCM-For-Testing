#pragma checksum "C:\Users\Administrator\source\repos\BridgeHCM\BridgeHCM\BridgeHCM\Views\authentication\Change_Log.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1027364e18fa4b95f92122bc1febe887079c505"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_authentication_Change_Log), @"mvc.1.0.view", @"/Views/authentication/Change_Log.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/authentication/Change_Log.cshtml", typeof(AspNetCore.Views_authentication_Change_Log))]
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
#line 1 "C:\Users\Administrator\source\repos\BridgeHCM\BridgeHCM\BridgeHCM\Views\_ViewImports.cshtml"
using BridgeHCM;

#line default
#line hidden
#line 2 "C:\Users\Administrator\source\repos\BridgeHCM\BridgeHCM\BridgeHCM\Views\_ViewImports.cshtml"
using BridgeHCM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1027364e18fa4b95f92122bc1febe887079c505", @"/Views/authentication/Change_Log.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31c1a8b16099ac4dbf6dc5ec1185e1515b27cdb5", @"/Views/_ViewImports.cshtml")]
    public class Views_authentication_Change_Log : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Files/default/pages/prism/custom-prism.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Administrator\source\repos\BridgeHCM\BridgeHCM\BridgeHCM\Views\authentication\Change_Log.cshtml"
  
    ViewData["Title"] = "Change Log";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(95, 7949, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-4 col-xl-3"">
        <div id=""navigation"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""card version"">
                        <div class=""card-header"">
                            <h5>Change Log</h5>
                            <div class=""card-header-right"">
                                <i class=""icofont icofont-navigation-menu""></i>
                            </div>
                        </div>
                        <div class=""card-block"">
                            <div class=""support-btn"">
                                <a href=""#!"" class=""btn waves-effect waves-light btn-primary btn-block""><i class=""icofont icofont-life-buoy""></i> Item support</a>
                            </div>
                            <ul class=""nav navigation"">
                                <li class=""navigation-header""><i class=""icon-history pull-right""></i> <b>Version history</b></li>
            ");
            WriteLiteral(@"                    <li class=""waves-effect waves-light"">
                                    <a href=""#v_1_0"">Version 1.0 <span class=""text-muted text-regular pull-right"">4.29.2019</span></a>
                                </li>                              
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-8 col-xl-9"">
        <div class=""col-sm-12"">
            <div class=""card"" id=""v_1_0"">
                <div class=""card-header"">
                    <h5>Version 1.0</h5>
                    <span> Initial System setups for login layout and inititial database setups.</span>
                    <div class="""">
                        <span class=""text-muted heading-text m-r-5"">April 29, 2019</span>
                        <label class=""label label-info"">V.1</label>
                    </div>
                </div>
                <div class=""card-block"">
");
            WriteLiteral(@"                    <pre class=""language-javascript"">
                        <code>
                            // # List of new components
                            // ------------------------------

                            [new]  Added Login Credentials
                            [new]  Added Logout Clear Credentials
                            [new]  Cookies and Cookies Authentication
                            [new]  Design Layout Page
                            [new]  Redesign Code structure from Webservices to WCF
                            [new]  Added dynamic Menu

                            // # Database Changes
                            // ------------------------------
                            [added]  DB Master
                            [added] Table company
                            [added] Table employee
                            [added] Table login_users
                            [added] Table module_access
                            [added] Table mo");
            WriteLiteral(@"dule_access_default
                            [added] Table module_list
                            [added] Table modules
                            [added] Table warehouse

                            // # List of added new Plugins
                            // ------------------------------
                            // Plugins Included on Mega Able Admin Template

                            [added]  animate.css
                            [added]  autosize
                            [added]  bootstrap
                            [added]  bootstrap-datepicker
                            [added]  bootstrap-daterangepicker
                            [added]  bootstrap-maxlength
                            [added]  bootstrap-multiselect
                            [added]  bootstrap-tagsinput
                            [added]  c3
                            [added]  chart.js
                            [added]  chartist
                            [added]  clndr
                 ");
            WriteLiteral(@"           [added]  countdown
                            [added]  cropper
                            [added]  d3
                            [added]  datatables.net
                            [added]  datatables.net-bs
                            [added]  datatables.net-bs4
                            [added]  datatables.net-buttons
                            [added]  datatables.net-buttons-bs4
                            [added]  datatables.net-plugins
                            [added]  datatables.net-responsive
                            [added]  datatables.net-responsive-bs
                            [added]  datatables.net-responsive-bs4
                            [added]  datatables.net-rowreorder
                            [added]  datedropper
                            [added]  ekko-lightbox
                            [added]  fastclick
                            [added]  font-awesome
                            [added]  fullcalendar
                            [added]  h");
            WriteLiteral(@"andlebars
                            [added]  handsontable
                            [added]  i18next
                            [added]  i18next-browser-languagedetector
                            [added]  i18next-xhr-backend
                            [added]  intro.js
                            [added]  jquery
                            [added]  jquery.cookie
                            [added]  jquery.steps
                            [added]  jquery.uniform
                            [added]  jquery-bar-rating
                            [added]  jquery-i18next
                            [added]  jquery-minicolors
                            [added]  jquery-slimscroll
                            [added]  jquery-sparkline
                            [added]  jquery-ui
                            [added]  jquery-validation
                            [added]  jscolor
                            [added]  jstree
                            [added]  lightbox2
                    ");
            WriteLiteral(@"        [added]  lightgallery
                            [added]  long-press
                            [added]  modernizr
                            [added]  moment
                            [added]  morris.js
                            [added]  multiselect
                            [added]  numbro
                            [added]  nvd3
                            [added]  offline
                            [added]  owl.carousel
                            [added]  peity
                            [added]  pikaday
                            [added]  d3
                            [added]  pnotify
                            [added]  popper.js
                            [added]  raphael
                            [added]  rickshaw
                            [added]  seiyria-bootstrap-slider
                            [added]  select2
                            [added]  slick-carousel
                            [added]  Sortable
                            [added]  spec");
            WriteLiteral(@"trum
                            [added]  stroll
                            [added]  sweetalert
                            [added]  swiper
                            [added]  switchery
                            [added]  tether
                            [added]  transitionize
                            [added]  typeahead.js
                            [added]  underscore

                            // # List of fixed bugs
                            // ------------------------------

                            [None]  For future testing

                        </code>
                                                                </pre>
                </div>
            </div>
        </div>
        <!-- row end -->
    </div>
</div>

");
            EndContext();
            BeginContext(8044, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1027364e18fa4b95f92122bc1febe887079c50512639", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
