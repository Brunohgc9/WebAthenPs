using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Text.Json;
using WebAthenPs.Project.Client.Pages;
using WebAthenPs.Project.Components;
using WebAthenPs.Project.Services.Authentication;
using WebAthenPs.Project.Services.Implementation.Client;
using WebAthenPs.Project.Services.Implementation.Professional.ProfessionalTypes;
using WebAthenPs.Project.Services.Implementation.Project;
using WebAthenPs.Project.Services.Implementation.User;
using WebAthenPs.Project.Services.Interfaces.Client;
using WebAthenPs.Project.Services.Interfaces.Professional;
using WebAthenPs.Project.Services.Interfaces.Project;
using WebAthenPs.Project.Services.Interfaces.User;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();


var baseUrl = "https://localhost:7171";
builder.Services.AddHttpClient("APIWebAthenPs", options =>
{
    options.BaseAddress = new Uri(baseUrl);
});
builder.Services.AddAutoMapper(typeof(Program).Assembly); // Ensure that AutoMapper profiles are registered



builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, APIAuthenticationStateProvider>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IArchitectService, ArchitectService>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IGenericProfessionalService, GenericProfessionalService>();
builder.Services.AddSingleton(new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(WebAthenPs.Project.Client._Imports).Assembly);

app.Run();
