using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSpecificTemplate
{
    static class ActionFactory
    {
        public static IAction CreateAction(SystemType type, string version)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            object requiredType = null;
            foreach (var actionType in types)
            {
                SystemTypeAttribute typeAttribute = (SystemTypeAttribute)actionType.GetCustomAttribute(typeof(SystemTypeAttribute));
                SystemVersionAttribute versionAttribute = (SystemVersionAttribute)actionType.GetCustomAttribute(typeof(SystemVersionAttribute));
                BaseClassAttribute baseClassAttribute = (BaseClassAttribute)actionType.GetCustomAttribute(typeof(BaseClassAttribute));

                // Check if version and type valid
                if (typeAttribute != null && typeAttribute.SystemTypeSame(type) && versionAttribute != null && versionAttribute.CheckVersionCompatible(version) /* && check1 && check2*/)
                {
                    // Set required class type base if valid has not been set yet
                    // else set required class type
                    if (baseClassAttribute != null)
                        requiredType ??= actionType;
                    else
                        requiredType = actionType;
                }
            }
            return (IAction)Activator.CreateInstance((Type)requiredType);
        }
    }

    public enum SystemType
    {
        SystemOne,
        SystemTwo,
        SystemThree
    }
}
