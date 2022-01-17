using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSpecificTemplate
{
    class SystemTypeAttribute : Attribute
    {
        public SystemType Type { get; private set; }
        public SystemTypeAttribute(SystemType type)
        {
            Type = type;
        }

        public bool SystemTypeSame(SystemType type)
        {
            return Type == type;
        }
    }
}
