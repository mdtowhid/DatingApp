#pragma checksum "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61f011c1816b4f5f5d6f73479b757aa18abc702e"
// <auto-generated/>
#pragma warning disable 1591
namespace CertificateWebApp.Client.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-1vpvj7rno8");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-1vpvj7rno8");
            __builder.OpenComponent<CertificateWebApp.Client.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-1vpvj7rno8");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-1vpvj7rno8");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(14);
            __builder.AddAttribute(15, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 13 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\Shared\MainLayout.razor"
                     if (context is { User: { } })
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "id", "name");
                __builder2.AddAttribute(18, "b-1vpvj7rno8");
                __builder2.OpenElement(19, "b");
                __builder2.AddAttribute(20, "b-1vpvj7rno8");
                __builder2.AddContent(21, 
#nullable restore
#line 16 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\Shared\MainLayout.razor"
                                context.User.FindFirst(ClaimTypes.Name)?.Value

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(22, " \r\n                                ");
                __builder2.AddMarkupContent(23, "<a href=\"/account/logout\" b-1vpvj7rno8>Logout</a>");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 19 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\Shared\MainLayout.razor"
                    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(24, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                    The User is not authorized\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "content px-4");
            __builder.AddAttribute(29, "b-1vpvj7rno8");
            __builder.AddContent(30, 
#nullable restore
#line 28 "C:\Users\hp\Documents\Fiverr\GrandOrient\CertificateWebApp\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
