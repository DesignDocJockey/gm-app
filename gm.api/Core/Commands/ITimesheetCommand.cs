using gm.api.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gm.api.Core.Commands
{
    public interface ITimesheetCommand
    {
        Timesheet Timesheet { get; set; }
    }
}
