using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class ComprobanteDePlanillas
{
    public int IdComprobante { get; set; }

    [Key]
    [Column("Num_Doc")]
    public int NumDoc { get; set; }

    [StringLength(2)]
    public string NoCia { get; set; } = null!;

    [StringLength(3)]
    public string CodEntidad { get; set; } = null!;

    [StringLength(3)]
    public string CodPlanilla { get; set; } = null!;

    public int TipoPago { get; set; }

    public int CodPago { get; set; }

    [StringLength(2)]
    public string Depto { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaPlanilla { get; set; }

    [StringLength(10)]
    public string CodEmpleado { get; set; } = null!;

    [StringLength(15)]
    public string CedulaPlanilla { get; set; } = null!;

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(50)]
    public string Apellido { get; set; } = null!;

    [StringLength(1)]
    public string Sexo { get; set; } = null!;

    [StringLength(50)]
    public string Cuenta { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal MontoBruto { get; set; }

    [Column("ISR", TypeName = "decimal(18, 2)")]
    public decimal Isr { get; set; }

    [Column("CodISR")]
    [StringLength(2)]
    public string CodIsr { get; set; } = null!;

    public int Dependientes { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal SegSocial { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal SegEdu { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal DescuTotal { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal MontoNeto { get; set; }

    [StringLength(3)]
    public string Area { get; set; } = null!;

    [StringLength(50)]
    public string Cheque { get; set; } = null!;

    [StringLength(50)]
    public string FechaCheque { get; set; } = null!;

    [StringLength(50)]
    public string Partida { get; set; } = null!;

    [Column("Descuento_A", TypeName = "decimal(18, 2)")]
    public decimal DescuentoA { get; set; }

    [Column("Acreedor_A")]
    public int AcreedorA { get; set; }

    [Column("Clave_A")]
    [StringLength(2)]
    public string ClaveA { get; set; } = null!;

    [Column("CoDesc_A")]
    public int CoDescA { get; set; }

    [Column("CtaDesc_A")]
    public int CtaDescA { get; set; }

    [Column("Descuento_B", TypeName = "decimal(18, 2)")]
    public decimal DescuentoB { get; set; }

    [Column("Acreedor_B")]
    public int AcreedorB { get; set; }

    [Column("Clave_B")]
    [StringLength(2)]
    public string ClaveB { get; set; } = null!;

    [Column("CoDesc_B")]
    public int CoDescB { get; set; }

    [Column("CtaDesc_B")]
    public int CtaDescB { get; set; }

    [Column("Descuento_C", TypeName = "decimal(18, 2)")]
    public decimal DescuentoC { get; set; }

    [Column("Acreedor_C")]
    public int AcreedorC { get; set; }

    [Column("Clave_C")]
    [StringLength(2)]
    public string ClaveC { get; set; } = null!;

    [Column("CoDesc_C")]
    public int CoDescC { get; set; }

    [Column("CtaDesc_C")]
    public int CtaDescC { get; set; }

    [Column("Descuento_D", TypeName = "decimal(18, 2)")]
    public decimal DescuentoD { get; set; }

    [Column("Acreedor_D")]
    public int AcreedorD { get; set; }

    [Column("Clave_D")]
    [StringLength(2)]
    public string ClaveD { get; set; } = null!;

    [Column("CoDesc_D")]
    public int CoDescD { get; set; }

    [Column("CtaDesc_D")]
    public int CtaDescD { get; set; }

    [Column("Descuento_E", TypeName = "decimal(18, 2)")]
    public decimal DescuentoE { get; set; }

    [Column("Acreedor_E")]
    public int AcreedorE { get; set; }

    [Column("Clave_E")]
    [StringLength(2)]
    public string ClaveE { get; set; } = null!;

    [Column("CoDesc_E")]
    public int CoDescE { get; set; }

    [Column("CtaDesc_E")]
    public int CtaDescE { get; set; }

    [StringLength(13)]
    public string Cedula { get; set; } = null!;

    [StringLength(2)]
    public string Mes { get; set; } = null!;

    [StringLength(4)]
    public string Anio { get; set; } = null!;

    [Column("Descuento_F", TypeName = "decimal(18, 2)")]
    public decimal DescuentoF { get; set; }

    [Column("Acreedor_F")]
    public int AcreedorF { get; set; }

    [Column("Clave_F")]
    [StringLength(2)]
    public string ClaveF { get; set; } = null!;

    [Column("CoDesc_F")]
    public int CoDescF { get; set; }

    [Column("CtaDesc_F")]
    public int CtaDescF { get; set; }

    [Column("Descuento_G", TypeName = "decimal(18, 2)")]
    public decimal DescuentoG { get; set; }

    [Column("Acreedor_G")]
    public int AcreedorG { get; set; }

    [Column("Clave_G")]
    [StringLength(2)]
    public string ClaveG { get; set; } = null!;

    [Column("CoDesc_G")]
    public int CoDescG { get; set; }

    [Column("CtaDesc_G")]
    public int CtaDescG { get; set; }

    [Column("Descuento_H", TypeName = "decimal(18, 2)")]
    public decimal DescuentoH { get; set; }

    [Column("Acreedor_H")]
    public int AcreedorH { get; set; }

    [Column("Clave_H")]
    [StringLength(2)]
    public string ClaveH { get; set; } = null!;

    [Column("CoDesc_H")]
    public int CoDescH { get; set; }

    [Column("CtaDesc_H")]
    public int CtaDescH { get; set; }

    [Column("Descuento_I", TypeName = "decimal(18, 2)")]
    public decimal DescuentoI { get; set; }

    [Column("Acreedor_I")]
    public int AcreedorI { get; set; }

    [Column("Clave_I")]
    [StringLength(2)]
    public string ClaveI { get; set; } = null!;

    [Column("CoDesc_I")]
    public int CoDescI { get; set; }

    [Column("CtaDesc_I")]
    public int CtaDescI { get; set; }

    [Column("Descuento_J", TypeName = "decimal(18, 2)")]
    public decimal DescuentoJ { get; set; }

    [Column("Acreedor_J")]
    public int AcreedorJ { get; set; }

    [Column("Clave_J")]
    [StringLength(2)]
    public string ClaveJ { get; set; } = null!;

    [Column("CoDesc_J")]
    public int CoDescJ { get; set; }

    [Column("CtaDesc_J")]
    public int CtaDescJ { get; set; }

    public int Enviado { get; set; }

    public Guid GuidPago { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaRegistro { get; set; }

    public int Estatus { get; set; }
}
