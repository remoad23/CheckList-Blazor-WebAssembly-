#pragma checksum "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\AddCheckList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5653a02203fd29ab02d9eae970ca641823e21376"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWASMProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using BlazorWASMProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\_Imports.razor"
using BlazorWASMProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\AddCheckList.razor"
using BlazorWebassemblyWebAPI.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\AddCheckList.razor"
using CheckListLibrary.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\AddCheckList.razor"
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
            __builder.AddMarkupContent(0, "<h3>AddCheckList</h3>\r\n");
            __builder.AddMarkupContent(1, "<span>CheckList Name</span>\r\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "text");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\AddCheckList.razor"
              CheckListName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CheckListName = __value, CheckListName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\AddCheckList.razor"
                  CreateCheckList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Create Checklist");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\paddy\RiderProjects\BlazorWebassemblyTestProject\BlazorWASMProject\Pages\AddCheckList.razor"
       

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
