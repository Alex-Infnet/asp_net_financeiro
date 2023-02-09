using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducacaoFinanceira.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ModeloIr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeloIr", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModeloIrOcorrencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeloIrId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeloIrOcorrencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModeloIrOcorrencia_ModeloIr_ModeloIrId",
                        column: x => x.ModeloIrId,
                        principalTable: "ModeloIr",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TipoInvestimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeloIrId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoInvestimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoInvestimento_ModeloIr_ModeloIrId",
                        column: x => x.ModeloIrId,
                        principalTable: "ModeloIr",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModeloIrOcorrencia_ModeloIrId",
                table: "ModeloIrOcorrencia",
                column: "ModeloIrId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoInvestimento_ModeloIrId",
                table: "TipoInvestimento",
                column: "ModeloIrId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModeloIrOcorrencia");

            migrationBuilder.DropTable(
                name: "TipoInvestimento");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "ModeloIr");
        }
    }
}
