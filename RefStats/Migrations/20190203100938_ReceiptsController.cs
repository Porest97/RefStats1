using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RefStats.Migrations
{
    public partial class ReceiptsController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receipt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Receipt_Id = table.Column<int>(nullable: false),
                    MatchNumber = table.Column<int>(nullable: false),
                    MatchDate = table.Column<DateTime>(nullable: false),
                    Match = table.Column<string>(nullable: true),
                    MatchRef1 = table.Column<string>(nullable: true),
                    FeeRef1 = table.Column<float>(nullable: false),
                    AllowanceRef1 = table.Column<float>(nullable: false),
                    TravelCostRef1 = table.Column<float>(nullable: false),
                    MatchRef2 = table.Column<string>(nullable: true),
                    FeeRef2 = table.Column<float>(nullable: false),
                    AllowanceRef2 = table.Column<float>(nullable: false),
                    TravelCostRef2 = table.Column<float>(nullable: false),
                    MatchRef3 = table.Column<string>(nullable: true),
                    FeeRef3 = table.Column<float>(nullable: false),
                    AllowanceRef3 = table.Column<float>(nullable: false),
                    TravelCostRef3 = table.Column<float>(nullable: false),
                    MatchRef4 = table.Column<string>(nullable: true),
                    FeeRef4 = table.Column<float>(nullable: false),
                    AllowanceRef4 = table.Column<float>(nullable: false),
                    TravelCostRef4 = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipt", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receipt");
        }
    }
}
