using System;
using SystemSpecificTemplate;

namespace SystemSpecificTemplate.SystemTwo
{
    [SystemType(SystemType.SystemTwo)]
    [SystemVersion("")]
    [BaseClass]
    class SystemTwoActionBase : IAction
    {
        public void Execute()
        {
            SomeAction();
        }

        public virtual void SomeAction()
        {
            Console.WriteLine("Do something: Base 2");
        }
    }
}
