#pragma checksum "/Users/justinwyatt/Github/dotnet-core-webassembly/Pages/Counter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4fabfd6e6d002e957b53fad126e1419708789b9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace dotnet_core_webassembly.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using dotnet_core_webassembly;
    using dotnet_core_webassembly.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 9 "/Users/justinwyatt/Github/dotnet-core-webassembly/Pages/Counter.cshtml"
            
    int currentCount = 0;

    void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
