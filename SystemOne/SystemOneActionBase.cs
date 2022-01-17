using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSpecificTemplate.SystemOne
{
    [SystemType(SystemType.SystemOne)]
    [SystemVersion("")]
    [BaseClass]
    class SystemOneActionBase : IAction
    {
        public void Execute()
        {
            SomeAction();
        }

        public virtual void SomeAction()
        {
            Console.WriteLine("Do something: Base 1");

        }
    }
}
