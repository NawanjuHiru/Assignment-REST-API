using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_REST_API.Data.Migrations
{
    public partial class AssignmentRESTAPI0001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Basic_Data",
                columns: table => new
                {
                    SAPCode = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BP = table.Column<int>(type: "int", nullable: false),
                    ARCode = table.Column<int>(type: "int", nullable: false),
                    ARName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ARCategory = table.Column<bool>(type: "bit", nullable: false),
                    Spoc1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Spoc2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NDReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteId = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Project = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnAirDate1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectStatus = table.Column<bool>(type: "bit", nullable: false),
                    TargetWeek = table.Column<bool>(type: "bit", nullable: false),
                    RiskLevel = table.Column<bool>(type: "bit", nullable: false),
                    OnAirDate2 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    YearMonth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Commitment = table.Column<bool>(type: "bit", nullable: false),
                    Actual = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basic_Data", x => x.SAPCode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Basic_Data");
        }
    }
}
