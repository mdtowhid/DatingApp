#pragma checksum "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\Pages\Account\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "985a68a4b1d98767e35e68eb7126f0ff634c40ae"
// <auto-generated/>
#pragma warning disable 1591
namespace CertificateWebApp.Client.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\_Imports.razor"
using CertificateWebApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\_Imports.razor"
using CertificateWebApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\_Imports.razor"
using CertificateWebApp.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\_Imports.razor"
using CertificateWebApp.Shared.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/account/login")]
    public partial class Login : LoginBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Login</h3>");
#nullable restore
#line 6 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\Pages\Account\Login.razor"
 if (ShowAuthError)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert alert-danger");
            __builder.AddAttribute(3, "role", "alert");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, 
#nullable restore
#line 9 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\Pages\Account\Login.razor"
            Error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\Pages\Account\Login.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\Pages\Account\Login.razor"
                 _userForAuthentication

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\Pages\Account\Login.razor"
                                                        ExecuteLogin

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "class", "card card-body bg-light mt-5");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group row");
                __builder2.AddMarkupContent(15, "<label for=\"email\" class=\"col-md-2 col-form-label\">Email:</label>\r\n        ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "id", "email");
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\Pages\Account\Login.razor"
                                                                    _userForAuthentication.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _userForAuthentication.Email = __value, _userForAuthentication.Email))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _userForAuthentication.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __Blazor.CertificateWebApp.Client.Pages.Account.Login.TypeInference.CreateValidationMessage_0(__builder2, 25, 26, 
#nullable restore
#line 18 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\Pages\Account\Login.razor"
                                      () => _userForAuthentication.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group row");
                __builder2.AddMarkupContent(30, "<label for=\"password\" class=\"col-md-2 col-form-label\">Password:</label>\r\n        ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "type", "password");
                __builder2.AddAttribute(35, "id", "password");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\Pages\Account\Login.razor"
                                                                                       _userForAuthentication.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _userForAuthentication.Password = __value, _userForAuthentication.Password))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _userForAuthentication.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __Blazor.CertificateWebApp.Client.Pages.Account.Login.TypeInference.CreateValidationMessage_1(__builder2, 41, 42, 
#nullable restore
#line 25 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\Pages\Account\Login.razor"
                                      () => _userForAuthentication.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n    ");
                __builder2.AddMarkupContent(44, "<div class=\"row\"><div class=\"col-md-12 text-right\"><button type=\"submit\" class=\"btn btn-success\">Login</button></div></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.CertificateWebApp.Client.Pages.Account.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591