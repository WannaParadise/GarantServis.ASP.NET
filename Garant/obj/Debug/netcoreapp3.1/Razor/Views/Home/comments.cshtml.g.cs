#pragma checksum "D:\Programmings\GarantServis-master\Garant\Views\Home\comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ad07bd934c3840766e7fe773e396bccfd2b7bf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_comments), @"mvc.1.0.view", @"/Views/Home/comments.cshtml")]
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
#line 1 "D:\Programmings\GarantServis-master\Garant\Views\_ViewImports.cshtml"
using Garant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programmings\GarantServis-master\Garant\Views\_ViewImports.cshtml"
using Garant.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ad07bd934c3840766e7fe773e396bccfd2b7bf1", @"/Views/Home/comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8647bca0d96d677ed639d300136c69d4e32ab385", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\Programmings\GarantServis-master\Garant\Views\Home\comments.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container text-center text-gradient mt-5 mb-1"">
    <h1>Отзывы</h1>
    <hr>
</div>





<div class=""col-md-12 order-md-1"">
    <h4 class=""mb-3 ml-4  "">Здесь вы можете оставить свой отзыв<br> и он будет отображен в реальном режиме </h4>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ad07bd934c3840766e7fe773e396bccfd2b7bf13989", async() => {
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6 mb-3\">\r\n                <label for=\"firstName\">Имя</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"firstName\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 532, "\"", 546, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 547, "\"", 555, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                <div class=""invalid-feedback"">
                    Valid first name is required.
                </div>
            </div>

            <div class=""col-md-6 mb-3"">
                <label for=""lastName"">Фамилия</label>
                <input type=""text"" class=""form-control"" id=""lastName""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 878, "\"", 892, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 893, "\"", 901, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                <div class=""invalid-feedback"">
                    Valid last name is required.
                </div>
            </div>
        </div>

        <div class=""mb-3"">
            <label for=""username"">Имя пользователя</label>
            <div class=""input-group"">
                <div class=""input-group-prepend"">
                    <span class=""input-group-text"">");
                WriteLiteral(@"@</span>
                </div>
                <input type=""text"" class=""form-control"" id=""username"" placeholder=""Username"" required>
                <div class=""invalid-feedback"" style=""width: 100%;"">
                    Your username is required.
                </div>
            </div>
        </div>

        <div class=""mb-3"">
            <label for=""email"">Email <span class=""text-muted"">(Необязательно)</span></label>
            <input type=""email"" class=""form-control"" id=""email"" placeholder=""пример@tut.by"">
            <div class=""invalid-feedback"">
                Please enter a valid email address for shipping updates.
            </div>
        </div>
        <div class=""mb-3"">
            <label for=""lastName"">Сообщение</label>
            <input type=""text"" class=""form-control"" id=""Message""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2136, "\"", 2150, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2151, "\"", 2159, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\r\n            <hr class=\"mb-4\">\r\n            <button class=\" button btn  btn-lg btn-block\" type=\"submit\">Отправить</button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
</div>


        <!--
    <div class=""card card-default"" id=""card_contacts"">
        <div id=""contacts"" class=""panel-collapse collapse show"" aria-expanded=""true"" style="""">
            <ul class=""list-group pull-down"" id=""contact-list"">
                <li class=""list-group-item"">
                    <div class=""row w-100"">
                        <div class=""col-12 col-sm-6 col-md-3 px-0"">
                            <img src=""http://demos.themes.guide/bodeo/assets/images/users/m101.jpg"" alt=""Mike Anamendolla"" class=""rounded-circle mx-auto d-block img-fluid"">
                        </div>
                        <div class=""col-12 col-sm-6 col-md-9 text-center text-sm-left"">
                            <span class=""name lead"">Микола  </span>                            <br>
                            <span class=""fa fa-envelope fa-fw text-muted"" data-toggle=""tooltip"" data-original-title="""" title=""""></span>
                            <span class=""text-muted small text-truncate"">mika@example.");
            WriteLiteral(@"com</span><br>
                            <span class=""name lead"" "">Гарант работает профессионально и знает свое дело, совершили сделку на довольно крупную сумму, все довольны.</span>
                        </div>
                    </div>
                </li>
                <li class=""list-group-item"">
                    <div class=""row w-100"">
                        <div class=""col-12 col-sm-6 col-md-3 px-0"">
                            <img src=""http://demos.themes.guide/bodeo/assets/images/users/m105.jpg"" alt=""Seth Frazier"" class=""img-fluid rounded-circle d-block mx-auto"">
                        </div>
                        <div class=""col-12 col-sm-6 col-md-9 text-center text-sm-left"">
                            <span class=""name lead"">Николай</span>

                            <br>
                            <span class=""fa fa-envelope fa-fw text-muted"" data-toggle=""tooltip"" title="""" data-original-title=""seth.frazier@example.com""></span>
                            <span clas");
            WriteLiteral(@"s=""text-muted small text-truncate"">seth.frazier@example.com</span><br>
                            <span class=""name lead"">Провел сделку по приобретению сообщества ВКонтакте через D1msolinoGaramt. <br>Сделка прошла быстро, без заминок, гарант все перевязал и отдал мне данные для входа к аккаунту создателя сообщества, <br>сменил пароль для входа и теперь я новый полноправный владелец сообщества. Спасибо!</span>

                        </div>
                    </div>
                </li>

                <li class=""list-group-item"">
                    <div class=""row w-100"">
                        <div class=""col-12 col-sm-6 col-md-3 px-0"">
                            <img src=""http://demos.themes.guide/bodeo/assets/images/users/w104.jpg"" alt=""Debbie Schmidt"" class=""img-fluid rounded-circle d-block mx-auto"">
                        </div>
                        <div class=""col-12 col-sm-6 col-md-9 text-center text-sm-left"">
                            <label class=""name lead"">Катя</label>
 ");
            WriteLiteral(@"                           <br>


                            <span class=""fa fa-envelope fa-fw text-muted"" data-toggle=""tooltip"" title="""" data-original-title=""seth.frazier@example.com""></span>
                            <span class=""text-muted small text-truncate"">seth.frazier@example.com</span><br>
                            <span class=""name lead""> Прошло все ок, не смотря на временные трудности с серверами. Советую всем данный сайт!</span>

                        </div>
                    </div>
                </li>
            </ul>

        </div>
    </div>
    </div>
    -->



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
