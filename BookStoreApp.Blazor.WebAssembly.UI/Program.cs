using Blazored.LocalStorage;
using BookStoreApp.Blazor.WebAssembly.UI;
using BookStoreApp.Blazor.Shared.UI.Configurations;
using BookStoreApp.Blazor.Shared.UI.Providers;
using BookStoreApp.Blazor.Shared.UI.Services;
using BookStoreApp.Blazor.Shared.UI.Services.Authentication;
using BookStoreApp.Blazor.Shared.UI.Services.Base;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7183") });
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<ApiAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(p => p.GetRequiredService<ApiAuthenticationStateProvider>());
builder.Services.AddAuthorizationCore();
builder.Services.AddSingleton<IClient, Client>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddAutoMapper(typeof(MapperConfig));

await builder.Build().RunAsync();