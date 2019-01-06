using System;
using System.Collections.Generic;
using gm.api.Core.Commands;
using gm.api.Core.Models;
using gm.api.Core.Queries;
using System.Linq;
using System.Threading.Tasks;

namespace gm.api.Core.Repository
{
    public interface ITimesheetRepository
    {
        IEnumerable<Timesheet> GetAllTimeSheets();
        Timesheet GetTimeSheetById(string timeSheetId);
        IEnumerable<Timesheet> GetTimeSheetByClientId(string clientName);
        CommandResponse CreateTimeSheet(ITimesheetCommand command);
        CommandResponse UpdateTimeSheet(ITimesheetCommand command);
    }
}
