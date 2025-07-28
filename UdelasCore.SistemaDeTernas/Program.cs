using Microsoft.EntityFrameworkCore;
using Udelascore.Negocio.Data;
using UdelasCore.Negocio.Servicios.SistemaTernas;
using UdelasCore.SistemaDeTernas.Helpers;

var builder = WebApplication.CreateBuilder(args);

//Contexto de la base de datos de Recursos Humanos
builder.Services.AddDbContext<RecursosHumanosContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RHConnection")));
builder.Services.AddDbContext<BancoDeDatosContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BANCOConnection")));

//TODO AGREGAR LA CONEXION AL CONTEXT DE LOGIN


//builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
//    .AddDefaultTokenProviders();

builder.Services.Configure<ConfigSistema>(builder.Configuration.GetSection("ConfigSistema"));

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<TernaService>();

var app = builder.Build();

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
