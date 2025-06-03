using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class AddExcedenteEnergiaEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExcedentesEnergiaEnFuncionamiento",
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
                    TipoTecnologia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtrasTecnologias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapacidadProduccionEnergia = table.Column<int>(type: "int", nullable: false),
                    ExcedenteEnergia = table.Column<int>(type: "int", nullable: false),
                    HorasExcedenteEnergia = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DiasExcedenteEnergia = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CapacidadProduccion = table.Column<int>(type: "int", nullable: false),
                    ProduceEnergia = table.Column<bool>(type: "bit", nullable: false),
                    FechaInicioProduccion = table.Column<DateOnly>(type: "date", nullable: true),
                    VierteEnergiaRed = table.Column<bool>(type: "bit", nullable: false),
                    VierteEnergiaTrue = table.Column<int>(type: "int", nullable: true),
                    Autoconsumo = table.Column<bool>(type: "bit", nullable: false),
                    PaisInstalacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinciaInstalacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioInstalacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coordenadas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TieneLicencia = table.Column<bool>(type: "bit", nullable: false),
                    CapacidadProduccionLicencia = table.Column<int>(type: "int", nullable: true),
                    QuiereProducirConExcedente = table.Column<bool>(type: "bit", nullable: false),
                    AlquilarParteOTotalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcedentesEnergiaEnFuncionamiento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExcedentesEnergiaNuevo",
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
                    InstalacionContruidaFalse = table.Column<DateOnly>(type: "date", nullable: true),
                    InstalacionEnConstruccion = table.Column<bool>(type: "bit", nullable: false),
                    InstalacionEnConstruccionTrue = table.Column<DateOnly>(type: "date", nullable: true),
                    KwTotalesProduccion = table.Column<int>(type: "int", nullable: true),
                    TipoTecnologia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtrasTecnologias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinaInstalacion = table.Column<bool>(type: "bit", nullable: false),
                    KwDestinados = table.Column<int>(type: "int", nullable: true),
                    NumeroHoras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaisInstalacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinciaInstalacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioInstalacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coordenadas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TieneLicencia = table.Column<bool>(type: "bit", nullable: false),
                    CapacidadProduccionLicencia = table.Column<int>(type: "int", nullable: true),
                    QuierePersonalTramitar = table.Column<bool>(type: "bit", nullable: false),
                    QuiereProducirConExcedente = table.Column<bool>(type: "bit", nullable: false),
                    AlquilarInstalaciones = table.Column<bool>(type: "bit", nullable: false),
                    AnosAlquiler = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcedentesEnergiaNuevo", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.DropTable(
                name: "ExcedentesEnergiaNuevo");
        }
    }
}
