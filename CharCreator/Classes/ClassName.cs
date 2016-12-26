using System;
using System.Collections.Generic;

namespace CharCreator.Classes
{
    public enum ClassName
    {
        Fighter,
        Wizard
    }

    public static class AvailableClasses
    {
        public static Dictionary<ClassName, Type> ClassDictionary = new Dictionary<ClassName, Type>
        {
            {ClassName.Fighter, typeof(Fighter)},
            {ClassName.Wizard, typeof(Wizard) }
        };

    }
}
