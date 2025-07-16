using UdelasCore.Negocio.Modelos.Modelo_Terna;

namespace UdelasCore.Negocio.Servicios
{
    public interface ITernaService
    {
        Task<IEnumerable<Terna>> ObtenerTodosAsync();
        Task<Terna?> ObtenerPorIdAsync(int id);
        Task<Terna> CrearAsync(Terna terna);
        Task<Terna> ActualizarAsync(Terna terna);
        Task<bool> EliminarAsync(int id);
    }
}