using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Evaluation.Web.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntityUsuarios",
                columns: table => new
                {
                    Usuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cedula = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityUsuarios", x => x.Usuario);
                });

            migrationBuilder.CreateTable(
                name: "EntityCargos",
                columns: table => new
                {
                    Cargo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    EntityUsuarioUsuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityCargos", x => x.Cargo);
                    table.ForeignKey(
                        name: "FK_EntityCargos_EntityUsuarios_EntityUsuarioUsuario",
                        column: x => x.EntityUsuarioUsuario,
                        principalTable: "EntityUsuarios",
                        principalColumn: "Usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntityDepartamentos",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    EntityUsuarioUsuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityDepartamentos", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_EntityDepartamentos_EntityUsuarios_EntityUsuarioUsuario",
                        column: x => x.EntityUsuarioUsuario,
                        principalTable: "EntityUsuarios",
                        principalColumn: "Usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntityCargos_EntityUsuarioUsuario",
                table: "EntityCargos",
                column: "EntityUsuarioUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_EntityDepartamentos_EntityUsuarioUsuario",
                table: "EntityDepartamentos",
                column: "EntityUsuarioUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntityCargos");

            migrationBuilder.DropTable(
                name: "EntityDepartamentos");

            migrationBuilder.DropTable(
                name: "EntityUsuarios");
        }
    }
}
