using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Usuario1 { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Cedula { get; set; } = null!;

    public int EntidadLabora { get; set; }

    public string UbicacionFisica { get; set; } = null!;

    public string Maquina { get; set; } = null!;

    public string Macadress { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public string Cargo { get; set; } = null!;

    public string Funciones { get; set; } = null!;

    /// <summary>
    /// 0 no entra, 1 consulta, 5 operativo , 6 administrador
    /// </summary>
    public int NivelAcceso { get; set; }

    public string FechaCreacion { get; set; } = null!;

    public string Observacion { get; set; } = null!;

    public string CreadorCuenta { get; set; } = null!;

    public int Facultad { get; set; }

    public int Escuela { get; set; }

    public int Carreras { get; set; }

    public int Extension { get; set; }

    public Guid? Guidusuario { get; set; }

    public int? Codunidad { get; set; }
}
