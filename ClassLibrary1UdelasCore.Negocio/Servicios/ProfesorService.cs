using Microsoft.EntityFrameworkCore;
using UdelasCore.Negocio.Data;
using UdelasCore.Negocio.Interfaces;
using UdelasCore.Negocio.Modelos;

namespace UdelasCore.Negocio.Servicios
{
    public class ProfesorService : IProfesorService
    {
        private readonly RHHDbContext _context;

        public ProfesorService(RHHDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Profesor>> ObtenerTodosAsync()
        {
            return await _context.Profesores
                .Include(p => p.Ternas)
                .Include(p => p.Materias)
                .ToListAsync();
        }

        public async Task<Profesor?> ObtenerPorIdAsync(int id)
        {
            return await _context.Profesores
                .Include(p => p.Ternas)
                .Include(p => p.Materias)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Profesor> CrearAsync(Profesor profesor)
        {
            _context.Profesores.Add(profesor);
            await _context.SaveChangesAsync();
            return profesor;
        }

        public async Task<Profesor> ActualizarAsync(Profesor profesor)
        {
            _context.Entry(profesor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return profesor;
        }

        public async Task<bool> EliminarAsync(int id)
        {
            var profesor = await _context.Profesores.FindAsync(id);
            if (profesor == null) return false;

            _context.Profesores.Remove(profesor);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}