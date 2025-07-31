using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udelascore.Negocio.Models.RecursosHumanos
{
    public class Terna
    {

        public int IdTerna { get; set; }
        public int IdFacultad { get; set; } // HORARIO DOCENCIA
        public int IdSemestre { get; set; } // HORARIO DOCENCIA
        public int CodCarrera { get; set; } // HORARIO DOCENCIA
    }
}
