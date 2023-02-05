﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducacaoFinanceira.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AjusteTipoInvestimento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "TipoInvestimento",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "TipoInvestimento");
        }
    }
}
