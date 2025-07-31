using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UdelasCore.Negocio.Modelos.HorariosDocencia;

namespace UdelasCore.Negocio.Data;

public partial class HorariosDocenciaContext : DbContext
{
    public HorariosDocenciaContext()
    {
    }

    public HorariosDocenciaContext(DbContextOptions<HorariosDocenciaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActivacionHorarios> ActivacionHorarios { get; set; }

    public virtual DbSet<AcuerdoMateria> AcuerdoMateria { get; set; }

    public virtual DbSet<AcuerdosCarreras> AcuerdosCarreras { get; set; }

    public virtual DbSet<AuditoriaUsuarioHorario> AuditoriaUsuarioHorario { get; set; }

    public virtual DbSet<BdProfesor> BdProfesor { get; set; }

    public virtual DbSet<BitacoraPr> BitacoraPr { get; set; }

    public virtual DbSet<CambiosHorariosLog> CambiosHorariosLog { get; set; }

    public virtual DbSet<Carreras> Carreras { get; set; }

    public virtual DbSet<CarrerasTecnicos> CarrerasTecnicos { get; set; }

    public virtual DbSet<CategoriaProfesores> CategoriaProfesores { get; set; }

    public virtual DbSet<ClimLibMCursosTemp1> ClimLibMCursosTemp1 { get; set; }

    public virtual DbSet<ClimLibMCursosTemp2> ClimLibMCursosTemp2 { get; set; }

    public virtual DbSet<ClimLibMGruposTemp1> ClimLibMGruposTemp1 { get; set; }

    public virtual DbSet<ClimLibMGruposTemp2> ClimLibMGruposTemp2 { get; set; }

    public virtual DbSet<CodigosCursos> CodigosCursos { get; set; }

    public virtual DbSet<CondicionSalones> CondicionSalones { get; set; }

    public virtual DbSet<Constantes> Constantes { get; set; }

    public virtual DbSet<Constantes2> Constantes2 { get; set; }

    public virtual DbSet<Constantes3> Constantes3 { get; set; }

    public virtual DbSet<Csvdocentes> Csvdocentes { get; set; }

    public virtual DbSet<CursoOficialCruceMatriculadaPanama> CursoOficialCruceMatriculadaPanama { get; set; }

    public virtual DbSet<Cursos> Cursos { get; set; }

    public virtual DbSet<CursosCopia> CursosCopia { get; set; }

    public virtual DbSet<CursosCopia2> CursosCopia2 { get; set; }

    public virtual DbSet<CursosOficialesXPeriodos> CursosOficialesXPeriodos { get; set; }

    public virtual DbSet<CursosXGrupo> CursosXGrupo { get; set; }

    public virtual DbSet<Departamentos> Departamentos { get; set; }

    public virtual DbSet<DescripcionPeriodos> DescripcionPeriodos { get; set; }

    public virtual DbSet<Dias> Dias { get; set; }

    public virtual DbSet<DocenteConHor3Anios> DocenteConHor3Anios { get; set; }

    public virtual DbSet<DocenteCsv> DocenteCsv { get; set; }

    public virtual DbSet<Docentes2016> Docentes2016 { get; set; }

    public virtual DbSet<Docentes2017> Docentes2017 { get; set; }

    public virtual DbSet<Docentes2018> Docentes2018 { get; set; }

    public virtual DbSet<DocentesNuevos20182> DocentesNuevos20182 { get; set; }

    public virtual DbSet<DocentesXCuentas> DocentesXCuentas { get; set; }

    public virtual DbSet<Edificios> Edificios { get; set; }

    public virtual DbSet<Emailcorregir> Emailcorregir { get; set; }

    public virtual DbSet<Entidades> Entidades { get; set; }

    public virtual DbSet<Escuelas> Escuelas { get; set; }

    public virtual DbSet<Extensiones> Extensiones { get; set; }

    public virtual DbSet<Facultades> Facultades { get; set; }

    public virtual DbSet<GrupoCursoLibreta> GrupoCursoLibreta { get; set; }

    public virtual DbSet<Grupos> Grupos { get; set; }

    public virtual DbSet<GruposChoques> GruposChoques { get; set; }

    public virtual DbSet<GruposCopia> GruposCopia { get; set; }

    public virtual DbSet<GruposEspeciales> GruposEspeciales { get; set; }

    public virtual DbSet<HistoricoCursos> HistoricoCursos { get; set; }

    public virtual DbSet<HistoricoGrupos> HistoricoGrupos { get; set; }

    public virtual DbSet<Hoja1> Hoja1 { get; set; }

    public virtual DbSet<HorarioTipoPago> HorarioTipoPago { get; set; }

    public virtual DbSet<Horarios> Horarios { get; set; }

    public virtual DbSet<HorariosCopia> HorariosCopia { get; set; }

    public virtual DbSet<HorariosCopia1> HorariosCopia1 { get; set; }

    public virtual DbSet<HorariosPlantilla> HorariosPlantilla { get; set; }

    public virtual DbSet<HorariosPlantillaDetalles> HorariosPlantillaDetalles { get; set; }

    public virtual DbSet<ListaCursoOficialesPma> ListaCursoOficialesPma { get; set; }

    public virtual DbSet<ListaCursosColegiadasPma> ListaCursosColegiadasPma { get; set; }

    public virtual DbSet<ListadoAnioMayorDocentes> ListadoAnioMayorDocentes { get; set; }

    public virtual DbSet<LsAmAm> LsAmAm { get; set; }

    public virtual DbSet<LsAmAmCarga> LsAmAmCarga { get; set; }

    public virtual DbSet<LsAmPm> LsAmPm { get; set; }

    public virtual DbSet<LsAmPmCarga> LsAmPmCarga { get; set; }

    public virtual DbSet<LsDocentesPorCarga> LsDocentesPorCarga { get; set; }

    public virtual DbSet<LsDocentesPorPago> LsDocentesPorPago { get; set; }

    public virtual DbSet<LsPmPmMayora4> LsPmPmMayora4 { get; set; }

    public virtual DbSet<LsPmPmMayora4Carga> LsPmPmMayora4Carga { get; set; }

    public virtual DbSet<LsPmPmMenora4> LsPmPmMenora4 { get; set; }

    public virtual DbSet<LsPmPmMenora4Carga> LsPmPmMenora4Carga { get; set; }

    public virtual DbSet<MCostosFijosGruposTemp> MCostosFijosGruposTemp { get; set; }

    public virtual DbSet<MCursos> MCursos { get; set; }

    public virtual DbSet<MGrupos> MGrupos { get; set; }

    public virtual DbSet<MatPoCarreraFiltro> MatPoCarreraFiltro { get; set; }

    public virtual DbSet<Matcar> Matcar { get; set; }

    public virtual DbSet<MateriasParaVerificarTecnico> MateriasParaVerificarTecnico { get; set; }

    public virtual DbSet<MateriasPorCarreras> MateriasPorCarreras { get; set; }

    public virtual DbSet<MateriasPracticas> MateriasPracticas { get; set; }

    public virtual DbSet<MateriasPreRequisitos> MateriasPreRequisitos { get; set; }

    public virtual DbSet<NivelAcceso> NivelAcceso { get; set; }

    public virtual DbSet<NivelDiplomados> NivelDiplomados { get; set; }

    public virtual DbSet<Notanoentregada> Notanoentregada { get; set; }

    public virtual DbSet<NotasCarreras> NotasCarreras { get; set; }

    public virtual DbSet<NotasMateria> NotasMateria { get; set; }

    public virtual DbSet<Numeros> Numeros { get; set; }

    public virtual DbSet<ObservacionesMateria> ObservacionesMateria { get; set; }

    public virtual DbSet<OpcionesDePagos> OpcionesDePagos { get; set; }

    public virtual DbSet<Parte1Reportesubhumanos> Parte1Reportesubhumanos { get; set; }

    public virtual DbSet<Parte2Reportesubhumano> Parte2Reportesubhumano { get; set; }

    public virtual DbSet<PeriodoPorDiplomados> PeriodoPorDiplomados { get; set; }

    public virtual DbSet<Periodos> Periodos { get; set; }

    public virtual DbSet<PeriodosAcademicos> PeriodosAcademicos { get; set; }

    public virtual DbSet<PeriodosVigentes> PeriodosVigentes { get; set; }

    public virtual DbSet<ProfesoresEvaluacionCursos> ProfesoresEvaluacionCursos { get; set; }

    public virtual DbSet<Resultados> Resultados { get; set; }

    public virtual DbSet<Salones> Salones { get; set; }

    public virtual DbSet<SalonesChoque> SalonesChoque { get; set; }

    public virtual DbSet<SalonesChoques> SalonesChoques { get; set; }

    public virtual DbSet<SemMat> SemMat { get; set; }

    public virtual DbSet<Sesiones> Sesiones { get; set; }

    public virtual DbSet<SubTiposGrados> SubTiposGrados { get; set; }

    public virtual DbSet<T3Horarios> T3Horarios { get; set; }

    public virtual DbSet<TablaModel> TablaModel { get; set; }

    public virtual DbSet<TempD1> TempD1 { get; set; }

    public virtual DbSet<TempD2> TempD2 { get; set; }

    public virtual DbSet<TempDoc3Anios> TempDoc3Anios { get; set; }

    public virtual DbSet<TempDocentesPendRevisar> TempDocentesPendRevisar { get; set; }

    public virtual DbSet<TempoDoceSs3a1> TempoDoceSs3a1 { get; set; }

    public virtual DbSet<TemporalDoceSs3a> TemporalDoceSs3a { get; set; }

    public virtual DbSet<TipoDocente> TipoDocente { get; set; }

    public virtual DbSet<TipoHoraclase> TipoHoraclase { get; set; }

    public virtual DbSet<TipoPago> TipoPago { get; set; }

    public virtual DbSet<TipoPagos> TipoPagos { get; set; }

    public virtual DbSet<TipoPeriodos> TipoPeriodos { get; set; }

    public virtual DbSet<TiposGrados> TiposGrados { get; set; }

    public virtual DbSet<TokenDocentes> TokenDocentes { get; set; }

    public virtual DbSet<Turnos> Turnos { get; set; }

    public virtual DbSet<Usuarios> Usuarios { get; set; }

    public virtual DbSet<VerificarGruposCantEstPma> VerificarGruposCantEstPma { get; set; }

    public virtual DbSet<View1> View1 { get; set; }

    public virtual DbSet<View2> View2 { get; set; }

    public virtual DbSet<View3> View3 { get; set; }

    public virtual DbSet<View4ls> View4ls { get; set; }

    public virtual DbSet<ViewCantidadHorasCursos> ViewCantidadHorasCursos { get; set; }

    public virtual DbSet<ViewConPostgrado> ViewConPostgrado { get; set; }

    public virtual DbSet<ViewCuentasCreadasXcortes> ViewCuentasCreadasXcortes { get; set; }

    public virtual DbSet<ViewCursosnogendpc2023> ViewCursosnogendpc2023 { get; set; }

    public virtual DbSet<ViewDoc3A> ViewDoc3A { get; set; }

    public virtual DbSet<ViewDoc3Aa> ViewDoc3Aa { get; set; }

    public virtual DbSet<ViewDocent20222023> ViewDocent20222023 { get; set; }

    public virtual DbSet<ViewDocent2024> ViewDocent2024 { get; set; }

    public virtual DbSet<ViewDocente2023> ViewDocente2023 { get; set; }

    public virtual DbSet<ViewDocenteVotantesUlt3Anios> ViewDocenteVotantesUlt3Anios { get; set; }

    public virtual DbSet<ViewDocentesPrelVoto24> ViewDocentesPrelVoto24 { get; set; }

    public virtual DbSet<ViewDocentesXCuentas> ViewDocentesXCuentas { get; set; }

    public virtual DbSet<ViewHorariosCurso> ViewHorariosCurso { get; set; }

    public virtual DbSet<ViewIltec1> ViewIltec1 { get; set; }

    public virtual DbSet<ViewIltec2> ViewIltec2 { get; set; }

    public virtual DbSet<ViewMateriasXcarreraSemestre> ViewMateriasXcarreraSemestre { get; set; }

    public virtual DbSet<ViewNumCar> ViewNumCar { get; set; }

    public virtual DbSet<ViewPorAutorizarConHorariosTurnos> ViewPorAutorizarConHorariosTurnos { get; set; }

    public virtual DbSet<ViewPreliFinalDoce2024> ViewPreliFinalDoce2024 { get; set; }

    public virtual DbSet<ViewSinPostgrado> ViewSinPostgrado { get; set; }

    public virtual DbSet<ViewUlt3AnioV2> ViewUlt3AnioV2 { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database='HORARIOS DOCENCIA';Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Modern_Spanish_CI_AI");

        modelBuilder.Entity<ActivacionHorarios>(entity =>
        {
            entity.Property(e => e.Activado).HasDefaultValue(-1);
            entity.Property(e => e.Anio).HasDefaultValue(2000);
            entity.Property(e => e.Extension).HasDefaultValue(1);
            entity.Property(e => e.Periodo).HasDefaultValue(-1);
        });

        modelBuilder.Entity<AcuerdoMateria>(entity =>
        {
            entity.Property(e => e.Fecha).HasDefaultValue("N");
            entity.Property(e => e.Nomenclatura)
                .HasDefaultValue("N")
                .HasComment("identificacion del acuerdo");
            entity.Property(e => e.Observacion).HasDefaultValue("N");
            entity.Property(e => e.PlanCarrera).HasDefaultValue("A");
            entity.Property(e => e.Titulo)
                .HasDefaultValue("N")
                .HasComment("Hay veces que ademas de la nomenclatura o identif de plan, se adjunta un titulo que lo describe");
        });

        modelBuilder.Entity<AcuerdosCarreras>(entity =>
        {
            entity.Property(e => e.Acuerdo).HasDefaultValue("N");
            entity.Property(e => e.NomPlan).HasDefaultValue("N");
        });

        modelBuilder.Entity<AuditoriaUsuarioHorario>(entity =>
        {
            entity.ToView("AuditoriaUsuarioHorario");

            entity.Property(e => e.Email).UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.RoleName).UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<BitacoraPr>(entity =>
        {
            entity.Property(e => e.Estatus).HasComment("1. borró PR, 2. agregró PR");
        });

        modelBuilder.Entity<Carreras>(entity =>
        {
            entity.Property(e => e.CodCarrera).HasDefaultValue(-1);
            entity.Property(e => e.AbrevCarrera).HasDefaultValue("n");
            entity.Property(e => e.Activa).HasDefaultValue(1);
            entity.Property(e => e.Acuerdo).HasDefaultValue("N");
            entity.Property(e => e.Carrera).HasDefaultValue("n");
            entity.Property(e => e.CodEscuela).HasDefaultValue(-1);
            entity.Property(e => e.CodEscuela2).HasDefaultValue(0);
            entity.Property(e => e.CodExtension).HasDefaultValue(-1);
            entity.Property(e => e.CodFacultad).HasDefaultValue(-1);
            entity.Property(e => e.CodFacultad2).HasDefaultValue(0);
            entity.Property(e => e.CodTecnico).HasDefaultValue(0);
            entity.Property(e => e.Estatus).HasComment("0: no promocionada 1: promocionada");
            entity.Property(e => e.Nivel).HasDefaultValue(1);
            entity.Property(e => e.Observacion).HasDefaultValue("N");
            entity.Property(e => e.PlanCarrera).HasDefaultValue("A");
            entity.Property(e => e.Subgrado).HasDefaultValue(-1);
            entity.Property(e => e.TipoPeriodo).HasDefaultValue(6);
        });

        modelBuilder.Entity<CategoriaProfesores>(entity =>
        {
            entity.HasKey(e => e.CodCategoriaProfesor).HasName("PK_Categoria_Profesor");

            entity.Property(e => e.Abreviatura)
                .HasDefaultValue("BD")
                .IsFixedLength();
            entity.Property(e => e.IdTipoPago).HasDefaultValue(-1);
        });

        modelBuilder.Entity<ClimLibMCursosTemp1>(entity =>
        {
            entity.Property(e => e.MCursosId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ClimLibMCursosTemp2>(entity =>
        {
            entity.Property(e => e.Fechaasigdoc).HasDefaultValueSql("(((2000)-(1))-(1))");
            entity.Property(e => e.Fechaasigpos).HasDefaultValueSql("(((2000)-(1))-(1))");
            entity.Property(e => e.Guidusuarioasigdoc).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.Guidusuarioasigpos).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.MCursosId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ClimLibMGruposTemp1>(entity =>
        {
            entity.Property(e => e.MGruposId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ClimLibMGruposTemp2>(entity =>
        {
            entity.Property(e => e.MGruposId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CodigosCursos>(entity =>
        {
            entity.Property(e => e.CodigoCurso).HasDefaultValue(-1);
            entity.Property(e => e.IdCurso).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CondicionSalones>(entity =>
        {
            entity.Property(e => e.CodCondicion).HasDefaultValue(-1);
            entity.Property(e => e.Descripcion).HasDefaultValue("n");
            entity.Property(e => e.Nombre).HasDefaultValue("n");
        });

        modelBuilder.Entity<Constantes>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasDefaultValue("Ninguno")
                .HasComment("");
            entity.Property(e => e.Valor).HasDefaultValue("Ninguno");
            entity.Property(e => e.Valor2).HasDefaultValue("Ninguno");
            entity.Property(e => e.Valor3).HasDefaultValue(0);
            entity.Property(e => e.Valor4).HasDefaultValue(0.0m);
        });

        modelBuilder.Entity<Constantes2>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasDefaultValue("Ninguno")
                .HasComment("");
            entity.Property(e => e.Valor).HasDefaultValue("Ninguno");
            entity.Property(e => e.Valor2).HasDefaultValue("Ninguno");
            entity.Property(e => e.Valor3).HasDefaultValue(0);
            entity.Property(e => e.Valor4).HasDefaultValue(0.0m);
        });

        modelBuilder.Entity<Constantes3>(entity =>
        {
            entity.Property(e => e.Actual).HasDefaultValue("N");
            entity.Property(e => e.IdTabla).ValueGeneratedOnAdd();
            entity.Property(e => e.Version).IsFixedLength();
        });

        modelBuilder.Entity<Csvdocentes>(entity =>
        {
            entity.ToView("CSVDocentes");
        });

        modelBuilder.Entity<CursoOficialCruceMatriculadaPanama>(entity =>
        {
            entity.ToView("curso_oficial_cruce_matriculada_panama");
        });

        modelBuilder.Entity<Cursos>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("tg_Update_Horarios");
                    tb.HasTrigger("trg_ActulizaDocenteCred");
                });

            entity.Property(e => e.AnioVigente).HasDefaultValue(2000);
            entity.Property(e => e.Ano).HasDefaultValue(2007);
            entity.Property(e => e.Apellido).HasDefaultValue("NOMBRAR");
            entity.Property(e => e.CedProfesor).HasDefaultValue("n");
            entity.Property(e => e.Cod1)
                .HasDefaultValue(-1)
                .HasComment("La cantidad de semanas que realmente se va impartir este curso,si es -1, entonces se usan las semanas del periodo y se obvia la cantidad de este campo.");
            entity.Property(e => e.Cod2).HasDefaultValueSql("((-1))");
            entity.Property(e => e.CodCarrera).HasDefaultValue(1);
            entity.Property(e => e.CodCurso).HasDefaultValue(-1);
            entity.Property(e => e.CodDeparatmento).HasDefaultValue(1);
            entity.Property(e => e.CodEscuela).HasDefaultValue(1);
            entity.Property(e => e.CodExtension).HasDefaultValue(8);
            entity.Property(e => e.CodFacultad).HasDefaultValue(1);
            entity.Property(e => e.CodFinanciero).HasDefaultValue(10000);
            entity.Property(e => e.CodGrupo).HasDefaultValue("N");
            entity.Property(e => e.CodMateria).HasDefaultValue(-1);
            entity.Property(e => e.CodProfesor).HasDefaultValue(-1);
            entity.Property(e => e.CodTurno).HasDefaultValue(-1);
            entity.Property(e => e.Creditos).HasDefaultValue(3);
            entity.Property(e => e.DirEspecial).HasDefaultValue("DD");
            entity.Property(e => e.Edificio).HasDefaultValue("n");
            entity.Property(e => e.Estatus1).HasDefaultValue("n");
            entity.Property(e => e.Estatus2).HasDefaultValue("n");
            entity.Property(e => e.Grupo).HasDefaultValue("A");
            entity.Property(e => e.IdGrupo).HasDefaultValue(-1);
            entity.Property(e => e.IdPosicion).HasDefaultValue(-1);
            entity.Property(e => e.MateriaAbreviada).HasDefaultValue("n");
            entity.Property(e => e.MateriaCompleta).HasDefaultValue("n");
            entity.Property(e => e.Nombre).HasDefaultValue("POR");
            entity.Property(e => e.Periodo).HasDefaultValue(1);
            entity.Property(e => e.PeriodoMateria).HasDefaultValue(10);
            entity.Property(e => e.Salon).HasDefaultValue("n");
        });

        modelBuilder.Entity<CursosOficialesXPeriodos>(entity =>
        {
            entity.ToView("Cursos_oficiales_X_Periodos");
        });

        modelBuilder.Entity<CursosXGrupo>(entity =>
        {
            entity.ToView("Cursos_X_Grupo");
        });

        modelBuilder.Entity<Departamentos>(entity =>
        {
            entity.Property(e => e.Descripcion).HasDefaultValue("N");
            entity.Property(e => e.Nombre).HasDefaultValue("N");
        });

        modelBuilder.Entity<DescripcionPeriodos>(entity =>
        {
            entity.Property(e => e.Codigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<Dias>(entity =>
        {
            entity.Property(e => e.Dia).HasDefaultValue("n");
            entity.Property(e => e.NumeroDia).HasDefaultValue(-1);
        });

        modelBuilder.Entity<DocenteConHor3Anios>(entity =>
        {
            entity.ToView("DocenteConHor3Anios");
        });

        modelBuilder.Entity<Docentes2016>(entity =>
        {
            entity.ToView("Docentes2016");
        });

        modelBuilder.Entity<Docentes2017>(entity =>
        {
            entity.ToView("Docentes2017");
        });

        modelBuilder.Entity<Docentes2018>(entity =>
        {
            entity.ToView("Docentes2018");
        });

        modelBuilder.Entity<DocentesNuevos20182>(entity =>
        {
            entity.ToView("DocentesNuevos-2018-2");
        });

        modelBuilder.Entity<DocentesXCuentas>(entity =>
        {
            entity.ToView("Docentes_X_cuentas");
        });

        modelBuilder.Entity<Edificios>(entity =>
        {
            entity.Property(e => e.CodEntidad).HasDefaultValue(-1);
            entity.Property(e => e.CodExtension).HasDefaultValue(-1);
            entity.Property(e => e.CodigoEdificio).HasDefaultValue("n");
            entity.Property(e => e.Nombre).HasDefaultValue("n");
            entity.Property(e => e.Ubicacion).HasDefaultValue("n");
        });

        modelBuilder.Entity<Emailcorregir>(entity =>
        {
            entity.ToView("emailcorregir");
        });

        modelBuilder.Entity<Entidades>(entity =>
        {
            entity.Property(e => e.CodEntidad).HasDefaultValue(-1);
            entity.Property(e => e.Nombre).HasDefaultValue("n");
            entity.Property(e => e.Observacion).HasDefaultValue("n");
            entity.Property(e => e.Ubicacion).HasDefaultValue("n");
        });

        modelBuilder.Entity<Escuelas>(entity =>
        {
            entity.Property(e => e.CodEscuela).HasDefaultValue(-1);
            entity.Property(e => e.CodExtension).HasDefaultValue(-1);
            entity.Property(e => e.CodFacultad).HasDefaultValue(-1);
            entity.Property(e => e.Nombre).HasDefaultValue("n");
        });

        modelBuilder.Entity<Extensiones>(entity =>
        {
            entity.HasIndex(e => e.CodExtension, "ID_cod_extension").IsClustered();

            entity.Property(e => e.CodExtension).HasDefaultValue(-1);
            entity.Property(e => e.Distrito).HasDefaultValue("n");
            entity.Property(e => e.NombreExtension).HasDefaultValue("n");
            entity.Property(e => e.Provincia).HasDefaultValue("n");
        });

        modelBuilder.Entity<Facultades>(entity =>
        {
            entity.HasIndex(e => e.CodFacultad, "ID_cod_facultad").IsClustered();

            entity.Property(e => e.CodExtension).HasDefaultValue(-1);
            entity.Property(e => e.CodFacultad).HasDefaultValue(-1);
            entity.Property(e => e.CodNivel).HasDefaultValue(1);
            entity.Property(e => e.Facultad).HasDefaultValue("n");
        });

        modelBuilder.Entity<GrupoCursoLibreta>(entity =>
        {
            entity.ToView("Grupo_curso_libreta");
        });

        modelBuilder.Entity<Grupos>(entity =>
        {
            entity.Property(e => e.CodEsp).HasComment("0: No; 1: Si *****\"código utilizado para las grupos de carreras fuera de periodo\"*****");
            entity.Property(e => e.Turno2).HasDefaultValue(0);
        });

        modelBuilder.Entity<GruposChoques>(entity =>
        {
            entity.ToView("Grupos_choques");
        });

        modelBuilder.Entity<GruposEspeciales>(entity =>
        {
            entity.HasKey(e => e.Idr).HasName("PK_Grupo_especial");

            entity.Property(e => e.Idr).ValueGeneratedNever();
        });

        modelBuilder.Entity<HistoricoCursos>(entity =>
        {
            entity.Property(e => e.IdCurso).ValueGeneratedNever();
        });

        modelBuilder.Entity<HorarioTipoPago>(entity =>
        {
            entity.ToView("horario_tipo_pago");
        });

        modelBuilder.Entity<Horarios>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("insert_ano_periodo"));

            entity.Property(e => e.AbrevMateria).HasDefaultValue("n");
            entity.Property(e => e.AmPmF).HasDefaultValue("n");
            entity.Property(e => e.AmPmI).HasDefaultValue("n");
            entity.Property(e => e.Ano).HasDefaultValue(9999);
            entity.Property(e => e.Cod1)
                .HasDefaultValue(-1)
                .HasComment("En cantidad de semanas que debe darse, si es -1 se ajusta a lo señalado por periodo y se obvia la cantidad de este campo.");
            entity.Property(e => e.Cod2).HasDefaultValue("n");
            entity.Property(e => e.CodCurso).HasDefaultValue(-1);
            entity.Property(e => e.CodHorarioPlantilla).HasDefaultValue(-1);
            entity.Property(e => e.Edificio).HasDefaultValue("n");
            entity.Property(e => e.Estatus1).HasDefaultValue("n");
            entity.Property(e => e.Estatus2).HasDefaultValue("n");
            entity.Property(e => e.Fechamodificacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.HFinal).HasDefaultValue(-1);
            entity.Property(e => e.HInicial).HasDefaultValue(-1);
            entity.Property(e => e.IdCurso).HasDefaultValue(-1);
            entity.Property(e => e.IdGrupo).HasDefaultValue(-1);
            entity.Property(e => e.IntermedioMinutos).HasDefaultValue(-1);
            entity.Property(e => e.MFinal).HasDefaultValue(-1);
            entity.Property(e => e.MInicial).HasDefaultValue(-1);
            entity.Property(e => e.NombreDia).HasDefaultValue("n");
            entity.Property(e => e.NombreTipoClase).HasDefaultValue("n");
            entity.Property(e => e.NumeroDia).HasDefaultValue(-1);
            entity.Property(e => e.NumeroHora).HasDefaultValue(-1);
            entity.Property(e => e.Periodo).HasDefaultValue(3);
            entity.Property(e => e.Salon).HasDefaultValue("n");
            entity.Property(e => e.TipoHoraClase).HasDefaultValue(1);
            entity.Property(e => e.TipoPago).HasDefaultValue("n");
        });

        modelBuilder.Entity<HorariosCopia>(entity =>
        {
            entity.HasKey(e => e.IdHorario).HasName("PK_Horarios_copia2");
        });

        modelBuilder.Entity<HorariosCopia1>(entity =>
        {
            entity.HasKey(e => e.IdHorario).HasName("PK_Horarios_copia");
        });

        modelBuilder.Entity<HorariosPlantilla>(entity =>
        {
            entity.Property(e => e.CodPlantilla).HasDefaultValue(-1);
            entity.Property(e => e.Nombre).HasDefaultValue("n");
            entity.Property(e => e.Observacion).HasDefaultValue("n");
        });

        modelBuilder.Entity<HorariosPlantillaDetalles>(entity =>
        {
            entity.Property(e => e.CodPlantilla).HasDefaultValue(-1);
            entity.Property(e => e.NumeroHora).HasDefaultValue(-1);
            entity.Property(e => e.AmpmF).HasDefaultValue("n");
            entity.Property(e => e.AmpmI).HasDefaultValue("n");
            entity.Property(e => e.HFinal).HasDefaultValue(-1);
            entity.Property(e => e.HInicial).HasDefaultValue(-1);
            entity.Property(e => e.MFinal).HasDefaultValue(-1);
            entity.Property(e => e.MInicial).HasDefaultValue(-1);
            entity.Property(e => e.MinutosIntermedio).HasDefaultValue(-1);
        });

        modelBuilder.Entity<ListaCursoOficialesPma>(entity =>
        {
            entity.ToView("Lista_curso_oficiales_pma");
        });

        modelBuilder.Entity<ListaCursosColegiadasPma>(entity =>
        {
            entity.ToView("Lista_cursos_colegiadas_pma");
        });

        modelBuilder.Entity<ListadoAnioMayorDocentes>(entity =>
        {
            entity.ToView("Listado_anio_mayor_docentes");
        });

        modelBuilder.Entity<LsAmAm>(entity =>
        {
            entity.ToView("LS_am_am");
        });

        modelBuilder.Entity<LsAmAmCarga>(entity =>
        {
            entity.ToView("LS_am_am_Carga");
        });

        modelBuilder.Entity<LsAmPm>(entity =>
        {
            entity.ToView("LS_am_pm");
        });

        modelBuilder.Entity<LsAmPmCarga>(entity =>
        {
            entity.ToView("LS_am_pm_Carga");
        });

        modelBuilder.Entity<LsDocentesPorCarga>(entity =>
        {
            entity.ToView("LS_Docentes_PorCarga");
        });

        modelBuilder.Entity<LsDocentesPorPago>(entity =>
        {
            entity.ToView("LS_Docentes_PorPago");
        });

        modelBuilder.Entity<LsPmPmMayora4>(entity =>
        {
            entity.ToView("LS_pm_pm_mayora4");
        });

        modelBuilder.Entity<LsPmPmMayora4Carga>(entity =>
        {
            entity.ToView("LS_pm_pm_mayora4_Carga");
        });

        modelBuilder.Entity<LsPmPmMenora4>(entity =>
        {
            entity.ToView("LS_pm_pm_menora4");
        });

        modelBuilder.Entity<LsPmPmMenora4Carga>(entity =>
        {
            entity.ToView("LS_pm_pm_menora4_Carga");
        });

        modelBuilder.Entity<MatPoCarreraFiltro>(entity =>
        {
            entity.ToView("mat_po_carrera_filtro");
        });

        modelBuilder.Entity<Matcar>(entity =>
        {
            entity.ToView("Matcar");
        });

        modelBuilder.Entity<MateriasParaVerificarTecnico>(entity =>
        {
            entity.ToView("MATERIAS_PARA_VERIFICAR_TECNICO");
        });

        modelBuilder.Entity<MateriasPorCarreras>(entity =>
        {
            entity.Property(e => e.Estatus)
                .HasDefaultValue(1)
                .HasComment("1 - materia activa / 0 - materia desactivada");
            entity.Property(e => e.Horaregistro).HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            entity.Property(e => e.HorasPracticas).HasComment("Estatus para las materias Prácticas Universitarias: 0 No tiene horas prácticas, 1 si tiene horas prácticas (Lic)");
            entity.Property(e => e.IdMateria).ValueGeneratedOnAdd();
            entity.Property(e => e.Operador).HasDefaultValue("sistema");
        });

        modelBuilder.Entity<MateriasPracticas>(entity =>
        {
            entity.Property(e => e.CompetenciaNivelPractica).HasDefaultValue("N");
            entity.Property(e => e.Idmateria).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MateriasPreRequisitos>(entity =>
        {
            entity.Property(e => e.IdMateriaAsociada).HasDefaultValue(-1);
            entity.Property(e => e.NombreMateria).HasDefaultValue("N");
            entity.Property(e => e.PlanCarrera).HasDefaultValue("A");
        });

        modelBuilder.Entity<NivelAcceso>(entity =>
        {
            entity.Property(e => e.CodAcceso).HasDefaultValue(-1);
            entity.Property(e => e.Descripcion).HasDefaultValue("n");
            entity.Property(e => e.Nombre).HasDefaultValue("n");
        });

        modelBuilder.Entity<Notanoentregada>(entity =>
        {
            entity.ToView("NOTANOENTREGADA");
        });

        modelBuilder.Entity<NotasCarreras>(entity =>
        {
            entity.Property(e => e.Asunto).HasDefaultValue("N");
            entity.Property(e => e.Fecha).HasDefaultValue("N");
            entity.Property(e => e.FirmaDe).HasDefaultValue("N");
            entity.Property(e => e.Nomenclatura).HasDefaultValue("N");
            entity.Property(e => e.PlanCarrera).HasDefaultValue("A");
            entity.Property(e => e.ResumenContenido).HasDefaultValue("N");
        });

        modelBuilder.Entity<NotasMateria>(entity =>
        {
            entity.Property(e => e.Asunto).HasDefaultValue("N");
            entity.Property(e => e.Fecha).HasDefaultValue("N");
            entity.Property(e => e.FirmaDe).HasDefaultValue("N");
            entity.Property(e => e.Nomenclatura).HasDefaultValue("N");
            entity.Property(e => e.PlanCarrera).HasDefaultValue("A");
            entity.Property(e => e.ResumenContenido).HasDefaultValue("N");
        });

        modelBuilder.Entity<Numeros>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ObservacionesMateria>(entity =>
        {
            entity.Property(e => e.IdMateria).ValueGeneratedNever();
            entity.Property(e => e.Observacion).HasDefaultValue("Ninguna");
        });

        modelBuilder.Entity<Parte1Reportesubhumanos>(entity =>
        {
            entity.ToView("PARTE_1_reportesubhumanos");
        });

        modelBuilder.Entity<Parte2Reportesubhumano>(entity =>
        {
            entity.ToView("PARTE_2_reportesubhumano");
        });

        modelBuilder.Entity<Periodos>(entity =>
        {
            entity.Property(e => e.GradoId).HasDefaultValue(-1);
        });

        modelBuilder.Entity<PeriodosAcademicos>(entity =>
        {
            entity.Property(e => e.Abreviado).HasDefaultValue("N");
        });

        modelBuilder.Entity<PeriodosVigentes>(entity =>
        {
            entity.Property(e => e.AnoVigente).HasDefaultValue(-1);
            entity.Property(e => e.PeriodoCuatrimestre).HasDefaultValue(-1);
            entity.Property(e => e.PeriodoModulo).HasDefaultValue(-1);
            entity.Property(e => e.PeriodoSemestre).HasDefaultValue(-1);
        });

        modelBuilder.Entity<ProfesoresEvaluacionCursos>(entity =>
        {
            entity.ToView("ProfesoresEvaluacionCursos");
        });

        modelBuilder.Entity<Salones>(entity =>
        {
            entity.Property(e => e.CodEdificio).HasDefaultValue("n");
            entity.Property(e => e.CodExtension).HasDefaultValue(1);
            entity.Property(e => e.CodSalon).HasDefaultValue("n");
            entity.Property(e => e.Condiciones).HasDefaultValue(1);
            entity.Property(e => e.Gg).ValueGeneratedOnAdd();
            entity.Property(e => e.NombreSalon).HasDefaultValue("n");
            entity.Property(e => e.TipoSalon).HasDefaultValue(1);
            entity.Property(e => e.Ubicacion).HasDefaultValue("n");
        });

        modelBuilder.Entity<SalonesChoque>(entity =>
        {
            entity.ToView("Salones_choque");
        });

        modelBuilder.Entity<SemMat>(entity =>
        {
            entity.Property(e => e.Periodo).HasDefaultValue(1);
            entity.Property(e => e.TipoPeriodo).HasDefaultValue(4);
        });

        modelBuilder.Entity<Sesiones>(entity =>
        {
            entity.Property(e => e.Fecha).HasDefaultValue("n");
            entity.Property(e => e.Hora).HasDefaultValue("n");
            entity.Property(e => e.IdSesion).HasDefaultValue("n");
            entity.Property(e => e.IdUsuario).HasDefaultValue(-1);
            entity.Property(e => e.Ip).HasDefaultValue("n");
            entity.Property(e => e.Macadress).HasDefaultValue("n");
            entity.Property(e => e.Maquina).HasDefaultValue("n");
            entity.Property(e => e.TablasAfectadas).HasDefaultValue("n");
            entity.Property(e => e.TipoDeOperaciones).HasDefaultValue("n");
        });

        modelBuilder.Entity<T3Horarios>(entity =>
        {
            entity.ToView("T3_horarios");
        });

        modelBuilder.Entity<TipoDocente>(entity =>
        {
            entity.Property(e => e.CodTipoDocente).HasDefaultValue(-1);
            entity.Property(e => e.Descripcion).HasDefaultValue("n");
            entity.Property(e => e.Observacion).HasDefaultValue("n");
        });

        modelBuilder.Entity<TipoHoraclase>(entity =>
        {
            entity.Property(e => e.CodTipoHora).HasDefaultValue(-1);
            entity.Property(e => e.Descripcion).HasDefaultValue("n");
            entity.Property(e => e.Observacion).HasDefaultValue("n");
        });

        modelBuilder.Entity<TipoPago>(entity =>
        {
            entity.Property(e => e.CodTipo).HasDefaultValue(-1);
            entity.Property(e => e.Descripcion).HasDefaultValue("n");
            entity.Property(e => e.Observacion).HasDefaultValue("n");
        });

        modelBuilder.Entity<TipoPagos>(entity =>
        {
            entity.Property(e => e.Descripcion).HasDefaultValue("n");
            entity.Property(e => e.Nivel).HasDefaultValue(1);
            entity.Property(e => e.SubTipoGrado).HasDefaultValue(-1);
            entity.Property(e => e.TipoEstudio).HasDefaultValue(-1);
        });

        modelBuilder.Entity<TipoPeriodos>(entity =>
        {
            entity.Property(e => e.CodPeriodo).HasDefaultValue(6);
            entity.Property(e => e.Descripcion)
                .HasDefaultValue("Semestre")
                .IsFixedLength();
        });

        modelBuilder.Entity<TokenDocentes>(entity =>
        {
            entity.Property(e => e.Dni2).HasDefaultValue("N");
        });

        modelBuilder.Entity<Turnos>(entity =>
        {
            entity.HasIndex(e => e.CodTurno, "ID_cod_turno").IsClustered();

            entity.Property(e => e.Abreviado).HasDefaultValue("n");
            entity.Property(e => e.CodTurno).HasDefaultValue(-1);
            entity.Property(e => e.Nombre).HasDefaultValue("n");
            entity.Property(e => e.Observacion).HasDefaultValue("n");
        });

        modelBuilder.Entity<Usuarios>(entity =>
        {
            entity.Property(e => e.Apellido).HasDefaultValue("n");
            entity.Property(e => e.Cargo).HasDefaultValue("n");
            entity.Property(e => e.Carreras).HasDefaultValue(-1);
            entity.Property(e => e.Cedula).HasDefaultValue("n");
            entity.Property(e => e.CreadorCuenta).HasDefaultValue("n");
            entity.Property(e => e.EntidadLabora).HasDefaultValue(-1);
            entity.Property(e => e.Escuela).HasDefaultValue(-1);
            entity.Property(e => e.Extension).HasDefaultValue(-1);
            entity.Property(e => e.Facultad).HasDefaultValue(-1);
            entity.Property(e => e.FechaCreacion).HasDefaultValue("n");
            entity.Property(e => e.Funciones).HasDefaultValue("n");
            entity.Property(e => e.IdUsuario).ValueGeneratedOnAdd();
            entity.Property(e => e.Ip).HasDefaultValue("n");
            entity.Property(e => e.Macadress).HasDefaultValue("n");
            entity.Property(e => e.Maquina).HasDefaultValue("n");
            entity.Property(e => e.NivelAcceso)
                .HasDefaultValue(-1)
                .HasComment("0 no entra, 1 consulta, 5 operativo , 6 administrador");
            entity.Property(e => e.Nombre).HasDefaultValue("n");
            entity.Property(e => e.Observacion).HasDefaultValue("n");
            entity.Property(e => e.Password).HasDefaultValue("n");
            entity.Property(e => e.UbicacionFisica).HasDefaultValue("n");
            entity.Property(e => e.Usuario).HasDefaultValue("n");
        });

        modelBuilder.Entity<VerificarGruposCantEstPma>(entity =>
        {
            entity.ToView("verificar_grupos_cant_est_pma");
        });

        modelBuilder.Entity<View1>(entity =>
        {
            entity.ToView("View_1");
        });

        modelBuilder.Entity<View2>(entity =>
        {
            entity.ToView("View_2");
        });

        modelBuilder.Entity<View3>(entity =>
        {
            entity.ToView("View_3");
        });

        modelBuilder.Entity<View4ls>(entity =>
        {
            entity.ToView("View_4LS");
        });

        modelBuilder.Entity<ViewCantidadHorasCursos>(entity =>
        {
            entity.ToView("View_CantidadHorasCursos");
        });

        modelBuilder.Entity<ViewConPostgrado>(entity =>
        {
            entity.ToView("View_ConPostgrado");
        });

        modelBuilder.Entity<ViewCuentasCreadasXcortes>(entity =>
        {
            entity.ToView("View_CuentasCreadasXcortes");
        });

        modelBuilder.Entity<ViewCursosnogendpc2023>(entity =>
        {
            entity.ToView("View_CURSOSNOGENDPC2023");
        });

        modelBuilder.Entity<ViewDoc3A>(entity =>
        {
            entity.ToView("View_Doc3A");
        });

        modelBuilder.Entity<ViewDoc3Aa>(entity =>
        {
            entity.ToView("View_Doc3AA");
        });

        modelBuilder.Entity<ViewDocent20222023>(entity =>
        {
            entity.ToView("View_Docent2022-2023");
        });

        modelBuilder.Entity<ViewDocent2024>(entity =>
        {
            entity.ToView("View_Docent2024");
        });

        modelBuilder.Entity<ViewDocente2023>(entity =>
        {
            entity.ToView("View_Docente-2023");
        });

        modelBuilder.Entity<ViewDocenteVotantesUlt3Anios>(entity =>
        {
            entity.ToView("View_Docente_Votantes-Ult3Anios");
        });

        modelBuilder.Entity<ViewDocentesPrelVoto24>(entity =>
        {
            entity.ToView("View_DocentesPrelVoto24");
        });

        modelBuilder.Entity<ViewDocentesXCuentas>(entity =>
        {
            entity.ToView("View_Docentes_X_Cuentas");
        });

        modelBuilder.Entity<ViewHorariosCurso>(entity =>
        {
            entity.ToView("View_HorariosCurso");

            entity.Property(e => e.IdHorario).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ViewIltec1>(entity =>
        {
            entity.ToView("View_Iltec1");
        });

        modelBuilder.Entity<ViewIltec2>(entity =>
        {
            entity.ToView("View_Iltec2");
        });

        modelBuilder.Entity<ViewMateriasXcarreraSemestre>(entity =>
        {
            entity.ToView("View_MateriasXCarreraSemestre");
        });

        modelBuilder.Entity<ViewNumCar>(entity =>
        {
            entity.ToView("ViewNumCar");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ViewPorAutorizarConHorariosTurnos>(entity =>
        {
            entity.ToView("View_PorAutorizarConHorariosTurnos");

            entity.Property(e => e.Apellido).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Expr1).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IdHorario).ValueGeneratedOnAdd();
            entity.Property(e => e.Nombre).UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<ViewPreliFinalDoce2024>(entity =>
        {
            entity.ToView("View_PreliFinalDoce2024");
        });

        modelBuilder.Entity<ViewSinPostgrado>(entity =>
        {
            entity.ToView("View_SinPostgrado");
        });

        modelBuilder.Entity<ViewUlt3AnioV2>(entity =>
        {
            entity.ToView("View_Ult3Anio-V2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
