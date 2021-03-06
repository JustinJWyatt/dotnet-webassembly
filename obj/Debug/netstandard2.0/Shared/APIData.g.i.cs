#pragma checksum "/Users/justinwyatt/Github/dotnet-core-webassembly/Shared/APIData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b4aec3053ddad583558b26d304a509b7157c9c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public class APIData : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 36 "/Users/justinwyatt/Github/dotnet-core-webassembly/Shared/APIData.cshtml"
            
    User[] users;

    protected override async Task OnInitAsync()
    {
        users = await Http.GetJsonAsync<User[]>("https://jsonplaceholder.typicode.com/users");
    }

    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public Company Company { get; set; }
    }

    class Address
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public Geo Geo { get; set; }
    }

    class Geo
    {
        public string Lat { get; set; }
        public string Lng { get; set; }
    }

    class Company
    {
        public string Name { get; set; }
        public string CatchPhrase { get; set; }
        public string Bs { get; set; }
        
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
