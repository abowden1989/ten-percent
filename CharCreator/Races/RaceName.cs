using System;
using System.Collections.Generic;
using CharCreator.Classes;

namespace CharCreator.Races
{
    public enum RaceName
    {
        Dwarf,
        Elf,
        Human,
    }

    public static class AvailableRaces
    {
        public static Dictionary<RaceName, Type> RaceDictionary = new Dictionary<RaceName, Type>
        {
            {RaceName.Dwarf, typeof(Dwarf)},
            {RaceName.Elf, typeof(Elf)},
            {RaceName.Human, typeof(Human)},
        };

    }
}
