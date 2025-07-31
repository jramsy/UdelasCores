using Microsoft.EntityFrameworkCore;
using Udelascore.Negocio.Data;
using Udelascore.Negocio.Models.RecursosHumanos;
using UdelasCore.Negocio.Data;
using UdelasCore.Negocio.Modelos.RecursosHumanos.DTOs;
using UdelasCore.Negocio.Modelos.RecursosHumanos.DTOs.TernaDetalles;
using UdelasCore.Negocio.Modelos.RecursosHumanos.DTOs.Ternas;

namespace UdelasCore.Negocio.Servicios.SistemaTernas
{
    public class TernaService
    {
        private readonly RecursosHumanosContext _context;
        private readonly HorariosDocenciaContext _horariosDocenciaContext;
        public TernaService(RecursosHumanosContext context, HorariosDocenciaContext horariosDocenciaContext)
        {
            _context = context;
            _horariosDocenciaContext = horariosDocenciaContext;
        }
        public async Task<List<ObtainTernasDTO>> GetAllTernasAsync()
        {
            var ternas = await _context.Ternas.Include(t => t.Estado)
                                              .ToListAsync();

            var codCarreras = ternas.Select(t => t.CodCarrera).Distinct().ToList();
            var codMaterias = ternas.Select(t => t.CodMateria).Distinct().ToList();

            var mpcs = await _horariosDocenciaContext.MateriasPorCarreras
                .AsNoTracking()
                .ToListAsync();

            var carreras = await _horariosDocenciaContext.Carreras.ToListAsync();
            var facultades = await _horariosDocenciaContext.Facultades.ToListAsync();
            var semestres = await _horariosDocenciaContext.SemMat.ToListAsync();

            var resultado = (from t in ternas
                             join mpc in mpcs on new { t.CodCarrera, t.CodMateria }
                                 equals new { CodCarrera = mpc.CodCarrera, CodMateria = mpc.CodMateria }
                             join ca in carreras on mpc.CodCarrera equals ca.CodCarrera
                             join fa in facultades on ca.CodFacultad2 equals fa.CodFacultad
                             select new ObtainTernasDTO
                             {
                                 Descripcion = mpc.Descripcion,
                                 Carrera = ca.Carrera,
                                 IdTerna = t.IdTerna,
                                 Facultad = fa.Facultad,
                                 Periodo = mpc.Periodo,
                                 CodCarrera = t.CodCarrera,
                                 CodMateria = t.CodMateria,
                                 Anio = t.Anio,
                                 NomPeriodo = semestres.FirstOrDefault(sm => sm.Codigo == mpc.Periodo)?.NomSemMateria,
                                 EstadoNombre = t.Estado?.Nombre,
                                 FechaInicio = t.FechaInicio,
                                 FechaFinal = t.FechaFinal,
                                 IdEstado = t.EstadoIdEstado
                             }).ToList();


            return resultado ?? new List<ObtainTernasDTO>();
        }
        public async Task<List<TernaDetalleProfesorDTO>> GetTernasDetalleByIdAsync(int id)
        {
            if (id <= 0)
                return new List<TernaDetalleProfesorDTO>();

            var query = @"
                SELECT 
            TD.IdTernaDetalle,
            TD.IdTerna,
            TD.IdEstado,
            TD.CedDocente,

            PR.Cod_prof,
            PR.Cedula,
            PR.Nombre,
            PR.Apellido,
            PR.Telefono,
            PR.Celular,
            PR.Provincia,
            PR.Turnom,

            ED.Id_Estudio AS IdEstudio,
            ED.Cedula AS CedulaEstudio,
            ED.Cod_Tipo_Estudio,
            ED.Nombre_Estudio,
            ED.Puntaje AS PuntajeEstudio,
            ED.Provincia AS ProvinciaEstudio,
            ED.Habilitado AS HabilitadoEstudio,
            ED.Direccion AS DireccionEstudio

        FROM TernaDetalles TD
        INNER JOIN [BANCO DE DATOS].dbo.Bd_profesor PR 
            ON TD.CedDocente COLLATE SQL_Latin1_General_CP1_CI_AS = PR.Cedula
        INNER JOIN [BANCO DE DATOS].dbo.Bd_Estudios_Docentes ED 
            ON ED.Cedula = PR.Cedula
        WHERE TD.IdTerna = {0} AND Cod_Tipo_Estudio = 2";

            var resultado = await _context.Set<TernaDetalleProfesorDTO>()
                .FromSqlRaw(query, id)
                .ToListAsync();

            return resultado ?? new List<TernaDetalleProfesorDTO>();
        }
        public async Task<Terna?> GetTernaByIdAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El Id de la terna debe ser mayor que cero.", nameof(id));

            return await _context.Ternas
                                 .AsNoTracking()
                                 .SingleOrDefaultAsync(t => t.IdTerna == id);
        }
        public async Task<bool> UpdateTernaDetalleAsync(ActualizarTernaDetalleDTO detalle)
        {
            if (detalle == null || detalle.IdTernaDetalle <= 0)
                return false;
            var ternaDetalle = await _context.TernaDetalles.FindAsync(detalle.IdTernaDetalle);
            if (ternaDetalle == null)
                return false;

            if (detalle.IdEstado != 0 || detalle.IdEstado != null)
            {
                //Actualizar el estado de la terna apenas se acepta o rechaza una TernaDetalle
                var terna = await this.GetTernaByIdAsync(detalle.IdTerna);
                ternaDetalle.IdEstado = (int)detalle.IdEstado;
                terna.Estado.IdEstado = (int)detalle.IdEstado;
            }


            ternaDetalle.IdUsuarioModificador = detalle.IdUsuarioModificador;
            ternaDetalle.FechaModificacion = detalle.FechaModificacion ?? DateTime.Now;
            _context.TernaDetalles.Update(ternaDetalle);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateTernaEstado(ActualizarTernaEstadoDTO datos)
        {
            if (datos == null || datos.IdTerna <= 0)
                return false;

            var terna = await _context.Ternas.FindAsync(datos.IdTerna);

            if (terna == null)
                return false;

            // Actualizar el estado de la terna
            terna.IdUsuarioModificador = datos.IdUsuarioModificador;
            terna.FechaModificacion = datos.FechaModificacion ?? DateTime.Now;

            if (datos.IdEstado != 0)
            {
                terna.EstadoIdEstado = datos.IdEstado;
                //Buscar terna detalle seleccionado
                if (datos.IdTernaDetalleSeleccionado.HasValue && datos.IdTernaDetalleSeleccionado > 0)
                {
                    var ternaDetalle = await _context.TernaDetalles
                        .FirstOrDefaultAsync(td => td.IdTernaDetalle == datos.IdTernaDetalleSeleccionado);

                    if (ternaDetalle != null)
                    {
                        ternaDetalle.IdEstado = datos.IdEstado;
                        ternaDetalle.IdUsuarioModificador = datos.IdUsuarioModificador;
                        ternaDetalle.FechaModificacion = datos.FechaModificacion ?? DateTime.Now;
                        _context.TernaDetalles.Update(ternaDetalle);
                    }
                }
            }

            // Guardar todos los cambios realizados
            _context.Ternas.Update(terna);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
