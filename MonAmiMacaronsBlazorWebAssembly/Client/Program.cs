global using MonAmiMacaronsBlazorWebAssembly.Shared;
global using System.Net.Http.Json;
global using MonAmiMacaronsBlazorWebAssembly.Client.Services.Products;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MonAmiMacaronsBlazorWebAssembly.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService,ProductService>();

await builder.Build().RunAsync();
