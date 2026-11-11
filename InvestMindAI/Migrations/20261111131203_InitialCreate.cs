using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestMindAI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinancialSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StocksValue = table.Column<decimal>(type: "TEXT", nullable: false),
                    EtfValue = table.Column<decimal>(type: "TEXT", nullable: false),
                    CashValue = table.Column<decimal>(type: "TEXT", nullable: false),
                    OtherAssetsValue = table.Column<decimal>(type: "TEXT", nullable: false),
                    MonthlyBudget = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialSettings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FinancialSettings",
                columns: new[] { "Id", "CashValue", "EtfValue", "MonthlyBudget", "OtherAssetsValue", "StocksValue" },
                values: new object[] { 1, 0m, 0m, 0m, 0m, 0m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "FinancialSettings");
        }
    }
}
