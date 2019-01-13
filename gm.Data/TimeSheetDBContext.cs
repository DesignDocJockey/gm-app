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
        private string _ConnectionString;

        public TimeSheetDBContext(DbContextOptions<TimeSheetDBContext> options)
            :base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<TimesheetDataModel>()
            //    .Property(p => p.Id)
            //    .ValueGeneratedOnAdd();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        //{
        //    dbContextOptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TimeSheetData;Trusted_Connection=True;");
        //}
    }
}
