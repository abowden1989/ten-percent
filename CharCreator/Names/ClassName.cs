using System;
using System.Collections.Generic;
using CharCreator.Classes;

namespace CharCreator.Names
{
    public enum ClassName
    {
        Fighter,
        Wizard
    }

    public static class AvailableClasses
    {
        public static Dictionary<string, Type> ClassDictionary = new Dictionary<string, Type>
        {
            {"Fighter", typeof(Fighter)},
            {"Wizard", typeof(Wizard) }
        };

    }

}
