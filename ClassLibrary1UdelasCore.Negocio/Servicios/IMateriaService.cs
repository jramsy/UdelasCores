using UdelasCore.Negocio.Modelos;

namespace UdelasCore.Negocio.Servicios
{
    public interface IMateriaService
    {
        Task<IEnumerable<Materia>> ObtenerTodosAsync();
        Task<Materia?> ObtenerPorIdAsync(int id);
        Task<Materia> CrearAsync(Materia materia);
        Task<Materia> ActualizarAsync(Materia materia);
        Task<bool> EliminarAsync(int id);
    }
}