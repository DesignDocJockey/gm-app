using System;
using System.Collections.Generic;
using System.Text;
using gm.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace gm.Data
{
    public class TimeSheetDBContext : DbContext
    {
        public DbSet<TimesheetDataModel> TimeSheets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=TimeSheetData;Trusted_Connection=True;");
        }
    }
}
