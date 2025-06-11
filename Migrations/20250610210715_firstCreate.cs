using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class firstCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "VentaAlquilerHidrogeno",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "TransportesHidrogeno",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ProduccionesHidrogeno",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ExcedentesEnergiaNuevo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ExcedentesEnergiaEnFuncionamiento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VentaAlquilerHidrogeno_UserId",
                table: "VentaAlquilerHidrogeno",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportesHidrogeno_UserId",
                table: "TransportesHidrogeno",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProduccionesHidrogeno_UserId",
                table: "ProduccionesHidrogeno",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExcedentesEnergiaNuevo_UserId",
                table: "ExcedentesEnergiaNuevo",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExcedentesEnergiaEnFuncionamiento_UserId",
                table: "ExcedentesEnergiaEnFuncionamiento",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExcedentesEnergiaEnFuncionamiento_Users_UserId",
                table: "ExcedentesEnergiaEnFuncionamiento",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExcedentesEnergiaNuevo_Users_UserId",
                table: "ExcedentesEnergiaNuevo",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProduccionesHidrogeno_Users_UserId",
                table: "ProduccionesHidrogeno",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransportesHidrogeno_Users_UserId",
                table: "TransportesHidrogeno",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VentaAlquilerHidrogeno_Users_UserId",
                table: "VentaAlquilerHidrogeno",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExcedentesEnergiaEnFuncionamiento_Users_UserId",
                table: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.DropForeignKey(
                name: "FK_ExcedentesEnergiaNuevo_Users_UserId",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropForeignKey(
                name: "FK_ProduccionesHidrogeno_Users_UserId",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportesHidrogeno_Users_UserId",
                table: "TransportesHidrogeno");

            migrationBuilder.DropForeignKey(
                name: "FK_VentaAlquilerHidrogeno_Users_UserId",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropIndex(
                name: "IX_VentaAlquilerHidrogeno_UserId",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropIndex(
                name: "IX_TransportesHidrogeno_UserId",
                table: "TransportesHidrogeno");

            migrationBuilder.DropIndex(
                name: "IX_ProduccionesHidrogeno_UserId",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropIndex(
                name: "IX_ExcedentesEnergiaNuevo_UserId",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropIndex(
                name: "IX_ExcedentesEnergiaEnFuncionamiento_UserId",
                table: "ExcedentesEnergiaEnFuncionamiento");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "VentaAlquilerHidrogeno");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TransportesHidrogeno");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ProduccionesHidrogeno");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ExcedentesEnergiaNuevo");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ExcedentesEnergiaEnFuncionamiento");
        }
    }
}
