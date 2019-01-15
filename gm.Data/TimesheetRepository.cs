using gm.api.Core.Repository;
using gm.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using gm.Core.Models;

namespace gm.Data
{
    public class TimesheetRepository : ITimesheetRepository
    {
        private readonly TimeSheetDBContext _TimeSheetDbCtx;

        public TimesheetRepository(TimeSheetDBContext ctx) {
            _TimeSheetDbCtx = ctx;
        }

        public CommandResponse CreateTimeSheet(ITimesheetCommand command)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TimesheetDataModel> GetAllTimeSheets() => _TimeSheetDbCtx.TimeSheets.ToList();

        public IEnumerable<TimesheetDataModel> GetTimeSheetByClientName(string clientName)
        {
            throw new NotImplementedException();
        }

        public TimesheetDataModel GetTimeSheetById(string timeSheetUuid) => _TimeSheetDbCtx.TimeSheets.FirstOrDefault(i => i.Uuid.ToString().ToLower().Equals(timeSheetUuid.ToLower()));
        

        public CommandResponse UpdateTimeSheet(ITimesheetCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
