using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSpecificTemplate
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    class BaseClassAttribute: Attribute
    {
        public BaseClassAttribute()
        {
        }
    }
}
