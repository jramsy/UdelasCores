using Microsoft.EntityFrameworkCore;
using System;
using UdelasCore.Negocio.Data;
using UdelasCore.Negocio.Modelos.Modelo_Horario;
using UdelasCore.Negocio.Servicios;

var builder = WebApplication.CreateBuilder(args);

// DbContext para RECURSOS_HUMANOS
builder.Services.AddDbContext<RHHDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("UdelasConnection"),
        sqlOptions =>
        {
            sqlOptions.EnableRetryOnFailure(
                maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null);
            sqlOptions.CommandTimeout(60);
        }
    ));

// DbContext para HORARIOS_DOCENCIA
builder.Services.AddDbContext<HorarioDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("HorariosConnection"),
        sqlOptions =>
        {
            sqlOptions.EnableRetryOnFailure(
                maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null);
            sqlOptions.CommandTimeout(60);
        }
    ));

// Registro de servicios
builder.Services.AddScoped<IEstudianteService, EstudianteService>();
builder.Services.AddScoped<IMateriaService, MateriaService>();
builder.Services.AddScoped<IProfesorService, ProfesorService>();
builder.Services.AddScoped<ITernaService, TernaService>();

// Configuración de MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurar el pipeline de HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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



//Ambos contextos se registran con AddDbContext, cada uno con su cadena y configuración propia.

//Cuando uses inyección de dependencias (constructor), especifica qué contexto quieres:

//csharp
//Copiar
//Editar
//public class MiServicio
//{
//    private readonly RHHDbContext _rhContext;
//    private readonly HorarioDbContext _horarioContext;

//    public MiServicio(RHHDbContext rhContext, HorarioDbContext horarioContext)
//    {
//        _rhContext = rhContext;
//        _horarioContext = horarioContext;
//    }
//}