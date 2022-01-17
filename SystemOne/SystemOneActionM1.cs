using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSpecificTemplate.SystemOne
{
    [SystemVersion("M1")]
    class SystemOneActionM1: SystemOneActionBase
    {
        public override void SomeAction()
        {
            Console.WriteLine("Do something: M1");
        }
    }
}
