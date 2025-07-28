using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Udelascore.Negocio.Models.RecursosHumanos;
using UdelasCore.Negocio.Modelos.RecursosHumanos;
using UdelasCore.Negocio.Modelos.RecursosHumanos.DTOs;

namespace Udelascore.Negocio.Data;

public partial class RecursosHumanosContext : DbContext
{
    public RecursosHumanosContext()
    {
    }

    public RecursosHumanosContext(DbContextOptions<RecursosHumanosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccionDetalles> AccionDetalles { get; set; }

    public virtual DbSet<AccionLogs> AccionLogs { get; set; }

    public virtual DbSet<AccionModificada> AccionModificada { get; set; }

    public virtual DbSet<Accions> Accions { get; set; }

    public virtual DbSet<Accions2> Accions2 { get; set; }

    public virtual DbSet<Acreedores> Acreedores { get; set; }

    public virtual DbSet<Administrativos> Administrativos { get; set; }

    public virtual DbSet<Administrativosaccess> Administrativosaccess { get; set; }

    public virtual DbSet<AspnetApplications> AspnetApplications { get; set; }

    public virtual DbSet<AspnetMembership> AspnetMembership { get; set; }

    public virtual DbSet<AspnetPaths> AspnetPaths { get; set; }

    public virtual DbSet<AspnetPersonalizationAllUsers> AspnetPersonalizationAllUsers { get; set; }

    public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; }

    public virtual DbSet<AspnetProfile> AspnetProfile { get; set; }

    public virtual DbSet<AspnetRoles> AspnetRoles { get; set; }

    public virtual DbSet<AspnetSchemaVersions> AspnetSchemaVersions { get; set; }

    public virtual DbSet<AspnetUsers> AspnetUsers { get; set; }

    public virtual DbSet<AspnetWebEventEvents> AspnetWebEventEvents { get; set; }

    public virtual DbSet<Autoridades> Autoridades { get; set; }

    public virtual DbSet<Cargos> Cargos { get; set; }

    public virtual DbSet<CategoriaProfesors> CategoriaProfesors { get; set; }

    public virtual DbSet<Cheques> Cheques { get; set; }

    public virtual DbSet<ComprobanteDePlanillas> ComprobanteDePlanillas { get; set; }

    public virtual DbSet<CondicionesAdministrativas> CondicionesAdministrativas { get; set; }

    public virtual DbSet<ControlDeVacaciones> ControlDeVacaciones { get; set; }

    public virtual DbSet<CsvCorreos> CsvCorreos { get; set; }

    public virtual DbSet<Cuentas> Cuentas { get; set; }

    public virtual DbSet<CursosSeminarios> CursosSeminarios { get; set; }

    public virtual DbSet<Deducciones> Deducciones { get; set; }

    public virtual DbSet<Departamentos> Departamentos { get; set; }

    public virtual DbSet<DepartamentosAdministrativos> DepartamentosAdministrativos { get; set; }

    public virtual DbSet<Dependientes> Dependientes { get; set; }

    public virtual DbSet<DetalleDeducciones> DetalleDeducciones { get; set; }

    public virtual DbSet<EmpleadosPlanilla> EmpleadosPlanilla { get; set; }

    public virtual DbSet<Entidades> Entidades { get; set; }

    public virtual DbSet<EstadosAdministrativos> EstadosAdministrativos { get; set; }

    public virtual DbSet<EstadosCivil> EstadosCivil { get; set; }

    public virtual DbSet<EstatusAccions> EstatusAccions { get; set; }

    public virtual DbSet<Estructura> Estructura { get; set; }

    public virtual DbSet<Estructura2020> Estructura2020 { get; set; }

    public virtual DbSet<EstructuraContingente> EstructuraContingente { get; set; }

    public virtual DbSet<EstructuraDeCargos> EstructuraDeCargos { get; set; }

    public virtual DbSet<EstructuraUdelas> EstructuraUdelas { get; set; }

    public virtual DbSet<Estudios> Estudios { get; set; }

    public virtual DbSet<Extensiones> Extensiones { get; set; }

    public virtual DbSet<Facultades> Facultades { get; set; }

    public virtual DbSet<Funcionarios> Funcionarios { get; set; }

    public virtual DbSet<Horarios> Horarios { get; set; }

    public virtual DbSet<Instancias> Instancias { get; set; }

    public virtual DbSet<Modalidades> Modalidades { get; set; }

    public virtual DbSet<NivelesEducativos> NivelesEducativos { get; set; }

    public virtual DbSet<Nivels> Nivels { get; set; }

    public virtual DbSet<NumResueltos> NumResueltos { get; set; }

    public virtual DbSet<Pagos> Pagos { get; set; }

    public virtual DbSet<PagosPlanillas> PagosPlanillas { get; set; }

    public virtual DbSet<PagosPorResueltos> PagosPorResueltos { get; set; }

    public virtual DbSet<PartidasPresupuestarias> PartidasPresupuestarias { get; set; }

    public virtual DbSet<Periodos> Periodos { get; set; }

    public virtual DbSet<PlanillaAgo> PlanillaAgo { get; set; }

    public virtual DbSet<PlanillaDic> PlanillaDic { get; set; }

    public virtual DbSet<PlanillaEne> PlanillaEne { get; set; }

    public virtual DbSet<PlanillaJul> PlanillaJul { get; set; }

    public virtual DbSet<PlanillaJun> PlanillaJun { get; set; }

    public virtual DbSet<PlanillaMar> PlanillaMar { get; set; }

    public virtual DbSet<PlanillaNov> PlanillaNov { get; set; }

    public virtual DbSet<PlanillaOct> PlanillaOct { get; set; }

    public virtual DbSet<PlanillaPorMeses> PlanillaPorMeses { get; set; }

    public virtual DbSet<PlanillaSep> PlanillaSep { get; set; }

    public virtual DbSet<PlanillasDocentes> PlanillasDocentes { get; set; }

    public virtual DbSet<Posiciones> Posiciones { get; set; }

    public virtual DbSet<Reportes> Reportes { get; set; }

    public virtual DbSet<Sedes> Sedes { get; set; }

    public virtual DbSet<SemMats> SemMats { get; set; }

    public virtual DbSet<SubNivels> SubNivels { get; set; }

    public virtual DbSet<Sucursales> Sucursales { get; set; }

    public virtual DbSet<TipoAccions> TipoAccions { get; set; }

    public virtual DbSet<TipoDePlanillas> TipoDePlanillas { get; set; }

    public virtual DbSet<TipoDeducciones> TipoDeducciones { get; set; }

    public virtual DbSet<TipoEstados> TipoEstados { get; set; }

    public virtual DbSet<TipoPeriodos> TipoPeriodos { get; set; }

    public virtual DbSet<TiposDePagos> TiposDePagos { get; set; }

    public virtual DbSet<Turnos> Turnos { get; set; }

    public virtual DbSet<UltimaFecha> UltimaFecha { get; set; }

    public virtual DbSet<UsuariosAdmin> UsuariosAdmin { get; set; }

    public virtual DbSet<UsuariosEntidades> UsuariosEntidades { get; set; }

    public virtual DbSet<ViewDoc3A> ViewDoc3A { get; set; }

    public virtual DbSet<ViewListadoResueltosLicFecha> ViewListadoResueltosLicFecha { get; set; }

    public virtual DbSet<ViewPosicionesXDocentesAnual> ViewPosicionesXDocentesAnual { get; set; }

    public virtual DbSet<ViewTurnosDocentes> ViewTurnosDocentes { get; set; }

    public virtual DbSet<ViewUdeEmail> ViewUdeEmail { get; set; }

    public virtual DbSet<VmAccion4> VmAccion4 { get; set; }

    public virtual DbSet<VwAspnetApplications> VwAspnetApplications { get; set; }

    public virtual DbSet<VwAspnetMembershipUsers> VwAspnetMembershipUsers { get; set; }

    public virtual DbSet<VwAspnetProfiles> VwAspnetProfiles { get; set; }

    public virtual DbSet<VwAspnetRoles> VwAspnetRoles { get; set; }

    public virtual DbSet<VwAspnetUsers> VwAspnetUsers { get; set; }

    public virtual DbSet<VwAspnetUsersInRoles> VwAspnetUsersInRoles { get; set; }

    public virtual DbSet<VwAspnetWebPartStatePaths> VwAspnetWebPartStatePaths { get; set; }

    public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShared { get; set; }

    public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUser { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }
    public virtual DbSet<Terna> Ternas { get; set; }
    public virtual DbSet<TernaDetalle> TernaDetalles { get; set; }

    public DbSet<ObtainTernasDTO> TernasDTO { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=RECURSOS_HUMANOS;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<AccionLogs>(entity =>
        {
            entity.Property(e => e.Guid).ValueGeneratedNever();
        });

        modelBuilder.Entity<AccionModificada>(entity =>
        {
            entity.ToView("accion_modificada");
        });

        modelBuilder.Entity<Accions>(entity =>
        {
            entity.HasKey(e => e.IdAccion).HasName("PK_Accions_1");

            entity.Property(e => e.AccionAfectada).HasDefaultValue(-1);
            entity.Property(e => e.EstatusAccion).HasDefaultValue(1);
            entity.Property(e => e.EstatusFirmado).HasDefaultValue(0);
            entity.Property(e => e.EstatusImprimir).HasDefaultValue(0);
            entity.Property(e => e.FechaEnviado).HasDefaultValue(new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            entity.Property(e => e.FechaSistema).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Mensual).HasDefaultValue(0m);
            entity.Property(e => e.Salario).HasDefaultValue(0m);
            entity.Property(e => e.Seguro).HasDefaultValueSql("(((99)-(9))-(999))");
            entity.Property(e => e.Total).HasDefaultValue(0m);
            entity.Property(e => e.Vacaciones).HasDefaultValue(0m);
        });

        modelBuilder.Entity<Administrativos>(entity =>
        {
            entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<AspnetApplications>(entity =>
        {
            entity.HasKey(e => e.ApplicationId)
                .HasName("PK__aspnet_A__C93A4C98589C25F3")
                .IsClustered(false);

            entity.HasIndex(e => e.LoweredApplicationName, "aspnet_Applications_Index").IsClustered();

            entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<AspnetMembership>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("PK__aspnet_M__1788CC4D7720AD13")
                .IsClustered(false);

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail }, "aspnet_Membership_index").IsClustered();

            entity.Property(e => e.UserId).ValueGeneratedNever();

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetMembership)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Me__Appli__7908F585");

            entity.HasOne(d => d.User).WithOne(p => p.AspnetMembership)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Me__UserI__79FD19BE");
        });

        modelBuilder.Entity<AspnetPaths>(entity =>
        {
            entity.HasKey(e => e.PathId)
                .HasName("PK__aspnet_P__CD67DC5830592A6F")
                .IsClustered(false);

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath }, "aspnet_Paths_index")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetPaths)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Pa__Appli__324172E1");
        });

        modelBuilder.Entity<AspnetPersonalizationAllUsers>(entity =>
        {
            entity.HasKey(e => e.PathId).HasName("PK__aspnet_P__CD67DC5937FA4C37");

            entity.Property(e => e.PathId).ValueGeneratedNever();

            entity.HasOne(d => d.Path).WithOne(p => p.AspnetPersonalizationAllUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Pe__PathI__39E294A9");
        });

        modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK__aspnet_P__3214EC063CBF0154")
                .IsClustered(false);

            entity.HasIndex(e => new { e.PathId, e.UserId }, "aspnet_PersonalizationPerUser_index1")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Path).WithMany(p => p.AspnetPersonalizationPerUser).HasConstraintName("FK__aspnet_Pe__PathI__3F9B6DFF");

            entity.HasOne(d => d.User).WithMany(p => p.AspnetPersonalizationPerUser).HasConstraintName("FK__aspnet_Pe__UserI__408F9238");
        });

        modelBuilder.Entity<AspnetProfile>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__aspnet_P__1788CC4C0E04126B");

            entity.Property(e => e.UserId).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithOne(p => p.AspnetProfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Pr__UserI__0FEC5ADD");
        });

        modelBuilder.Entity<AspnetRoles>(entity =>
        {
            entity.HasKey(e => e.RoleId)
                .HasName("PK__aspnet_R__8AFACE1B1975C517")
                .IsClustered(false);

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName }, "aspnet_Roles_index1")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Ro__Appli__1B5E0D89");
        });

        modelBuilder.Entity<AspnetSchemaVersions>(entity =>
        {
            entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion }).HasName("PK__aspnet_S__5A1E6BC16ABAD62E");
        });

        modelBuilder.Entity<AspnetUsers>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("PK__aspnet_U__1788CC4D6319B466")
                .IsClustered(false);

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName }, "aspnet_Users_Index")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.MobileAlias).HasDefaultValueSql("(NULL)");

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Us__Appli__6501FCD8");

            entity.HasMany(d => d.Role).WithMany(p => p.User)
                .UsingEntity<Dictionary<string, object>>(
                    "AspnetUsersInRoles",
                    r => r.HasOne<AspnetRoles>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__aspnet_Us__RoleI__220B0B18"),
                    l => l.HasOne<AspnetUsers>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__aspnet_Us__UserI__2116E6DF"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK__aspnet_U__AF2760AD1F2E9E6D");
                        j.ToTable("aspnet_UsersInRoles");
                        j.HasIndex(new[] { "RoleId" }, "aspnet_UsersInRoles_index");
                    });
        });

        modelBuilder.Entity<AspnetWebEventEvents>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__aspnet_W__7944C81050C5FA01");

            entity.Property(e => e.EventId).IsFixedLength();
        });

        modelBuilder.Entity<Autoridades>(entity =>
        {
            entity.Property(e => e.CodAutoridad)
                .HasDefaultValue(2)
                .HasComment("Codigo: 1-Rector; 2-Director de Recursos Humanos");
            entity.Property(e => e.Firma).HasComment("Valor binario para la firma digital");
        });

        modelBuilder.Entity<Cargos>(entity =>
        {
            entity.Property(e => e.DescripcionCargos).HasDefaultValue("N");
        });

        modelBuilder.Entity<CategoriaProfesors>(entity =>
        {
            entity.HasKey(e => e.CodCategoriaProfesor).HasName("PK_Categoria_Profesor");

            entity.Property(e => e.Abreviatura)
                .HasDefaultValue("BD")
                .IsFixedLength();
        });

        modelBuilder.Entity<Cheques>(entity =>
        {
            entity.Property(e => e.CodEmpleado).HasDefaultValueSql("((0))");
            entity.Property(e => e.Fecha).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaString).HasDefaultValueSql("(((1)/(1))/(1999))");
            entity.Property(e => e.FichaSs).HasDefaultValueSql("((9999999999.))");
            entity.Property(e => e.Mes).HasDefaultValue("N");
            entity.Property(e => e.Quincena).HasDefaultValue("PRIMERA");
        });

        modelBuilder.Entity<ComprobanteDePlanillas>(entity =>
        {
            entity.Property(e => e.NumDoc).ValueGeneratedNever();
            entity.Property(e => e.Anio).HasDefaultValue("2020");
            entity.Property(e => e.ClaveA).HasDefaultValue("");
            entity.Property(e => e.ClaveB).HasDefaultValue("");
            entity.Property(e => e.ClaveC).HasDefaultValue("");
            entity.Property(e => e.ClaveD).HasDefaultValue("");
            entity.Property(e => e.ClaveE).HasDefaultValue("");
            entity.Property(e => e.ClaveF).HasDefaultValue("");
            entity.Property(e => e.ClaveG).HasDefaultValue("");
            entity.Property(e => e.ClaveH).HasDefaultValue("");
            entity.Property(e => e.ClaveI).HasDefaultValue("");
            entity.Property(e => e.ClaveJ).HasDefaultValue("");
            entity.Property(e => e.CodEntidad).HasDefaultValue("193");
            entity.Property(e => e.CodPago).HasDefaultValue(1);
            entity.Property(e => e.CodPlanilla).HasDefaultValue("010");
            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.GuidPago).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IdComprobante).ValueGeneratedOnAdd();
            entity.Property(e => e.Mes).HasDefaultValue("02");
            entity.Property(e => e.TipoPago).HasDefaultValue(2);
        });

        modelBuilder.Entity<ControlDeVacaciones>(entity =>
        {
            entity.Property(e => e.TipoV)
                .HasDefaultValue(1)
                .HasComment("1: Por derecho; 2: Tomadas");
        });

        modelBuilder.Entity<CursosSeminarios>(entity =>
        {
            entity.Property(e => e.Guid).HasComment("Guid del administrativo");
        });

        modelBuilder.Entity<Deducciones>(entity =>
        {
            entity.Property(e => e.Categoria).HasDefaultValue(2);
        });

        modelBuilder.Entity<Departamentos>(entity =>
        {
            entity.Property(e => e.CodDepartamento).ValueGeneratedNever();
            entity.Property(e => e.Descripcion).HasDefaultValue("N");
            entity.Property(e => e.Nombre).HasDefaultValue("N");
        });

        modelBuilder.Entity<DepartamentosAdministrativos>(entity =>
        {
            entity.Property(e => e.Edificio).HasDefaultValue("------");
        });

        modelBuilder.Entity<EmpleadosPlanilla>(entity =>
        {
            entity.Property(e => e.CodSede).HasDefaultValue(8);
            entity.Property(e => e.Email).HasDefaultValue("SinCorreo@udelas.com");
            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.GuidEmpleado).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Sexo).HasDefaultValue("");
            entity.Property(e => e.Token).HasDefaultValue("");
        });

        modelBuilder.Entity<EstadosAdministrativos>(entity =>
        {
            entity.HasKey(e => e.CodEstado).HasName("PK_EstadoAdministrativo");
        });

        modelBuilder.Entity<Estructura>(entity =>
        {
            entity.Property(e => e.CodArea).HasDefaultValueSql("((1))");
            entity.Property(e => e.CodEntidad).HasDefaultValueSql("((93))");
            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(CONVERT([nvarchar](10),getdate(),(103)))");
            entity.Property(e => e.Patrono).HasDefaultValueSql("((8781100441.))");
        });

        modelBuilder.Entity<Estructura2020>(entity =>
        {
            entity.Property(e => e.CodCargo).HasDefaultValue("");
        });

        modelBuilder.Entity<Estudios>(entity =>
        {
            entity.Property(e => e.Anio).HasComment("Año en que obtubo el titulo");
            entity.Property(e => e.Guid).HasComment("Guid del Administrativo");
        });

        modelBuilder.Entity<Extensiones>(entity =>
        {
            entity.Property(e => e.NombreExtension).HasDefaultValue("N");
        });

        modelBuilder.Entity<Horarios>(entity =>
        {
            entity.Property(e => e.AmpmF).HasDefaultValue("PM");
            entity.Property(e => e.AmpmI).HasDefaultValue("AM");
        });

        modelBuilder.Entity<Instancias>(entity =>
        {
            entity.Property(e => e.CodFacultad).HasDefaultValue(1);
            entity.Property(e => e.CodSede).HasDefaultValue(1);
        });

        modelBuilder.Entity<PagosPorResueltos>(entity =>
        {
            entity.Property(e => e.AnioPlanilla).HasDefaultValue(2015);
            entity.Property(e => e.Anulado)
                .HasDefaultValue("N")
                .HasComment("N: No Anulado; S: Si Anulado");
            entity.Property(e => e.Comprobante)
                .HasDefaultValue("00000")
                .HasComment("Nro. de Documento con el que se pagó el resuelto.");
            entity.Property(e => e.FechaPago).HasDefaultValue(new DateOnly(1990, 1, 1));
            entity.Property(e => e.FechaSistema).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Observacion).HasDefaultValue("N");
            entity.Property(e => e.Planilla)
                .HasDefaultValue("000000")
                .HasComment("Numero de planila, ingresodo por el usuario");
            entity.Property(e => e.TipoResuelto).HasComment("0: Indefinido; 1:Docente; 2:Administrativo");
            entity.Property(e => e.Usuario).HasDefaultValue("Sistemas");
        });

        modelBuilder.Entity<PartidasPresupuestarias>(entity =>
        {
            entity.Property(e => e.Estatus).HasDefaultValue(1);
        });

        modelBuilder.Entity<PlanillaPorMeses>(entity =>
        {
            entity.Property(e => e.Codisr).HasDefaultValue(" ");
            entity.Property(e => e.Depend).HasComment("Dependientes");
            entity.Property(e => e.Dpto).HasDefaultValue("00");
            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<PlanillasDocentes>(entity =>
        {
            entity.Property(e => e.AnioPlanilla).HasDefaultValue(2017);
            entity.Property(e => e.Descripcion).HasDefaultValue("01ENE2017");
        });

        modelBuilder.Entity<Reportes>(entity =>
        {
            entity.Property(e => e.CodSede).HasDefaultValue(8);
        });

        modelBuilder.Entity<SemMats>(entity =>
        {
            entity.HasKey(e => e.SemMatId).HasName("PK_M_Sem_mat");
        });

        modelBuilder.Entity<TipoAccions>(entity =>
        {
            entity.Property(e => e.GradoId).HasDefaultValue(-1);
            entity.Property(e => e.HorasCurso).IsFixedLength();
            entity.Property(e => e.Mensual).IsFixedLength();
        });

        modelBuilder.Entity<TipoDePlanillas>(entity =>
        {
            entity.Property(e => e.Codigo).HasDefaultValue("");
            entity.Property(e => e.Descripcion).HasDefaultValue("");
        });

        modelBuilder.Entity<TipoDeducciones>(entity =>
        {
            entity.HasKey(e => e.TipoDeduccionId).HasName("PK_TIPO_DESCUENTOS_1");

            entity.Property(e => e.Direccion).HasDefaultValue("");
            entity.Property(e => e.Telefonos).HasDefaultValue("");
        });

        modelBuilder.Entity<TipoEstados>(entity =>
        {
            entity.Property(e => e.CodTipo).ValueGeneratedNever();
        });

        modelBuilder.Entity<TipoPeriodos>(entity =>
        {
            entity.HasKey(e => e.TipoPeriodoId).HasName("PK_Tipo_Periodos_1");
        });

        modelBuilder.Entity<UltimaFecha>(entity =>
        {
            entity.ToView("ultima_fecha");
        });

        modelBuilder.Entity<UsuariosAdmin>(entity =>
        {
            entity.HasKey(e => e.UsuariosId).HasName("PK_Usuarios");

            entity.Property(e => e.CodExtension).HasDefaultValue(8);
            entity.Property(e => e.CodFacultad).HasComment("se utiliza -1 para los operadores");
        });

        modelBuilder.Entity<ViewDoc3A>(entity =>
        {
            entity.ToView("View_Doc3A");
        });

        modelBuilder.Entity<ViewListadoResueltosLicFecha>(entity =>
        {
            entity.ToView("View_Listado_Resueltos_Lic_Fecha");
        });

        modelBuilder.Entity<ViewPosicionesXDocentesAnual>(entity =>
        {
            entity.ToView("View_Posiciones_X_Docentes_Anual");

            entity.Property(e => e.Sexo).UseCollation("Modern_Spanish_CI_AI");
        });

        modelBuilder.Entity<ViewTurnosDocentes>(entity =>
        {
            entity.ToView("View_TurnosDocentes");
        });

        modelBuilder.Entity<ViewUdeEmail>(entity =>
        {
            entity.ToView("View_Ude_Email");
        });

        modelBuilder.Entity<VmAccion4>(entity =>
        {
            entity.ToView("VM_Accion_4");

            entity.Property(e => e.IdAccion).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VwAspnetApplications>(entity =>
        {
            entity.ToView("vw_aspnet_Applications");
        });

        modelBuilder.Entity<VwAspnetMembershipUsers>(entity =>
        {
            entity.ToView("vw_aspnet_MembershipUsers");
        });

        modelBuilder.Entity<VwAspnetProfiles>(entity =>
        {
            entity.ToView("vw_aspnet_Profiles");
        });

        modelBuilder.Entity<VwAspnetRoles>(entity =>
        {
            entity.ToView("vw_aspnet_Roles");
        });

        modelBuilder.Entity<VwAspnetUsers>(entity =>
        {
            entity.ToView("vw_aspnet_Users");
        });

        modelBuilder.Entity<VwAspnetUsersInRoles>(entity =>
        {
            entity.ToView("vw_aspnet_UsersInRoles");
        });

        modelBuilder.Entity<VwAspnetWebPartStatePaths>(entity =>
        {
            entity.ToView("vw_aspnet_WebPartState_Paths");
        });

        modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
        {
            entity.ToView("vw_aspnet_WebPartState_Shared");
        });

        modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
        {
            entity.ToView("vw_aspnet_WebPartState_User");
        });

        modelBuilder.Entity<ObtainTernasDTO>()
       .HasNoKey()
       .ToView(null); // Esto evita que EF Core intente mapear a una tabla o vista real

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
