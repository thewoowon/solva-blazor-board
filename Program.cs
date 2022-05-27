using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SolvaBlazorBoard.Data;
using SolvaBlazorBoard.Entity;
using SolvaBlazorBoard.Service;
using SolvaBlazorBoard.Services;
using SolvaBlazorBoard.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<BoardService>();
builder.Services.AddScoped<ChatService>();
builder.Services.AddScoped<NewsService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IAlertService, AlertService>();
builder.Services.AddScoped<IHttpService, HttpService>();
builder.Services.AddScoped<ILocalStorageService, LocalStorageService>();

builder.Services.AddScoped(x =>
{
    var apiUrl = new Uri(builder.Configuration["apiUrl"]);

    if (builder.Configuration["fakeBackend"] == "true")
    {
        var fakeBackendHandler = new FakeBackendHandler(x.GetService<ILocalStorageService>());
        return new HttpClient(fakeBackendHandler) { BaseAddress = apiUrl };
    }
    return new HttpClient() { BaseAddress = apiUrl };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
