using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class AddProduccionHidrogenoEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProduccionesHidrogeno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoEntidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Empresa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CIF = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DNI = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Representante = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NombreRepresentante = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ApellidosRepresentante = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Provincia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    InstalacionConstruida = table.Column<bool>(type: "bit", nullable: false),
                    TipoTecnologia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtrasTecnologias = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CuantoKiloGramosHora = table.Column<int>(type: "int", nullable: false),
                    Autoconsumo = table.Column<bool>(type: "bit", nullable: false),
                    TipoSectorProduccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovilidadSelect = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ResidencialSelect = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IndustrialSelect = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DistribucionSelect = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OtroSector = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PaisProduccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProvinciaProduccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MunicipioProduccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PaisConsumicion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProvinciaConsumicion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MunicipioConsumicion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MetanolVerde = table.Column<bool>(type: "bit", nullable: false),
                    EquiposProducir = table.Column<bool>(type: "bit", nullable: false),
                    EquiposAlmacenar = table.Column<bool>(type: "bit", nullable: false),
                    OtraTecnologia = table.Column<bool>(type: "bit", nullable: false),
                    IndicarCual = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NecesitaEmpresa = table.Column<bool>(type: "bit", nullable: false),
                    PaisNecesita = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProvinciaNecesita = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MunicipioNecesita = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BaresHidrogeno = table.Column<int>(type: "int", nullable: false),
                    AlquilarTerrenoSinInstalaciones = table.Column<bool>(type: "bit", nullable: false),
                    AnosAlquiler = table.Column<int>(type: "int", nullable: false),
                    AlquilarTerrenoConInstalaciones = table.Column<bool>(type: "bit", nullable: false),
                    TipoTecnologiaAlquiler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtrasTecnologiasAlquiler = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ContratarPPA = table.Column<bool>(type: "bit", nullable: false),
                    AyudaProveedorPPA = table.Column<bool>(type: "bit", nullable: false),
                    ProporcionClientes = table.Column<bool>(type: "bit", nullable: false),
                    RedEmpresas = table.Column<bool>(type: "bit", nullable: false),
                    RedHidrogeneras = table.Column<bool>(type: "bit", nullable: false),
                    RedPuntosDispensacion = table.Column<bool>(type: "bit", nullable: false),
                    TramitacionSolicitudes = table.Column<bool>(type: "bit", nullable: false),
                    FechaHidrogenoDisponible = table.Column<DateOnly>(type: "date", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduccionesHidrogeno", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProduccionesHidrogeno");
        }
    }
}
