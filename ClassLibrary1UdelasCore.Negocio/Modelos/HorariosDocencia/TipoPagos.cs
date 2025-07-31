using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Table("Tipo_Pagos")]
public partial class TipoPagos
{
    [Key]
    [Column("Id_Tipo_Pago")]
    public int IdTipoPago { get; set; }

    [StringLength(75)]
    public string Descripcion { get; set; } = null!;

    [Column("Monto_Horas", TypeName = "decimal(18, 2)")]
    public decimal MontoHoras { get; set; }

    [Column("Monto_Vacaciones", TypeName = "decimal(18, 2)")]
    public decimal MontoVacaciones { get; set; }

    [Column("Tipo_Estudio")]
    public int TipoEstudio { get; set; }

    public int SubTipoGrado { get; set; }

    public int Nivel { get; set; }
}
