using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class AddVendeAlquilaHidrogeno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransportesHidrogeno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoEntidad = table.Column<int>(type: "int", nullable: false),
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
                    LicenciaMercanciaPeligrosa = table.Column<bool>(type: "bit", nullable: false),
                    FalseLicenciaAsesoramiento = table.Column<bool>(type: "bit", nullable: false),
                    TipoTransporte = table.Column<int>(type: "int", nullable: false),
                    TieneCaminonesHidrogeno = table.Column<bool>(type: "bit", nullable: false),
                    TieneCamionesMetanol = table.Column<bool>(type: "bit", nullable: false),
                    TieneCamionesAmoniaco = table.Column<bool>(type: "bit", nullable: false),
                    RedTransporte = table.Column<bool>(type: "bit", nullable: false),
                    TipoRed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoTransporteHidrogeno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresionHidrogeno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioTransporte = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProvinciaTransporte = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PaisTransporte = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NecesitaFormacion = table.Column<bool>(type: "bit", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportesHidrogeno", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VentaAlquilerHidrogeno",
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
                    MetrosCuadradosTerreno = table.Column<int>(type: "int", nullable: true),
                    TipoTerreno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TieneLicencia = table.Column<bool>(type: "bit", nullable: true),
                    Licencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VenderAlquilar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnosAlquiler = table.Column<int>(type: "int", nullable: true),
                    PrecioAlquiler = table.Column<int>(type: "int", nullable: false),
                    PrecioVenta = table.Column<int>(type: "int", nullable: false),
                    PaisAlVen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinciaAlVen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MunicipioAlVen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Coordenadas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentaAlquilerHidrogeno", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransportesHidrogeno");

            migrationBuilder.DropTable(
                name: "VentaAlquilerHidrogeno");
        }
    }
}
