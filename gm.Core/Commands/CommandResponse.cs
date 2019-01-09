using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gm.Core.Commands
{
    public class CommandResponse
    {
        public static CommandResponse Ok = new CommandResponse { Success = true };
        public static CommandResponse Fail = new CommandResponse { Success = false };

        public CommandResponse(Boolean success = false, int aggregateId = 0)
        {
            Success = success;
            Description = String.Empty;
        }

        public Boolean Success { get; private set; }
        public string Description { get; set; }
    }
}
