using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Evaluation.Web.Migrations
{
    public partial class AddFiled_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Cargo1",
                table: "EntityUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartamentoCodigo",
                table: "EntityUsuarios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EntityUsuarios_Cargo1",
                table: "EntityUsuarios",
                column: "Cargo1");

            migrationBuilder.CreateIndex(
                name: "IX_EntityUsuarios_DepartamentoCodigo",
                table: "EntityUsuarios",
                column: "DepartamentoCodigo");

            migrationBuilder.AddForeignKey(
                name: "FK_EntityUsuarios_EntityCargos_Cargo1",
                table: "EntityUsuarios",
                column: "Cargo1",
                principalTable: "EntityCargos",
                principalColumn: "Cargo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityUsuarios_EntityDepartamentos_DepartamentoCodigo",
                table: "EntityUsuarios",
                column: "DepartamentoCodigo",
                principalTable: "EntityDepartamentos",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntityUsuarios_EntityCargos_Cargo1",
                table: "EntityUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityUsuarios_EntityDepartamentos_DepartamentoCodigo",
                table: "EntityUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_EntityUsuarios_Cargo1",
                table: "EntityUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_EntityUsuarios_DepartamentoCodigo",
                table: "EntityUsuarios");

            migrationBuilder.DropColumn(
                name: "Cargo1",
                table: "EntityUsuarios");

            migrationBuilder.DropColumn(
                name: "DepartamentoCodigo",
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
    }
}
