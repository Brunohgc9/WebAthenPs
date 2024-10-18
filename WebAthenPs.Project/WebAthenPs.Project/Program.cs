using Blazored.LocalStorage;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Text.Json;
using WebAthenPs.Project.Client.Pages;
using WebAthenPs.Project.Components;
using WebAthenPs.Project.Services.Authentication;
using WebAthenPs.Project.Services.Implementation;
using WebAthenPs.Project.Services.Implementation.Components;
using WebAthenPs.Project.Services.Implementation.Professional.ProfessionalTypes;
using WebAthenPs.Project.Services.Implementation.Project;
using WebAthenPs.Project.Services.Implementation.User;
using WebAthenPs.Project.Services.Interfaces.Client;
using WebAthenPs.Project.Services.Interfaces.Components;
using WebAthenPs.Project.Services.Interfaces.Professional;
using WebAthenPs.Project.Services.Interfaces.Project;
using WebAthenPs.Project.Services.Interfaces.User;
using WebAthenPs.Services.Implementation.Comments;
using WebOllamaChat.Client.SignalConnections;

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


builder.Services.AddScoped<SignalRConnection>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddScoped<AuthenticationStateProvider, APIAuthenticationStateProvider>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProposalService, ProposalService>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IArchitectService, ArchitectService>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IGenericProfessionalService, GenericProfessionalService>();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddSingleton(new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
});
builder.Services.AddSignalR();

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
