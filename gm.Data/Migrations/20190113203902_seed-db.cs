
using System.IO;
using System.Text;
using System.Linq;
using System.Reflection;
using gm.Data.Repository;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace gm.Data.Migrations
{
    public partial class seeddb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var filePath = Path.Combine(appPath, "Data\\GM_Backend_Coding_Exercise_-_Sample_Data_Report.csv");
            var repo = new InMemoryCSVRepository(filePath);
            var records = repo.GetAllTimeSheets();

            foreach (var r in records)
            {
                var insertSQL = new StringBuilder();
                insertSQL.Append("INSERT INTO dbo.TimeSheets([Uuid], [Date], [Client], [Project], [ProjectCode], [Task], [Hours], [HoursRounded], [IsBillable], [Invoiced], [Approved],  [FirstName] ,[LastName], [Department], [IsEmployee] , [BillableRate], [CostRate], [CostAmount], [Currency], [ExternalReferenceURL] )");
                insertSQL.Append($"VALUES({ Guid.NewGuid()}, {r.Date}, {r.Client}, {r.Project}, {r.ProjectCode}, {r.Task}, {r.Hours}, {r.HoursRounded}, {r.IsBillable}, {r.Invoiced}, {r.Approved}, {r.FirstName}, {r.LastName}, {r.Department}, {r.IsEmployee}, {r.BillableRate}, {r.CostRate}, {r.CostAmount}, {r.Currency}, {r.ExternalReferenceURL}");
                migrationBuilder.Sql(insertSQL.ToString());
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE TRUNCATE TABLE dbo.TimeSheets");
        }
    }
}
