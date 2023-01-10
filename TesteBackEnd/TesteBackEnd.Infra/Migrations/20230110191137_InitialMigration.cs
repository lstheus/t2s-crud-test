using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteBackEnd.Infra.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "conteiners",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conteiners", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_conteiners_clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "movimentacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoConteiner = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TipoMov = table.Column<int>(type: "int", nullable: false),
                    DtInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    ClienteNome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movimentacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_movimentacoes_conteiners_CodigoConteiner",
                        column: x => x.CodigoConteiner,
                        principalTable: "conteiners",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_conteiners_ClienteId",
                table: "conteiners",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_movimentacoes_CodigoConteiner",
                table: "movimentacoes",
                column: "CodigoConteiner");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movimentacoes");

            migrationBuilder.DropTable(
                name: "conteiners");

            migrationBuilder.DropTable(
                name: "clientes");
        }
    }
}
