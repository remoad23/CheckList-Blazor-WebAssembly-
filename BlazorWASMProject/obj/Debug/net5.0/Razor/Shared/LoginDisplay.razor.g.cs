#pragma checksum "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b903ac8f4ec84d32d75ef28a32053d0007086052"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWASMProject.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using BlazorWASMProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using BlazorWASMProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        Hello, ");
#nullable restore
#line 9 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Shared\LoginDisplay.razor"
__builder2.AddContent(3, context.User.Identity.Name);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(4, "!\r\n        ");
                __builder2.OpenElement(5, "button");
                __builder2.AddAttribute(6, "class", "nav-link btn btn-link");
                __builder2.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Shared\LoginDisplay.razor"
                                                        BeginSignOut

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(8, "Log out");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "<a href=\"authentication/login\">Log in</a>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Shared\LoginDisplay.razor"
      

    private async Task BeginSignOut(MouseEventArgs args)
    {
        await SignOutManager.SetSignOutState();
        Navigation.NavigateTo("authentication/logout");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
