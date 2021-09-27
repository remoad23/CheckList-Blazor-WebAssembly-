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
#line 3 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

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
using BlazorWASMProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using BlazorWASMProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
using BlazorWASMProject.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
using BlazorWASMProject.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
using CheckListLibrary.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CheckList")]
    public partial class CheckList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "S:\streamBASE\SourceCodes\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
       

    public List<Entities.CheckList> CheckLists { get; set; } = new List<Entities.CheckList>();

    private async Task DeleteCheckList(Entities.CheckList checkList)
    {
        try
        {
            CheckListRepository.Remove(checkList);
            CheckLists.Remove(checkList);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        this.StateHasChanged();
    }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            var checkListToPass = await CheckListRepository.GetAll().ConfigureAwait(false);
            CheckLists = checkListToPass.ToList();
            foreach (Entities.CheckList checklist in CheckLists)
            {
                if (checklist.Entries is null)
                    checklist.Entries = new List<Entry>();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task DeleteEntry(Entities.Entry entry,List<Entities.Entry> entityList)
    {
        try
        {
            EntryRepository.Remove(entry);
            entityList.Remove(entry);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        this.StateHasChanged();
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenericRepository<Entities.Entry> EntryRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenericRepository<Entities.CheckList> CheckListRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
