global using MonAmiMacaronsBlazorWebAssembly.Shared;
global using System.Net.Http.Json;
global using MonAmiMacaronsBlazorWebAssembly.Client.Services.Products;
global using MonAmiMacaronsBlazorWebAssembly.Client.Services.Categories;
global using MonAmiMacaronsBlazorWebAssembly.Client.Services.CartService;
global using MonAmiMacaronsBlazorWebAssembly.Client.Services.OrderService;
global using MonAmiMacaronsBlazorWebAssembly.Client.Services.AuthService;
global using MonAmiMacaronsBlazorWebAssembly.Client.Services.AddressService;
global using MonAmiMacaronsBlazorWebAssembly.Client.Services.ProductTypeService;
global using MonAmiMacaronsBlazorWebAssembly.Client.Services.EmailService;

global using Microsoft.AspNetCore.Components.Authorization;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MonAmiMacaronsBlazorWebAssembly.Client;
using Blazored.LocalStorage;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddMudServices();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IProductTypeService, ProductTypeService>();
builder.Services.AddScoped<IEmailService, EmailService>();

builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvidercs>();

await builder.Build().RunAsync();
