using Service;
using Microsoft.EntityFrameworkCore;
using Domain.Interfaces;
using Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ITipoInvestimentoService, TipoInvestimentoService>();

builder.Services.AddDbContext<InvestimentoDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("InvestimentoDb")
    ));

// Session - backup das sessions
builder.Services.AddDistributedMemoryCache();

// Session - Implementa o modelo de gerenciamento de Session
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Session - Habilita o uso
app.UseSession();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

