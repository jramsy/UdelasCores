using UdelasCore.Negocio.Modelos.Modelo.Terna;

namespace UdelasCore.Negocio.Servicios
{
    public interface IEstudianteService
    {
        Task<IEnumerable<Estudiante>> ObtenerTodosAsync();
        Task<Estudiante?> ObtenerPorIdAsync(int id);
        Task<Estudiante> CrearAsync(Estudiante estudiante);
        Task<Estudiante> ActualizarAsync(Estudiante estudiante);
        Task<bool> EliminarAsync(int id);
    }
}