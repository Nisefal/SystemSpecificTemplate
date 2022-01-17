using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSpecificTemplate
{
    class SystemVersionAttribute : Attribute
    {
        public string Version { get; private set; }

        public SystemVersionAttribute(string version)
        {
            Version = version;
        }

        public bool CheckVersionCompatible(string version)
        {
            if (Version == "" || version == Version)
                return true;
            return false;
        }
    }
}
