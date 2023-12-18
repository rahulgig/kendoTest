using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kendoTest.Migrations
{
    /// <inheritdoc />
    public partial class LastMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcceptedByModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfAcceptance = table.Column<DateOnly>(type: "date", nullable: false),
                    ReportId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcceptedByModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreparedByModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfPreperation = table.Column<DateOnly>(type: "date", nullable: false),
                    ReportId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreparedByModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecommendedByModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfRecomendateion = table.Column<DateOnly>(type: "date", nullable: false),
                    ReportId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecommendedByModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Report404Models",
                columns: table => new
                {
                    ReportId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenditureClaimFormNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    PrepareredById = table.Column<int>(type: "int", nullable: true),
                    RecomendedById = table.Column<int>(type: "int", nullable: true),
                    AcceptedById = table.Column<int>(type: "int", nullable: true),
                    OfficeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfficeCodeNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FiscalYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report404Models", x => x.ReportId);
                    table.ForeignKey(
                        name: "FK_Report404Models_AcceptedByModel_AcceptedById",
                        column: x => x.AcceptedById,
                        principalTable: "AcceptedByModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Report404Models_PreparedByModel_PrepareredById",
                        column: x => x.PrepareredById,
                        principalTable: "PreparedByModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Report404Models_RecommendedByModel_RecomendedById",
                        column: x => x.RecomendedById,
                        principalTable: "RecommendedByModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Report404SubForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SN = table.Column<long>(type: "bigint", nullable: false),
                    FormName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Symbol_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specificatin_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Akin_no = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<long>(type: "bigint", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report404SubForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Report404SubForms_Report404Models_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report404Models",
                        principalColumn: "ReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Report404Models_AcceptedById",
                table: "Report404Models",
                column: "AcceptedById");

            migrationBuilder.CreateIndex(
                name: "IX_Report404Models_PrepareredById",
                table: "Report404Models",
                column: "PrepareredById");

            migrationBuilder.CreateIndex(
                name: "IX_Report404Models_RecomendedById",
                table: "Report404Models",
                column: "RecomendedById");

            migrationBuilder.CreateIndex(
                name: "IX_Report404SubForms_ReportId",
                table: "Report404SubForms",
                column: "ReportId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Report404SubForms");

            migrationBuilder.DropTable(
                name: "Report404Models");

            migrationBuilder.DropTable(
                name: "AcceptedByModel");

            migrationBuilder.DropTable(
                name: "PreparedByModel");

            migrationBuilder.DropTable(
                name: "RecommendedByModel");
        }
    }
}
