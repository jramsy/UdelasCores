using UdelasCore.Negocio.Modelos.Modelo_Terna;

namespace UdelasCore.Negocio.Interfaces
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