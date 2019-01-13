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
        IEnumerable<TimesheetDataModel> GetAllTimeSheets();
        TimesheetDataModel GetTimeSheetById(string timeSheetId);
        IEnumerable<TimesheetDataModel> GetTimeSheetByClientName(string clientName);
        CommandResponse CreateTimeSheet(ITimesheetCommand command);
        CommandResponse UpdateTimeSheet(ITimesheetCommand command);
    }
}
