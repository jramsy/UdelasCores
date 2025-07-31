using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Udelascore.Negocio.Models.BancoDeDatos;

namespace Udelascore.Negocio.Data;

public partial class BancoDeDatosContext : DbContext
{

    public BancoDeDatosContext(DbContextOptions<BancoDeDatosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BdAnno> BdAnno { get; set; }

    public virtual DbSet<BdCantidadEspecialidad> BdCantidadEspecialidad { get; set; }

    public virtual DbSet<BdCategorias> BdCategorias { get; set; }

    public virtual DbSet<BdCedulaxcurso> BdCedulaxcurso { get; set; }

    public virtual DbSet<BdConferencia> BdConferencia { get; set; }

    public virtual DbSet<BdDoctorado> BdDoctorado { get; set; }

    public virtual DbSet<BdDoctoradoEliminado> BdDoctoradoEliminado { get; set; }

    public virtual DbSet<BdEjecutoria> BdEjecutoria { get; set; }

    public virtual DbSet<BdEspecialidad> BdEspecialidad { get; set; }

    public virtual DbSet<BdEspecialidadEliminados> BdEspecialidadEliminados { get; set; }

    public virtual DbSet<BdEstudios> BdEstudios { get; set; }

    public virtual DbSet<BdEstudiosDocentes> BdEstudiosDocentes { get; set; }

    public virtual DbSet<BdEstudiosEspeciales> BdEstudiosEspeciales { get; set; }

    public virtual DbSet<BdEstudiosSem> BdEstudiosSem { get; set; }

    public virtual DbSet<BdEstudiosTotales> BdEstudiosTotales { get; set; }

    public virtual DbSet<BdExperiencia> BdExperiencia { get; set; }

    public virtual DbSet<BdExperienciadocente> BdExperienciadocente { get; set; }

    public virtual DbSet<BdLicenciatura> BdLicenciatura { get; set; }

    public virtual DbSet<BdLicenciaturaEliminados> BdLicenciaturaEliminados { get; set; }

    public virtual DbSet<BdMaestria> BdMaestria { get; set; }

    public virtual DbSet<BdMaestriaEliminado> BdMaestriaEliminado { get; set; }

    public virtual DbSet<BdOtrasejecutorias> BdOtrasejecutorias { get; set; }

    public virtual DbSet<BdOtrosEstudios> BdOtrosEstudios { get; set; }

    public virtual DbSet<BdPerfeccionamiento> BdPerfeccionamiento { get; set; }

    public virtual DbSet<BdPonencia> BdPonencia { get; set; }

    public virtual DbSet<BdPostgrado> BdPostgrado { get; set; }

    public virtual DbSet<BdPostgradoEliminado> BdPostgradoEliminado { get; set; }

    public virtual DbSet<BdProfesor> BdProfesor { get; set; }

    public virtual DbSet<BdProfesorEliminados> BdProfesorEliminados { get; set; }

    public virtual DbSet<BdProfesorado> BdProfesorado { get; set; }

    public virtual DbSet<BdProvincia> BdProvincia { get; set; }

    public virtual DbSet<BdPublicaciones> BdPublicaciones { get; set; }

    public virtual DbSet<BdPuntajes> BdPuntajes { get; set; }

    public virtual DbSet<BdSeminarios> BdSeminarios { get; set; }

    public virtual DbSet<BdSexo> BdSexo { get; set; }

    public virtual DbSet<BdTecnico> BdTecnico { get; set; }

    public virtual DbSet<BdTurno> BdTurno { get; set; }

    public virtual DbSet<BdUdelas> BdUdelas { get; set; }

    public virtual DbSet<BdUsuarios> BdUsuarios { get; set; }

    public virtual DbSet<CambioDeCedulasLog> CambioDeCedulasLog { get; set; }

    public virtual DbSet<Capacitaciones> Capacitaciones { get; set; }

    public virtual DbSet<Cursos> Cursos { get; set; }

    public virtual DbSet<CursosHorarios> CursosHorarios { get; set; }

    public virtual DbSet<Docentes> Docentes { get; set; }

    public virtual DbSet<EstudiosBd> EstudiosBd { get; set; }

    public virtual DbSet<Extensiones> Extensiones { get; set; }

    public virtual DbSet<FechaSeparada> FechaSeparada { get; set; }

    public virtual DbSet<Final> Final { get; set; }

    public virtual DbSet<Hoja1> Hoja1 { get; set; }

    public virtual DbSet<Hoja7> Hoja7 { get; set; }

    public virtual DbSet<ListaDocentesActivosTitulos> ListaDocentesActivosTitulos { get; set; }

    public virtual DbSet<ListadoDocentesMestriasDoctorados> ListadoDocentesMestriasDoctorados { get; set; }

    public virtual DbSet<Modalidad> Modalidad { get; set; }

    public virtual DbSet<Perfiles> Perfiles { get; set; }

    public virtual DbSet<Profesores2011> Profesores2011 { get; set; }

    public virtual DbSet<Profesores2011EnBancodatos> Profesores2011EnBancodatos { get; set; }

    public virtual DbSet<Profesores2011EnBdatosConEssup> Profesores2011EnBdatosConEssup { get; set; }

    public virtual DbSet<Profesores2011EnBdatosConLictec> Profesores2011EnBdatosConLictec { get; set; }

    public virtual DbSet<Profesores2011EnBdatosConSeminarios> Profesores2011EnBdatosConSeminarios { get; set; }

    public virtual DbSet<ProfesoresConCheck> ProfesoresConCheck { get; set; }

    public virtual DbSet<ProfesoresConCheckNotInSoloprofesores> ProfesoresConCheckNotInSoloprofesores { get; set; }

    public virtual DbSet<ProfesoresDorisNoEnCapacitacion> ProfesoresDorisNoEnCapacitacion { get; set; }

    public virtual DbSet<ProfesoresEnBdatosConCapacit> ProfesoresEnBdatosConCapacit { get; set; }

    public virtual DbSet<ProfesoresNoClases2011> ProfesoresNoClases2011 { get; set; }

    public virtual DbSet<ProfesoresSinLicenciatura> ProfesoresSinLicenciatura { get; set; }

    public virtual DbSet<Profesorestot2011NoEnBancodatos> Profesorestot2011NoEnBancodatos { get; set; }

    public virtual DbSet<Profesorestotales2011> Profesorestotales2011 { get; set; }

    public virtual DbSet<ProvinciasPorDocentes> ProvinciasPorDocentes { get; set; }

    public virtual DbSet<Prueba1> Prueba1 { get; set; }

    public virtual DbSet<Prueba1Copia> Prueba1Copia { get; set; }

    public virtual DbSet<RServiciosProf> RServiciosProf { get; set; }

    public virtual DbSet<RhGenerales> RhGenerales { get; set; }

    public virtual DbSet<TiposEstudios> TiposEstudios { get; set; }

    public virtual DbSet<Tlmppd> Tlmppd { get; set; }

    public virtual DbSet<TurnosXdocentes> TurnosXdocentes { get; set; }

    public virtual DbSet<VTurnosDocentes> VTurnosDocentes { get; set; }

    public virtual DbSet<Viewlic> Viewlic { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=BANCO_DE_DATOS;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Modern_Spanish_CI_AI");

        modelBuilder.Entity<BdDoctorado>(entity =>
        {
            entity.Property(e => e.CodDoct).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BdEstudiosSem>(entity =>
        {
            entity.Property(e => e.Puntaje).HasDefaultValue(0);
        });

        modelBuilder.Entity<BdEstudiosTotales>(entity =>
        {
            entity.Property(e => e.Fecha).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Habilitado).HasDefaultValue("S");
            entity.Property(e => e.Provincia).HasDefaultValue("PANAMA");
        });

        modelBuilder.Entity<BdExperienciadocente>(entity =>
        {
            entity.Property(e => e.Cod1).IsFixedLength();
        });

        modelBuilder.Entity<BdLicenciatura>(entity =>
        {
            entity.Property(e => e.CodLic).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BdMaestria>(entity =>
        {
            entity.Property(e => e.CodMaest).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BdOtrasejecutorias>(entity =>
        {
            entity.Property(e => e.Cod1).IsFixedLength();
        });

        modelBuilder.Entity<BdOtrosEstudios>(entity =>
        {
            entity.Property(e => e.CodEstudio).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BdPerfeccionamiento>(entity =>
        {
            entity.Property(e => e.Cod1).IsFixedLength();
        });

        modelBuilder.Entity<BdPostgrado>(entity =>
        {
            entity.Property(e => e.CodPostg).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BdProfesor>(entity =>
        {
            entity.Property(e => e.Anio).HasDefaultValue(1900);
            entity.Property(e => e.AnoPeriodoEntregarListas).HasDefaultValue("0_0000_0_00");
            entity.Property(e => e.Cantidad).ValueGeneratedOnAdd();
            entity.Property(e => e.CodDepartamento).HasDefaultValue(0);
            entity.Property(e => e.CodDoctorado).HasDefaultValue(0);
            entity.Property(e => e.CodLicenciatura).HasDefaultValue(0);
            entity.Property(e => e.CodMaestria).HasDefaultValue(0);
            entity.Property(e => e.CodPostgrado).HasDefaultValue(0);
            entity.Property(e => e.CodProfesorado).HasDefaultValue(0);
            entity.Property(e => e.CodTecnico).HasDefaultValue(0);
            entity.Property(e => e.Dia).HasDefaultValue(31);
            entity.Property(e => e.Experiencia).HasDefaultValue("N");
            entity.Property(e => e.Fecha).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaNacimiento).HasDefaultValue("01 de enero 1999");
            entity.Property(e => e.FechaTrabajo).HasDefaultValueSql("(CONVERT([varchar],getdate(),(103)))");
            entity.Property(e => e.Habilitado).HasDefaultValue("N");
            entity.Property(e => e.Idioma1).HasDefaultValue("n");
            entity.Property(e => e.Idioma2).HasDefaultValue("n");
            entity.Property(e => e.LugarNacimiento).HasDefaultValue(" ");
            entity.Property(e => e.Mes).HasDefaultValue(12);
            entity.Property(e => e.Provincia).HasDefaultValue("PANAMA");
            entity.Property(e => e.R).HasDefaultValue("N");
            entity.Property(e => e.Turnon).HasDefaultValueSql("((0))");
            entity.Property(e => e.Turnov).HasDefaultValueSql("((0))");
            entity.Property(e => e.Usuario).HasDefaultValue("ADMIN");
            entity.Property(e => e.Valor1).HasDefaultValue("N");
        });

        modelBuilder.Entity<BdProfesorEliminados>(entity =>
        {
            entity.Property(e => e.Cantidad).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BdProfesorado>(entity =>
        {
            entity.Property(e => e.CodProfesorado).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BdPublicaciones>(entity =>
        {
            entity.Property(e => e.Cod1).IsFixedLength();
        });

        modelBuilder.Entity<BdTecnico>(entity =>
        {
            entity.Property(e => e.CodTec).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BdUdelas>(entity =>
        {
            entity.Property(e => e.Materia).IsFixedLength();
        });

        modelBuilder.Entity<CambioDeCedulasLog>(entity =>
        {
            entity.HasKey(e => e.CambioCedulaId).HasName("PK_CambioDeCedulas");

            entity.Property(e => e.Fecha).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<EstudiosBd>(entity =>
        {
            entity.Property(e => e.Fecha).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<ListaDocentesActivosTitulos>(entity =>
        {
            entity.ToView("ListaDocentesActivosTitulos");
        });

        modelBuilder.Entity<ListadoDocentesMestriasDoctorados>(entity =>
        {
            entity.ToView("Listado_docentes_Mestrias_doctorados");
        });

        modelBuilder.Entity<Modalidad>(entity =>
        {
            entity.Property(e => e.CodMod).ValueGeneratedNever();
        });

        modelBuilder.Entity<Perfiles>(entity =>
        {
            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.TipoDoc).HasComment("1: Foto, 2: Certificado de Colegio, 3: FotoCarnet");
        });

        modelBuilder.Entity<Profesores2011EnBancodatos>(entity =>
        {
            entity.ToView("Profesores2011_en_bancodatos");
        });

        modelBuilder.Entity<Profesores2011EnBdatosConEssup>(entity =>
        {
            entity.ToView("Profesores2011_en_bdatos_con_essup");
        });

        modelBuilder.Entity<Profesores2011EnBdatosConLictec>(entity =>
        {
            entity.ToView("Profesores2011_en_bdatos_con_lictec");
        });

        modelBuilder.Entity<Profesores2011EnBdatosConSeminarios>(entity =>
        {
            entity.ToView("Profesores2011_en_bdatos_con_seminarios");
        });

        modelBuilder.Entity<ProfesoresConCheck>(entity =>
        {
            entity.ToView("Profesores_con_check");
        });

        modelBuilder.Entity<ProfesoresConCheckNotInSoloprofesores>(entity =>
        {
            entity.ToView("Profesores_con_check_not_in_Soloprofesores");
        });

        modelBuilder.Entity<ProfesoresDorisNoEnCapacitacion>(entity =>
        {
            entity.ToView("ProfesoresDoris_no_en_capacitacion");
        });

        modelBuilder.Entity<ProfesoresEnBdatosConCapacit>(entity =>
        {
            entity.ToView("Profesores_en_bdatos_con_capacit");
        });

        modelBuilder.Entity<ProfesoresNoClases2011>(entity =>
        {
            entity.ToView("Profesores_no_clases_2011");
        });

        modelBuilder.Entity<ProfesoresSinLicenciatura>(entity =>
        {
            entity.ToView("Profesores_sin_Licenciatura");
        });

        modelBuilder.Entity<Profesorestot2011NoEnBancodatos>(entity =>
        {
            entity.ToView("Profesorestot2011_no_en_bancodatos");
        });

        modelBuilder.Entity<Prueba1>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Prueba1Copia>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RServiciosProf>(entity =>
        {
            entity.Property(e => e.Cod1).IsFixedLength();
            entity.Property(e => e.Cod2).IsFixedLength();
            entity.Property(e => e.Cod3).IsFixedLength();
        });

        modelBuilder.Entity<TurnosXdocentes>(entity =>
        {
            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<VTurnosDocentes>(entity =>
        {
            entity.ToView("V_TurnosDocentes");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
