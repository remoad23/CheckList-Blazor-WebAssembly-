#pragma checksum "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Shared\RedirectToLogin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5efcfbe403a5705b2f6f30d9bfdc641ac1d7aead"
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
#line 10 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

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
    public partial class RedirectToLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Shared\RedirectToLogin.razor"
       

    protected override void OnInitialized()
    {
        Navigation.NavigateTo($"authentication/login?returnUrl={Uri.EscapeDataString(Navigation.Uri)}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
