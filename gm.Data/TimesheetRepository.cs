using gm.api.Core.Repository;
using gm.Core.Commands;
using gm.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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

        public IEnumerable<TimesheetDataModel> GetAllTimeSheets()
        {
            return _TimeSheetDbCtx.TimeSheets;
        }

        public IEnumerable<TimesheetDataModel> GetTimeSheetByClientName(string clientName)
        {
            throw new NotImplementedException();
        }

        public TimesheetDataModel GetTimeSheetById(string timeSheetId)
        {
            throw new NotImplementedException();
        }

        public CommandResponse UpdateTimeSheet(ITimesheetCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
