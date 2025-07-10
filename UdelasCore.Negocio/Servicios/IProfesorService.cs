using UdelasCore.Negocio.Modelos.Modelo.Terna;

namespace UdelasCore.Negocio.Servicios
{
    public interface IProfesorService
    {
        Task<IEnumerable<Profesor>> ObtenerTodosAsync();
        Task<Profesor?> ObtenerPorIdAsync(int id);
        Task<Profesor> CrearAsync(Profesor profesor);
        Task<Profesor> ActualizarAsync(Profesor profesor);
        Task<bool> EliminarAsync(int id);
    }
}