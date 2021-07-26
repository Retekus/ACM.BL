using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    } 
    public abstract class EntityBase
    {

        public EntityStateOption entityState { get; set; }
        public bool hasChanges { get; set; }
        public bool isNew { get; private set; }
        public bool isValid => Validate();

        public abstract bool Validate();
    }
}
