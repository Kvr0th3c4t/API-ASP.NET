using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class testNuevoLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activo",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropColumn(
                name: "ApellidosRepresentante",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropColumn(
                name: "CIF",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropColumn(
                name: "DNI",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropColumn(
                name: "Empresa",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropColumn(
                name: "FechaRegistro",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropColumn(
                name: "Municipio",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropColumn(
                name: "NombreRepresentante",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropColumn(
                name: "Provincia",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropColumn(
                name: "Representante",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropColumn(
                name: "TipoEntidad",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "TransportesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "TransportesHidrogeno");

            migrationBuilder.DropColumn(
                name: "ApellidosRepresentante",
                table: "TransportesHidrogeno");

            migrationBuilder.DropColumn(
                name: "CIF",
                table: "TransportesHidrogeno");

            migrationBuilder.DropColumn(
                name: "DNI",
                table: "TransportesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "TransportesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Empresa",
                table: "TransportesHidrogeno");

            migrationBuilder.DropColumn(
                name: "FechaRegistro",
                table: "TransportesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Municipio",
                table: "TransportesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "TransportesHidrogeno");

            migrationBuilder.DropColumn(
                name: "NombreRepresentante",
                table: "TransportesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "TransportesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Provincia",
                table: "TransportesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Representante",
                table: "TransportesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "TransportesHidrogeno");

            migrationBuilder.DropColumn(
                name: "TipoEntidad",
                table: "TransportesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropColumn(
                name: "ApellidosRepresentante",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropColumn(
                name: "CIF",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropColumn(
                name: "DNI",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Empresa",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropColumn(
                name: "FechaRegistro",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Municipio",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropColumn(
                name: "NombreRepresentante",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Provincia",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Representante",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropColumn(
                name: "TipoEntidad",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropColumn(
                name: "ApellidosRepresentante",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropColumn(
                name: "CIF",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropColumn(
                name: "DNI",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropColumn(
                name: "Empresa",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropColumn(
                name: "FechaRegistro",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropColumn(
                name: "Municipio",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropColumn(
                name: "NombreRepresentante",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropColumn(
                name: "Provincia",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropColumn(
                name: "Representante",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropColumn(
                name: "TipoEntidad",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.DropColumn(
                name: "ApellidosRepresentante",
                table: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.DropColumn(
                name: "CIF",
                table: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.DropColumn(
                name: "DNI",
                table: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.DropColumn(
                name: "Empresa",
                table: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.DropColumn(
                name: "FechaRegistro",
                table: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.DropColumn(
                name: "Municipio",
                table: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.DropColumn(
                name: "NombreRepresentante",
                table: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.DropColumn(
                name: "Provincia",
                table: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.DropColumn(
                name: "Representante",
                table: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.DropColumn(
                name: "TipoEntidad",
                table: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApellidosRepresentante",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CIF",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DNI",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Empresa",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaRegistro",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Municipio",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreRepresentante",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Provincia",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Representante",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoEntidad",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ApellidosRepresentante",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CIF",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DNI",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Empresa",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FechaRegistro",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Municipio",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NombreRepresentante",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Provincia",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Representante",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TipoEntidad",
                table: "Users");

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "VentaAlquilerHidrogeno",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "VentaAlquilerHidrogeno",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApellidosRepresentante",
                table: "VentaAlquilerHidrogeno",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CIF",
                table: "VentaAlquilerHidrogeno",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DNI",
                table: "VentaAlquilerHidrogeno",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "VentaAlquilerHidrogeno",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Empresa",
                table: "VentaAlquilerHidrogeno",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaRegistro",
                table: "VentaAlquilerHidrogeno",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Municipio",
                table: "VentaAlquilerHidrogeno",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "VentaAlquilerHidrogeno",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreRepresentante",
                table: "VentaAlquilerHidrogeno",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "VentaAlquilerHidrogeno",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Provincia",
                table: "VentaAlquilerHidrogeno",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Representante",
                table: "VentaAlquilerHidrogeno",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "VentaAlquilerHidrogeno",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoEntidad",
                table: "VentaAlquilerHidrogeno",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "TransportesHidrogeno",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "TransportesHidrogeno",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApellidosRepresentante",
                table: "TransportesHidrogeno",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CIF",
                table: "TransportesHidrogeno",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DNI",
                table: "TransportesHidrogeno",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "TransportesHidrogeno",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Empresa",
                table: "TransportesHidrogeno",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaRegistro",
                table: "TransportesHidrogeno",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Municipio",
                table: "TransportesHidrogeno",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "TransportesHidrogeno",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreRepresentante",
                table: "TransportesHidrogeno",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "TransportesHidrogeno",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Provincia",
                table: "TransportesHidrogeno",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Representante",
                table: "TransportesHidrogeno",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "TransportesHidrogeno",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoEntidad",
                table: "TransportesHidrogeno",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "ProduccionesHidrogeno",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "ProduccionesHidrogeno",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApellidosRepresentante",
                table: "ProduccionesHidrogeno",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CIF",
                table: "ProduccionesHidrogeno",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DNI",
                table: "ProduccionesHidrogeno",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ProduccionesHidrogeno",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Empresa",
                table: "ProduccionesHidrogeno",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaRegistro",
                table: "ProduccionesHidrogeno",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Municipio",
                table: "ProduccionesHidrogeno",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "ProduccionesHidrogeno",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreRepresentante",
                table: "ProduccionesHidrogeno",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "ProduccionesHidrogeno",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Provincia",
                table: "ProduccionesHidrogeno",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Representante",
                table: "ProduccionesHidrogeno",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "ProduccionesHidrogeno",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoEntidad",
                table: "ProduccionesHidrogeno",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "ExcedentesEnergiaNuevo",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "ExcedentesEnergiaNuevo",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApellidosRepresentante",
                table: "ExcedentesEnergiaNuevo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CIF",
                table: "ExcedentesEnergiaNuevo",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DNI",
                table: "ExcedentesEnergiaNuevo",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ExcedentesEnergiaNuevo",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Empresa",
                table: "ExcedentesEnergiaNuevo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaRegistro",
                table: "ExcedentesEnergiaNuevo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Municipio",
                table: "ExcedentesEnergiaNuevo",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "ExcedentesEnergiaNuevo",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreRepresentante",
                table: "ExcedentesEnergiaNuevo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "ExcedentesEnergiaNuevo",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Provincia",
                table: "ExcedentesEnergiaNuevo",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Representante",
                table: "ExcedentesEnergiaNuevo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "ExcedentesEnergiaNuevo",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoEntidad",
                table: "ExcedentesEnergiaNuevo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "ExcedentesEnergiaEnFuncionamiento",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "ExcedentesEnergiaEnFuncionamiento",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApellidosRepresentante",
                table: "ExcedentesEnergiaEnFuncionamiento",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CIF",
                table: "ExcedentesEnergiaEnFuncionamiento",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DNI",
                table: "ExcedentesEnergiaEnFuncionamiento",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ExcedentesEnergiaEnFuncionamiento",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Empresa",
                table: "ExcedentesEnergiaEnFuncionamiento",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaRegistro",
                table: "ExcedentesEnergiaEnFuncionamiento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Municipio",
                table: "ExcedentesEnergiaEnFuncionamiento",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "ExcedentesEnergiaEnFuncionamiento",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreRepresentante",
                table: "ExcedentesEnergiaEnFuncionamiento",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "ExcedentesEnergiaEnFuncionamiento",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Provincia",
                table: "ExcedentesEnergiaEnFuncionamiento",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Representante",
                table: "ExcedentesEnergiaEnFuncionamiento",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "ExcedentesEnergiaEnFuncionamiento",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoEntidad",
                table: "ExcedentesEnergiaEnFuncionamiento",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
