using ClassLibrary1UdelasCore.Negocio.Data;
using Microsoft.EntityFrameworkCore;
using UdelasCore.Negocio.Data;
using UdelasCore.Negocio.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Configuraci�n del DbContext con reintentos y timeout
builder.Services.AddDbContext<TernasDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("TernasConnection"),
        sqlOptions =>
        {
            sqlOptions.EnableRetryOnFailure(
                maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null);
            sqlOptions.CommandTimeout(60); // 60 segundos
        }
    ));

// Configuraci�n del DbContext para Horarios
builder.Services.AddDbContext<HorariosDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HorariosConnection")));

// Registro de servicios
builder.Services.AddScoped<IEstudianteService, EstudianteService>();
builder.Services.AddScoped<IMateriaService, MateriaService>();
builder.Services.AddScoped<IProfesorService, ProfesorService>();
builder.Services.AddScoped<ITernaService, TernaService>();

// Configuraci�n de MVC
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