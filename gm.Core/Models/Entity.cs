using System;

namespace gm.Core.Models
{
    public abstract class Entity
    {
        public Guid Uuid { get; protected set; }
        public int Id { get; protected set; }
    }
}
