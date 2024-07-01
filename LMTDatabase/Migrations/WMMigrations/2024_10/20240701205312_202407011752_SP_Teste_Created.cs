using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMTDatabase.Migrations.WMMigrations._2024_10
{
    /// <inheritdoc />
    public partial class _202407011752_SP_Teste_Created : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var script = @"IF OBJECT_ID ('TESTE') IS NOT NULL BEGIN DROP PROCEDURE TESTE END";

            migrationBuilder.Sql(script);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var script = @"CREATE PROCEDURE TESTE AS BEGIN SET NOCOUNT ON;  SELECT 'PROCEDURE' END";

            migrationBuilder.Sql(script);
        }
    }
}
