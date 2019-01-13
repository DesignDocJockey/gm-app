using gm.api.Core.Repository;
using gm.Core.Commands;
using gm.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace gm.Data
{
    public class TimesheetRepository : ITimesheetRepository
    {
        public CommandResponse CreateTimeSheet(ITimesheetCommand command)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Timesheet> GetAllTimeSheets()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Timesheet> GetTimeSheetByClientName(string clientName)
        {
            throw new NotImplementedException();
        }

        public Timesheet GetTimeSheetById(string timeSheetId)
        {
            throw new NotImplementedException();
        }

        public CommandResponse UpdateTimeSheet(ITimesheetCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
