#pragma checksum "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99c14b9058b052fd1f2a9b701ce8cb4c736c1775"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWASMProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using BlazorWASMProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using BlazorWASMProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
using BlazorWASMProject.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
using BlazorWASMProject.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
using BlazorWebassemblyWebAPI.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
using CheckListLibrary.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CheckList")]
    public partial class CheckList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>CheckList</h2>");
#nullable restore
#line 13 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
 foreach (Entities.CheckList checkList in CheckLists)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "background-color: deepskyblue;height: 500px;width: 600px; margin-bottom: 50px;border-radius: 10px;padding: 10px");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "style", "margin-left: 500px");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
                                                     () => DeleteCheckList(checkList)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Delete Checklist");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "h3");
#nullable restore
#line 17 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
__builder.AddContent(9, checkList.CheckListName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "style", "margin-bottom: 50px");
            __builder.AddMarkupContent(13, "<thead style=\"font-size: 1.3em\"><th style=\"width: 300px\">Text</th>\r\n            <th style=\"width: 100px\">Description</th>\r\n            <th style=\"width: 100px\">Status</th></thead>");
#nullable restore
#line 24 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
             foreach (Entities.Entry entry in checkList.Entries)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "tr");
            __builder.OpenElement(15, "td");
            __builder.AddAttribute(16, "style", "width: 300px");
#nullable restore
#line 27 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
__builder.AddContent(17, entry.EntryText);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddAttribute(20, "style", "width: 100px");
#nullable restore
#line 28 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
__builder.AddContent(21, entry.IsDone ? " Done" : " In progress");

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "style", "width: 100px");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
                                                       () => DeleteEntry(entry, checkList.Entries)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(26, "<button>Entfernen</button>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __Blazor.BlazorWASMProject.Pages.CheckList.TypeInference.CreateCascadingValue_0(__builder, 28, 29, 
#nullable restore
#line 35 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
                               checkList.Entries

#line default
#line hidden
#nullable disable
            , 30, "EntryList", 31, (__builder2) => {
                __Blazor.BlazorWASMProject.Pages.CheckList.TypeInference.CreateCascadingValue_1(__builder2, 32, 33, 
#nullable restore
#line 36 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
                                   checkList.Id

#line default
#line hidden
#nullable disable
                , 34, "CheckListId", 35, (__builder3) => {
                    __builder3.OpenComponent<BlazorWASMProject.Pages.AddChecklistEntry>(36);
                    __builder3.AddAttribute(37, "EventAdded", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 37 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
                                               () => this.StateHasChanged()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                );
            }
            );
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\CheckList.razor"
       

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
namespace __Blazor.BlazorWASMProject.Pages.CheckList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateCascadingValue_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
