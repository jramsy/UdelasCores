using ClassLibrary1UdelasCore.Negocio.Data;
using Microsoft.AspNetCore.Mvc;
using UdelasCore.Negocio.Data;

public class TestController : ControllerBase
{
    private readonly TernasDbContext _context;
    private readonly HorariosDbContext _contextHorario;

    public TestController(TernasDbContext context, HorariosDbContext contextHorario)
    {
        _context = context;
        _contextHorario = contextHorario;


	}

    [HttpGet("test-connection")]
    public IActionResult TestConnection()
    {
        try
        {
            var prueba = _contextHorario.Usuarios
            var canConnect = _context.Database.CanConnect();
            return Ok(new
            {
                Success = canConnect,
                Message = canConnect ? "Conexión exitosa" : "No se pudo conectar"
            });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new
            {
                Success = false,
                Message = ex.Message,
                Details = ex.ToString()
            });
        }
    }
}