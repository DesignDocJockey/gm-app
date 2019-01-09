using gm.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gm.Core.Commands
{
    public interface ITimesheetCommand
    {
        Timesheet Timesheet { get; set; }
    }
}
