#pragma checksum "C:\Users\hp\Documents\Fiverr\NmdcUae\ActivityReport1\Client\Components\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04faf49c5b3ecf46e4ca488ce34058da7d68a554"
// <auto-generated/>
#pragma warning disable 1591
namespace ActivityReport1.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hp\Documents\Fiverr\NmdcUae\ActivityReport1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Documents\Fiverr\NmdcUae\ActivityReport1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Documents\Fiverr\NmdcUae\ActivityReport1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Documents\Fiverr\NmdcUae\ActivityReport1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\Documents\Fiverr\NmdcUae\ActivityReport1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\Documents\Fiverr\NmdcUae\ActivityReport1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hp\Documents\Fiverr\NmdcUae\ActivityReport1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hp\Documents\Fiverr\NmdcUae\ActivityReport1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hp\Documents\Fiverr\NmdcUae\ActivityReport1\Client\_Imports.razor"
using ActivityReport1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hp\Documents\Fiverr\NmdcUae\ActivityReport1\Client\_Imports.razor"
using ActivityReport1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\hp\Documents\Fiverr\NmdcUae\ActivityReport1\Client\_Imports.razor"
using ActivityReport1.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\hp\Documents\Fiverr\NmdcUae\ActivityReport1\Client\_Imports.razor"
using ActivityReport1.Client.Components.Partials;

#line default
#line hidden
#nullable disable
    public partial class Home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"content-page\"><div class=\"content\"><div class=\"container-fluid\"><div class=\"row\"><div class=\"col-12\"><div class=\"page-title-box\"><div class=\"page-title-right\"><ol class=\"breadcrumb m-0\"><li class=\"breadcrumb-item\"><a href=\"javascript: void(0);\">Uplon</a></li>\r\n                                <li class=\"breadcrumb-item active\">Dashboard</li></ol></div>\r\n                        <h4 class=\"page-title\">Dashboard</h4></div></div></div>\r\n            \r\n\r\n            <div class=\"row\"><div class=\"col-md-6 col-xl-3\"><div class=\"card-box tilebox-one\"><i class=\"icon-layers float-right m-0 h2 text-muted\"></i>\r\n                        <h6 class=\"text-muted text-uppercase mt-0\">Orders</h6>\r\n                        <h3 class=\"my-3\" data-plugin=\"counterup\">1,587</h3>\r\n                        <span class=\"badge badge-success mr-1\"> +11% </span> <span class=\"text-muted\">From previous period</span></div></div>\r\n\r\n                <div class=\"col-md-6 col-xl-3\"><div class=\"card-box tilebox-one\"><i class=\"icon-paypal float-right m-0 h2 text-muted\"></i>\r\n                        <h6 class=\"text-muted text-uppercase mt-0\">Revenue</h6>\r\n                        <h3 class=\"my-3\">$<span data-plugin=\"counterup\">46,782</span></h3>\r\n                        <span class=\"badge badge-danger mr-1\"> -29% </span> <span class=\"text-muted\">From previous period</span></div></div>\r\n\r\n                <div class=\"col-md-6 col-xl-3\"><div class=\"card-box tilebox-one\"><i class=\"icon-chart float-right m-0 h2 text-muted\"></i>\r\n                        <h6 class=\"text-muted text-uppercase mt-0\">Average Price</h6>\r\n                        <h3 class=\"my-3\">$<span data-plugin=\"counterup\">15.9</span></h3>\r\n                        <span class=\"badge badge-pink mr-1\"> 0% </span> <span class=\"text-muted\">From previous period</span></div></div>\r\n\r\n                <div class=\"col-md-6 col-xl-3\"><div class=\"card-box tilebox-one\"><i class=\"icon-rocket float-right m-0 h2 text-muted\"></i>\r\n                        <h6 class=\"text-muted text-uppercase mt-0\">Product Sold</h6>\r\n                        <h3 class=\"my-3\" data-plugin=\"counterup\">1,890</h3>\r\n                        <span class=\"badge badge-warning mr-1\"> +89% </span> <span class=\"text-muted\">Last year</span></div></div></div>\r\n            \r\n\r\n\r\n            <div class=\"row\"><div class=\"col-lg-6 col-xl-8\"><div class=\"card-box\"><h4 class=\"header-title mb-3\">Sales Statistics</h4>\r\n\r\n                        <div class=\"text-center\"><ul class=\"list-inline chart-detail-list mb-0\"><li class=\"list-inline-item\"><h6 class=\"text-info\"><i class=\"mdi mdi-circle-outline mr-1\"></i>Series A</h6></li>\r\n                                <li class=\"list-inline-item\"><h6 class=\"text-success\"><i class=\"mdi mdi-triangle-outline mr-1\"></i>Series B</h6></li>\r\n                                <li class=\"list-inline-item\"><h6 class=\"text-muted\"><i class=\"mdi mdi-square-outline mr-1\"></i>Series C</h6></li></ul></div>\r\n\r\n                        <div id=\"morris-bar-stacked\" class=\"morris-chart\" style=\"height: 320px;\"></div></div></div>\r\n\r\n                <div class=\"col-lg-6 col-xl-4\"><div class=\"card-box\"><h4 class=\"header-title mb-3\">Trends Monthly</h4>\r\n\r\n                        <div class=\"text-center mb-3\"><div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\"><button type=\"button\" class=\"btn btn-sm btn-secondary\">Today</button>\r\n                                <button type=\"button\" class=\"btn btn-sm btn-secondary\">This Week</button>\r\n                                <button type=\"button\" class=\"btn btn-sm btn-secondary\">Last Week</button></div></div>\r\n\r\n                        <div id=\"morris-donut-example\" class=\"morris-chart\" style=\"height: 268px;\"></div>\r\n\r\n                        <div class=\"text-center\"><ul class=\"list-inline chart-detail-list mb-0 mt-2\"><li class=\"list-inline-item\"><h6 class=\"text-info\"><i class=\"mdi mdi-circle-outline mr-1\"></i>English</h6></li>\r\n                                <li class=\"list-inline-item\"><h6 class=\"text-success\"><i class=\"mdi mdi-triangle-outline mr-1\"></i>Italian</h6></li>\r\n                                <li class=\"list-inline-item\"><h6 class=\"text-muted\"><i class=\"mdi mdi-square-outline mr-1\"></i>French</h6></li></ul></div></div></div></div>\r\n            \r\n\r\n\r\n            <div class=\"row\"><div class=\"col-xl-7\"><div class=\"row\"><div class=\"col-md-6\"><div class=\"card-box\"><h4 class=\"header-title mb-3\">Inbox</h4>\r\n\r\n                                <div class=\"inbox-widget slimscroll\" style=\"max-height: 324px;\"><a href=\"#\"><div class=\"inbox-item\"><div class=\"inbox-item-img\"><img src=\"/vendors/uplon/dist/assets/images/users/avatar-1.jpg\" class=\"rounded-circle\" alt></div>\r\n                                            <p class=\"inbox-item-author\">Chadengle</p>\r\n                                            <p class=\"inbox-item-text\">Hey! there I\'m available...</p>\r\n                                            <p class=\"inbox-item-date\">13:40 PM</p></div></a>\r\n                                    <a href=\"#\"><div class=\"inbox-item\"><div class=\"inbox-item-img\"><img src=\"/vendors/uplon/dist/assets/images/users/avatar-2.jpg\" class=\"rounded-circle\" alt></div>\r\n                                            <p class=\"inbox-item-author\">Tomaslau</p>\r\n                                            <p class=\"inbox-item-text text-truncate\">I\'ve finished it! See you so...</p>\r\n                                            <p class=\"inbox-item-date\">13:34 PM</p></div></a>\r\n                                    <a href=\"#\"><div class=\"inbox-item\"><div class=\"inbox-item-img\"><img src=\"/vendors/uplon/dist/assets/images/users/avatar-3.jpg\" class=\"rounded-circle\" alt></div>\r\n                                            <p class=\"inbox-item-author\">Stillnotdavid</p>\r\n                                            <p class=\"inbox-item-text\">This theme is awesome!</p>\r\n                                            <p class=\"inbox-item-date\">13:17 PM</p></div></a>\r\n                                    <a href=\"#\"><div class=\"inbox-item\"><div class=\"inbox-item-img\"><img src=\"/vendors/uplon/dist/assets/images/users/avatar-4.jpg\" class=\"rounded-circle\" alt></div>\r\n                                            <p class=\"inbox-item-author\">Kurafire</p>\r\n                                            <p class=\"inbox-item-text\">Nice to meet you</p>\r\n                                            <p class=\"inbox-item-date\">12:20 PM</p></div></a>\r\n                                    <a href=\"#\"><div class=\"inbox-item\"><div class=\"inbox-item-img\"><img src=\"/vendors/uplon/dist/assets/images/users/avatar-5.jpg\" class=\"rounded-circle\" alt></div>\r\n                                            <p class=\"inbox-item-author\">Shahedk</p>\r\n                                            <p class=\"inbox-item-text\">Hey! there I\'m available...</p>\r\n                                            <p class=\"inbox-item-date\">10:15 AM</p></div></a>\r\n                                    <a href=\"#\"><div class=\"inbox-item\"><div class=\"inbox-item-img\"><img src=\"/vendors/uplon/dist/assets/images/users/avatar-6.jpg\" class=\"rounded-circle\" alt></div>\r\n                                            <p class=\"inbox-item-author\">Adhamdannaway</p>\r\n                                            <p class=\"inbox-item-text\">This theme is awesome!</p>\r\n                                            <p class=\"inbox-item-date\">9:56 AM</p></div></a>\r\n                                    <a href=\"#\"><div class=\"inbox-item\"><div class=\"inbox-item-img\"><img src=\"/vendors/uplon/dist/assets/images/users/avatar-8.jpg\" class=\"rounded-circle\" alt></div>\r\n                                            <p class=\"inbox-item-author\">Arashasghari</p>\r\n                                            <p class=\"inbox-item-text\">Hey! there I\'m available...</p>\r\n                                            <p class=\"inbox-item-date\">10:15 AM</p></div></a>\r\n                                    <a href=\"#\"><div class=\"inbox-item\"><div class=\"inbox-item-img\"><img src=\"/vendors/uplon/dist/assets/images/users/avatar-9.jpg\" class=\"rounded-circle\" alt></div>\r\n                                            <p class=\"inbox-item-author\">Joshaustin</p>\r\n                                            <p class=\"inbox-item-text\">I\'ve finished it! See you so...</p>\r\n                                            <p class=\"inbox-item-date\">9:56 AM</p></div></a></div></div></div>\r\n\r\n                        <div class=\"col-md-6\"><div class=\"card-box\"><h4 class=\"header-title mb-3\">Sales Statistics</h4>\r\n\r\n                                <p class=\"font-weight-semibold mb-3\">iMacs <span class=\"text-danger float-right\"><b>78%</b></span></p>\r\n                                <div class=\"progress\" style=\"height: 10px;\"><div class=\"progress-bar progress-bar-striped bg-danger\" role=\"progressbar\" style=\"width: 78%\" aria-valuenow=\"78\" aria-valuemin=\"0\" aria-valuemax=\"78\"></div></div></div>\r\n\r\n                            <div class=\"card-box\"><h4 class=\"header-title mb-3\">Monthly Sales</h4>\r\n\r\n                                <p class=\"font-weight-semibold mb-2\">Macbooks <span class=\"text-success float-right\"><b>25%</b></span></p>\r\n                                <div class=\"progress\" style=\"height: 10px;\"><div class=\"progress-bar progress-bar-striped bg-success\" role=\"progressbar\" style=\"width: 25%\" aria-valuenow=\"25\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div></div></div>\r\n\r\n                            <div class=\"card-box\"><h4 class=\"header-title mb-3\">Daily Sales</h4>\r\n\r\n                                <p class=\"font-weight-semibold mb-2\">Mobiles <span class=\"text-warning float-right\"><b>75%</b></span></p>\r\n                                <div class=\"progress\" style=\"height: 10px;\"><div class=\"progress-bar progress-bar-striped bg-warning\" role=\"progressbar\" style=\"width: 75%\" aria-valuenow=\"75\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div></div></div></div></div></div>\r\n\r\n                <div class=\"col-xl-5\"><div class=\"card-box\"><h4 class=\"header-title mb-3\">Top Contracts</h4>\r\n\r\n                        <div class=\"table-responsive\"><table class=\"table table-bordered table-nowrap mb-0\"><thead><tr><th>Company</th>\r\n                                        <th>Start Date</th>\r\n                                        <th>End Date</th>\r\n                                        <th>Status</th></tr></thead>\r\n                                <tbody><tr><th class=\"text-muted\">Apple Technology</th>\r\n                                        <td>20/02/2014</td>\r\n                                        <td>19/02/2020</td>\r\n                                        <td><span class=\"badge badge-success\">Paid</span></td></tr>\r\n                                    <tr><th class=\"text-muted\">Envato Pty Ltd.</th>\r\n                                        <td>20/02/2014</td>\r\n                                        <td>19/02/2020</td>\r\n                                        <td><span class=\"badge badge-danger\">Unpaid</span></td></tr>\r\n                                    <tr><th class=\"text-muted\">Dribbble LLC.</th>\r\n                                        <td>20/02/2014</td>\r\n                                        <td>19/02/2020</td>\r\n                                        <td><span class=\"badge badge-success\">Paid</span></td></tr>\r\n                                    <tr><th class=\"text-muted\">Adobe Family</th>\r\n                                        <td>20/02/2014</td>\r\n                                        <td>19/02/2020</td>\r\n                                        <td><span class=\"badge badge-success\">Paid</span></td></tr>\r\n                                    <tr><th class=\"text-muted\">Apple Technology</th>\r\n                                        <td>20/02/2014</td>\r\n                                        <td>19/02/2020</td>\r\n                                        <td><span class=\"badge badge-danger\">Unpaid</span></td></tr>\r\n                                    <tr><th class=\"text-muted\">Envato Pty Ltd.</th>\r\n                                        <td>20/02/2014</td>\r\n                                        <td>19/02/2020</td>\r\n                                        <td><span class=\"badge badge-success\">Paid</span></td></tr></tbody></table></div></div></div></div></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
