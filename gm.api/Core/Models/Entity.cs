using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gm.api.Core.Models
{
    public abstract class Entity
    {
        public Guid Uuid { get; protected set; }
        public int Id { get; protected set; }
    }
}
