#pragma checksum "/Users/justinwyatt/Github/dotnet-core-webassembly/Shared/MainLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30ef7b83f3127764f171582d0cc4452753f49c06"
// <auto-generated/>
#pragma warning disable 1591
namespace dotnet_core_webassembly.Shared
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
    public class MainLayout : BlazorLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "main");
            builder.AddContent(2, "\n    ");
            builder.AddMarkupContent(3, "<div class=\"top-row px-4\">\n        <a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\n    </div>\n\n    ");
            builder.OpenElement(4, "div");
            builder.AddAttribute(5, "class", "content px-4");
            builder.AddContent(6, "\n        ");
            builder.AddContent(7, Body);
            builder.AddContent(8, "\n    ");
            builder.CloseElement();
            builder.AddContent(9, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
