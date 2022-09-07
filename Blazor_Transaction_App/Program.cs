using Blazor_Transaction_App.Data;
using Blazor_Transaction_App.Interfaces;
using Blazor_Transaction_App.Models;
using Blazor_Transaction_App.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDbContext<TransactionContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("TransactionDbConnection"));
});
builder.Services.AddScoped<ITransactionService, TransactionService>();
builder.Services.AddScoped<ICreditService, CreditService>();
builder.Services.AddScoped<IDebitService, DebitService>();
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
