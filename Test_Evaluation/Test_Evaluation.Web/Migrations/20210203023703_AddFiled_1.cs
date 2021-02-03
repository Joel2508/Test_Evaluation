using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Evaluation.Web.Migrations
{
    public partial class AddFiled_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntityUsuarios_EntityCargos_EntityCargosCargo",
                table: "EntityUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityUsuarios_EntityDepartamentos_EntityDepartamentosCodigo",
                table: "EntityUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_EntityUsuarios_EntityCargosCargo",
                table: "EntityUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_EntityUsuarios_EntityDepartamentosCodigo",
                table: "EntityUsuarios");

            migrationBuilder.DropColumn(
                name: "EntityCargosCargo",
                table: "EntityUsuarios");

            migrationBuilder.DropColumn(
                name: "EntityDepartamentosCodigo",
                table: "EntityUsuarios");

            migrationBuilder.AddColumn<int>(
                name: "EntityUsuariosUsuario",
                table: "EntityDepartamentos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityUsuariosUsuario",
                table: "EntityCargos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EntityDepartamentos_EntityUsuariosUsuario",
                table: "EntityDepartamentos",
                column: "EntityUsuariosUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_EntityCargos_EntityUsuariosUsuario",
                table: "EntityCargos",
                column: "EntityUsuariosUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_EntityCargos_EntityUsuarios_EntityUsuariosUsuario",
                table: "EntityCargos",
                column: "EntityUsuariosUsuario",
                principalTable: "EntityUsuarios",
                principalColumn: "Usuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityDepartamentos_EntityUsuarios_EntityUsuariosUsuario",
                table: "EntityDepartamentos",
                column: "EntityUsuariosUsuario",
                principalTable: "EntityUsuarios",
                principalColumn: "Usuario",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntityCargos_EntityUsuarios_EntityUsuariosUsuario",
                table: "EntityCargos");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityDepartamentos_EntityUsuarios_EntityUsuariosUsuario",
                table: "EntityDepartamentos");

            migrationBuilder.DropIndex(
                name: "IX_EntityDepartamentos_EntityUsuariosUsuario",
                table: "EntityDepartamentos");

            migrationBuilder.DropIndex(
                name: "IX_EntityCargos_EntityUsuariosUsuario",
                table: "EntityCargos");

            migrationBuilder.DropColumn(
                name: "EntityUsuariosUsuario",
                table: "EntityDepartamentos");

            migrationBuilder.DropColumn(
                name: "EntityUsuariosUsuario",
                table: "EntityCargos");

            migrationBuilder.AddColumn<int>(
                name: "EntityCargosCargo",
                table: "EntityUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityDepartamentosCodigo",
                table: "EntityUsuarios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EntityUsuarios_EntityCargosCargo",
                table: "EntityUsuarios",
                column: "EntityCargosCargo");

            migrationBuilder.CreateIndex(
                name: "IX_EntityUsuarios_EntityDepartamentosCodigo",
                table: "EntityUsuarios",
                column: "EntityDepartamentosCodigo");

            migrationBuilder.AddForeignKey(
                name: "FK_EntityUsuarios_EntityCargos_EntityCargosCargo",
                table: "EntityUsuarios",
                column: "EntityCargosCargo",
                principalTable: "EntityCargos",
                principalColumn: "Cargo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityUsuarios_EntityDepartamentos_EntityDepartamentosCodigo",
                table: "EntityUsuarios",
                column: "EntityDepartamentosCodigo",
                principalTable: "EntityDepartamentos",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
