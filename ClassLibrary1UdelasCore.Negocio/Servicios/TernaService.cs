using Microsoft.EntityFrameworkCore;
using UdelasCore.Negocio.Data;
using UdelasCore.Negocio.Interfaces;
using UdelasCore.Negocio.Modelos.Modelo_Terna;

namespace UdelasCore.Negocio.Servicios
{
    public class TernaService : ITernaService
    {
        private readonly RHHDbContext _context;

        public TernaService(RHHDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Terna>> ObtenerTodosAsync()
        {
            return await _context.Ternas
                .Include(t => t.Estudiantes)
                .Include(t => t.Materias)
                .Include(t => t.Profesores)
                .ToListAsync();
        }

        public async Task<Terna?> ObtenerPorIdAsync(int id)
        {
            return await _context.Ternas
                .Include(t => t.Estudiantes)
                .Include(t => t.Materias)
                .Include(t => t.Profesores)
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<Terna> CrearAsync(Terna terna)
        {
            _context.Ternas.Add(terna);
            await _context.SaveChangesAsync();
            return terna;
        }

        public async Task<Terna> ActualizarAsync(Terna terna)
        {
            _context.Entry(terna).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return terna;
        }

        public async Task<bool> EliminarAsync(int id)
        {
            var terna = await _context.Ternas.FindAsync(id);
            if (terna == null) return false;

            _context.Ternas.Remove(terna);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
