using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddDataDetailsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "InitDate",
                table: "Debts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "DebtDetails",
                columns: table => new
                {
                    IdDebtDetail = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdDebt = table.Column<int>(nullable: false),
                    Interest = table.Column<decimal>(nullable: false),
                    Capital = table.Column<decimal>(nullable: false),
                    Fee = table.Column<decimal>(nullable: false),
                    NumberFee = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebtDetails", x => x.IdDebtDetail);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DebtDetails");

            migrationBuilder.DropColumn(
                name: "InitDate",
                table: "Debts");
        }
    }
}
