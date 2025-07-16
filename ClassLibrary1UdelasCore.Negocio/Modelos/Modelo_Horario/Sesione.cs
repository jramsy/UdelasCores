using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class Sesione
{
    public string IdSesion { get; set; } = null!;

    public string TablasAfectadas { get; set; } = null!;

    public string TipoDeOperaciones { get; set; } = null!;

    public int IdUsuario { get; set; }

    public string Maquina { get; set; } = null!;

    public string Macadress { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public string Fecha { get; set; } = null!;

    public string Hora { get; set; } = null!;
}
