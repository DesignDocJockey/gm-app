using System;
using System.Collections.Generic;
using gm.api.Core.Commands;
using gm.api.Core.Models;
using System.Linq;
using System.Threading.Tasks;

namespace gm.api.Core.Repository
{
    public interface ITimesheetRepository
    {
        IEnumerable<Timesheet> GetAllTimeSheets();
        Timesheet GetTimeSheetById(string timeSheetId);
        IEnumerable<Timesheet> GetTimeSheetByClientName(string clientName);
        CommandResponse CreateTimeSheet(ITimesheetCommand command);
        CommandResponse UpdateTimeSheet(ITimesheetCommand command);
    }
}
