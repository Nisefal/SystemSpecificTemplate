using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSpecificTemplate.SystemThree
{
    [SystemType(SystemType.SystemThree)]
    [SystemVersion("")]
    [BaseClass]
    class SystemThreeActionBase : IAction
    {
        public void Execute()
        {
            SomeAction();
        }

        public virtual void SomeAction()
        {
            Console.WriteLine("Do something: Base 3");
        }
    }
}
