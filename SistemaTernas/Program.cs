using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaTernas.Helpers;
using SistemaTernas.Models;
using Udelascore.Negocio.Data;
using Udelascore.Negocio.Servicios.SistemaTernas;

var builder = WebApplication.CreateBuilder(args);
//Contexto de la base de datos de Recursos Humanos
builder.Services.AddDbContext<RecursosHumanosContext>(options =>  options.UseSqlServer(builder.Configuration.GetConnectionString("RHConnection")));
builder.Services.AddDbContext<BancoDeDatosContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BANCOConnection")));
//builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("IdentityContext")));
// Add services to the container.

//TODO AGREGAR LA CONEXION AL CONTEXT DE LOGIN

//builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
//    .AddDefaultTokenProviders();

builder.Services.Configure<ConfigSistema>(builder.Configuration.GetSection("ConfigSistema"));

builder.Services.AddControllersWithViews();

//Inyectar las clases de servicios
builder.Services.AddScoped<ProfesorService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<RecursosHumanosContext>();
    //context.Database.Migrate(); // Aplicar migraciones pendientes
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
