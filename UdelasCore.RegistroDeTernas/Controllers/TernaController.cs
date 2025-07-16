using Microsoft.AspNetCore.Mvc;
using UdelasCore.Negocio.Data;

public class TestController : ControllerBase
{
    private readonly RHHDbContext _context;

    public TestController(RHHDbContext context)
    {
        _context = context;
    }

    [HttpGet("test-connection")]
    public IActionResult TestConnection()
    {
        try
        {
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