#pragma checksum "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2fc454591dc0f0656d50bf5cf4ea153f6b306be"
// <auto-generated/>
#pragma warning disable 1591
namespace CryptoTicker.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using CryptoTicker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using CryptoTicker.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.AddAttribute(1, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 3 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                         _currentTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(3);
            __builder.AddAttribute(4, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 4 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "MaxWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth?>(
#nullable restore
#line 4 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                              MaxWidth.ExtraSmall

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(9);
            __builder.AddAttribute(10, "RightToLeft", 
#nullable restore
#line 7 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                         _rightToLeft

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(14);
                    __builder3.AddAttribute(15, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                              Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 9 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                                 MudBlazor.Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 9 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                                                                Edge.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                                                                                       (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudHidden>(20);
                    __builder3.AddAttribute(21, "Breakpoint", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Breakpoint>(
#nullable restore
#line 10 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                               MudBlazor.Breakpoint.SmAndUp

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "Invert", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                                     true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudText>(24);
                        __builder4.AddAttribute(25, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 11 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                            Typo.body1

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 11 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                               Align.Center

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(28, "BLAZOR CRYPTO TRACKER");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudSpacer>(30);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudSpacer>(32);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudHidden>(34);
                    __builder3.AddAttribute(35, "Breakpoint", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Breakpoint>(
#nullable restore
#line 17 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                               MudBlazor.Breakpoint.MdAndUp

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "Invert", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                                     true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudTooltip>(38);
                        __builder4.AddAttribute(39, "Text", "Toggle light/dark theme");
                        __builder4.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(41);
                            __builder5.AddAttribute(42, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                      Icons.Material.Filled.Brightness4

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(43, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 19 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                                                MudBlazor.Color.Inherit

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(44, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                                                                                    (e) => DarkMode()

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(45, "\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudTooltip>(46);
                        __builder4.AddAttribute(47, "Text", "Check out the repo");
                        __builder4.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(49);
                            __builder5.AddAttribute(50, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                      Icons.Custom.Brands.GitHub

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(51, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 23 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                                         MudBlazor.Color.Inherit

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(52, "Link", "https://github.com/madebygps/crypto-ticker-dotnet");
                            __builder5.AddAttribute(53, "Target", "_blank");
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudHidden>(55);
                    __builder3.AddAttribute(56, "Breakpoint", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Breakpoint>(
#nullable restore
#line 27 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                               MudBlazor.Breakpoint.SmAndDown

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "Invert", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                                       true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudMenu>(59);
                        __builder4.AddAttribute(60, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                            Icons.Filled.Settings

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(61, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 28 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                          MudBlazor.Color.Inherit

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(62, "Dense", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                                                          true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(63, "Direction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Direction>(
#nullable restore
#line 28 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                                                                           MudBlazor.Direction.Right

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(64, "OffsetY", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                                                                                                               true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(66, "div");
                            __builder5.AddAttribute(67, "class", "px-2");
                            __builder5.AddAttribute(68, "b-6h19j7qvcy");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(69);
                            __builder5.AddAttribute(70, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                          Icons.Material.Filled.Brightness4

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(71, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 30 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                                                    MudBlazor.Color.Inherit

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(72, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                                                                                        (e) => DarkMode()

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(73, "\r\n                   \r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudIconButton>(74);
                            __builder5.AddAttribute(75, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                              Icons.Custom.Brands.GitHub

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(76, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 32 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                                                 MudBlazor.Color.Inherit

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(78);
                __builder2.AddAttribute(79, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                 25

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "Class", "mudblazor-appbar-band");
                __builder2.AddAttribute(81, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                          _drawerOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _drawerOpen = __value, _drawerOpen))));
                __builder2.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudDrawerHeader>(84);
                    __builder3.AddAttribute(85, "Class", "mudblazor-brand");
                    __builder3.AddAttribute(86, "LinkToIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\r\n        ");
                    __builder3.OpenComponent<CryptoTicker.Shared.NavMenu>(88);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(90);
                __builder2.AddAttribute(91, "Class", "mudblazor-main-content");
                __builder2.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudContainer>(93);
                    __builder3.AddAttribute(94, "MaxWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 47 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                MaxWidth.Large

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(96, 
#nullable restore
#line 48 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(97, "\r\n\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudScrollToTop>(98);
                    __builder3.AddAttribute(99, "TopOffset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 51 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                   400

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(100, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudFab>(101);
                        __builder4.AddAttribute(102, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                           Icons.Material.Filled.KeyboardArrowUp

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(103, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 52 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                                         MudBlazor.Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(104, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudContainer>(105);
            __builder.AddAttribute(106, "class", "mt-16");
            __builder.AddAttribute(107, "MaxWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 58 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                      MaxWidth.ExtraSmall

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(109);
                __builder2.AddAttribute(110, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 59 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                   Typo.body1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(111, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 59 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                      Align.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(113, "Made with Azure Functions, ");
                    __builder3.OpenComponent<MudBlazor.MudIcon>(114);
                    __builder3.AddAttribute(115, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                                                               Icons.Material.Filled.Favorite

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(116, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 59 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                                                                                                                                      MudBlazor.Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(117, "Title", "Favorite");
                    __builder3.CloseComponent();
                    __builder3.AddContent(118, " and Blazor");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(119, "\r\n\r\n  \r\n   ");
                __builder2.OpenComponent<MudBlazor.MudButton>(120);
                __builder2.AddAttribute(121, "Link", "https://github.com/madebygps/crypto-ticker-dotnet");
                __builder2.AddAttribute(122, "Target", "_blank");
                __builder2.AddAttribute(123, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 64 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                    Variant.Text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(124, "EndIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 65 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                     Icons.Custom.Brands.GitHub

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(125, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 66 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                  MudBlazor.Color.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(126, "Style", "text-transform:none");
                __builder2.AddAttribute(127, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 68 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(128, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(129, "\r\n    GitHub Link\r\n");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Shared\MainLayout.razor"
 

    private bool _drawerOpen = false;
    private bool _rightToLeft = false;
    private string searchValue = string.Empty;

    private void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

    private void RightToLeftToggle()
    {
        _rightToLeft = !_rightToLeft;
    }

    protected override void OnInitialized()
    {
        _currentTheme = _defaultTheme;

    }

    #region Theme

    private void DarkMode()
    {
        if (_currentTheme == _defaultTheme)
        {
            _currentTheme = _darkTheme;
        }
        else
        {
            _currentTheme = _defaultTheme;
        }
    }

    private MudTheme _currentTheme = new MudTheme();
    private readonly MudTheme _defaultTheme =
        new MudTheme()
        {
            Palette = new Palette()
            {
                Black = "#272c34"
            }
        };
    private readonly MudTheme _darkTheme =
        new MudTheme()
        {
            Palette = new Palette()
            {
                Black = "#27272f",
                Background = "#32333d",
                BackgroundGrey = "#27272f",
                Surface = "#373740",
                DrawerBackground = "#27272f",
                DrawerText = "rgba(255,255,255, 0.50)",
                AppbarBackground = "#27272f",
                AppbarText = "rgba(255,255,255, 0.70)",
                TextPrimary = "rgba(255,255,255, 0.70)",
                TextSecondary = "rgba(255,255,255, 0.50)",
                ActionDefault = "#adadb1",
                ActionDisabled = "rgba(255,255,255, 0.26)",
                ActionDisabledBackground = "rgba(255,255,255, 0.12)",
                DrawerIcon = "rgba(255,255,255, 0.50)"
            }
        };

    #endregion


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
