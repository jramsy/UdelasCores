using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Udelascore.Negocio.Data;
using UdelasCore.Negocio.Data;
using UdelasCore.Negocio.Servicios.BancoDeDatos;
using UdelasCore.Negocio.Servicios.HorariosDocencia;
using UdelasCore.Negocio.Servicios.RecursosHumanos;
using UdelasCore.SistemaDeTernas.Helpers;

var builder = WebApplication.CreateBuilder(args);

//Contexto de la base de datos de Recursos Humanos
builder.Services.AddDbContext<RecursosHumanosContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RHConnection")));
builder.Services.AddDbContext<BancoDeDatosContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BANCOConnection")));
builder.Services.AddDbContext<HorariosDocenciaContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("HORARIOConnection")));
//TODO AGREGAR LA CONEXION AL CONTEXT DE LOGIN


//builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
//    .AddDefaultTokenProviders();

builder.Services.Configure<ConfigSistema>(builder.Configuration.GetSection("ConfigSistema"));

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<TernaService>();
builder.Services.AddScoped<ProfesorService>();
builder.Services.AddScoped<FacultadService>();
builder.Services.AddScoped<ExtensionService>();
builder.Services.AddScoped<SemMatService>();
builder.Services.AddScoped<MateriasPorCarreraService>();
builder.Services.AddScoped<CarreraService>();

builder.Services.AddControllers().AddJsonOptions(x =>
{
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    x.JsonSerializerOptions.WriteIndented = true;
});

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
