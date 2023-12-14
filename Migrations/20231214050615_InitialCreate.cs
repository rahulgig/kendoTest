using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kendoTest.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Report407",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameoftheGoods = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    ReferenceNumber = table.Column<int>(type: "int", nullable: false),
                    Specification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MLPFormNo = table.Column<int>(type: "int", nullable: false),
                    OfficeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfficeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FiscalYear = table.Column<int>(type: "int", nullable: false),
                    FormName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report407", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Iteam407",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    EntryFormNo = table.Column<int>(type: "int", nullable: false),
                    Report407ModelId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iteam407", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Iteam407_Report407_Report407ModelId",
                        column: x => x.Report407ModelId,
                        principalTable: "Report407",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LedgerEntry407",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    FormNumber = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentQuantity = table.Column<int>(type: "int", nullable: false),
                    CurrentIncomeRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrentIncomeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IncomeQuantity = table.Column<int>(type: "int", nullable: false),
                    IncomeRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IncomeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpenditureQuantity = table.Column<int>(type: "int", nullable: false),
                    ExpenditureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpenditureAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EntryType = table.Column<int>(type: "int", nullable: false),
                    PendingQuantity = table.Column<int>(type: "int", nullable: false),
                    PendingRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PendingAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PreparedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreparedByPosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Report407ModelId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LedgerEntry407", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LedgerEntry407_Report407_Report407ModelId",
                        column: x => x.Report407ModelId,
                        principalTable: "Report407",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Iteam407_Report407ModelId",
                table: "Iteam407",
                column: "Report407ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_LedgerEntry407_Report407ModelId",
                table: "LedgerEntry407",
                column: "Report407ModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iteam407");

            migrationBuilder.DropTable(
                name: "LedgerEntry407");

            migrationBuilder.DropTable(
                name: "Report407");
        }
    }
}
