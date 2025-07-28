using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udelascore.Negocio.Data;
using UdelasCore.Negocio.Modelos.RecursosHumanos.DTOs;

namespace UdelasCore.Negocio.Servicios.SistemaTernas
{
    public class TernaService
    {
        private readonly RecursosHumanosContext _context;

        public TernaService(RecursosHumanosContext context)
        {
            _context = context;
        }

        public async Task<List<ObtainTernasDTO>> GetAllTernasAsync()
        {
            var resultado = await _context.Set<ObtainTernasDTO>()
                              .FromSqlRaw(@"
    SELECT 
        MPC.descripcion, 
        CA.carrera, 
        T.IdTerna, 
        FA.facultad, 
        MPC.periodo, 
        T.CodCarrera, 
        T.CodMateria, 
        T.Anio,
        (SELECT Nom_sem_materia FROM Sem_mats SM WHERE SM.Codigo = MPC.periodo) AS NomPeriodo
    FROM Ternas T
        INNER JOIN [HORARIOS DOCENCIA].dbo.Materias_por_carreras MPC 
            ON T.CodCarrera = MPC.cod_carrera AND MPC.cod_materia = T.CodMateria
        INNER JOIN [HORARIOS DOCENCIA].dbo.Carreras CA 
            ON MPC.cod_carrera = CA.cod_carrera
        INNER JOIN [HORARIOS DOCENCIA].dbo.Facultades FA 
            ON Ca.cod_facultad2 = FA.cod_facultad
").ToListAsync();


            return resultado ?? new List<ObtainTernasDTO>();
        }

    }
}
