global using MonAmiMacaronsBlazorWebAssembly.Shared;
global using System.Net.Http.Json;
global using MonAmiMacaronsBlazorWebAssembly.Client.Services.Products;
global using MonAmiMacaronsBlazorWebAssembly.Client.Services.Categories;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MonAmiMacaronsBlazorWebAssembly.Client;
using Blazored.LocalStorage;
using MonAmiMacaronsBlazorWebAssembly.Client.Services.CartService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService,ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();

await builder.Build().RunAsync();
