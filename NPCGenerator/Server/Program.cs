using System.ComponentModel.Design;
using System.Reflection.Metadata;
using Blazored.Modal;
using Microsoft.AspNetCore.ResponseCompression;
using NPCGenerator.Server.Services;
using NPCGenerator.Shared.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
//builder.Services.AddSingleton<IMyDependency, MyDependency>();
//builder.Services.AddScoped<IMyDependency, MyDependency>(); //In non server blazor this is the same as a singleton
builder.Services.AddTransient<IMyDependency, MyDependency>();
builder.Services.AddSingleton<IGenerator, Generator>();
builder.Services.AddScoped(sp => new WeatherGenerator());
builder.Services.AddScoped(sp => new HttpClient());

builder.Services.AddBlazoredModal();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToPage("/_Host");

app.Run();

public interface IMyDependency
{
    public int GetCat();
}

public class MyDependency: IMyDependency
{
    public int cat = 1;

    public int GetCat()
    {
        return cat;
    }
}
