// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWASMProject.Pages
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
#nullable restore
#line 2 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\AddCheckList.razor"
using BlazorWebassemblyWebAPI.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\AddCheckList.razor"
using CheckListLibrary.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\AddCheckList.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddCheckList")]
    public partial class AddCheckList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\AddCheckList.razor"
       

    private string CheckListName { get; set; }
    
    private async Task CreateCheckList()
    {
        try
        {
            Entities.CheckList list = new()
            {
                Id = Guid.NewGuid(),
                CheckListName = CheckListName
            };
            ChecklistRepository.Add(list);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenericRepository<Entities.CheckList> ChecklistRepository { get; set; }
    }
}
#pragma warning restore 1591
