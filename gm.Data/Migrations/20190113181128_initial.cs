using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gm.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeSheets",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Client = table.Column<string>(maxLength: 255, nullable: false),
                    Project = table.Column<string>(nullable: true),
                    ProjectCode = table.Column<string>(nullable: true),
                    Task = table.Column<string>(nullable: true),
                    Hours = table.Column<double>(nullable: false),
                    HoursRounded = table.Column<double>(nullable: false),
                    IsBillable = table.Column<bool>(nullable: false),
                    Invoiced = table.Column<bool>(nullable: false),
                    Approved = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    IsEmployee = table.Column<bool>(nullable: false),
                    BillableRate = table.Column<decimal>(nullable: false),
                    CostRate = table.Column<decimal>(nullable: false),
                    CostAmount = table.Column<decimal>(nullable: false),
                    Currency = table.Column<string>(nullable: true),
                    ExternalReferenceURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSheets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeSheets");
        }
    }
}
