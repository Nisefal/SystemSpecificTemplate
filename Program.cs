using System;

namespace SystemSpecificTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            var actionBase1 = ActionFactory.CreateAction(SystemType.SystemOne, "");
            actionBase1.Execute();

            var actionM1 = ActionFactory.CreateAction(SystemType.SystemOne, "M1");
            actionM1.Execute();
            
            var actionM2 = ActionFactory.CreateAction(SystemType.SystemOne, "M2");
            actionM2.Execute();

            var actionInvalid = ActionFactory.CreateAction(SystemType.SystemOne, "invalid_version");
            actionInvalid.Execute();

            var actionBase2 = ActionFactory.CreateAction(SystemType.SystemTwo, "");
            actionBase2.Execute();

            var actionBase3 = ActionFactory.CreateAction(SystemType.SystemThree, "");
            actionBase3.Execute();
        }
    }
}
