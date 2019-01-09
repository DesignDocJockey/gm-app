using System;
using System.Collections.Generic;
using gm.Core.Commands;
using gm.Core.Models;
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
