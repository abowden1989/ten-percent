using System;
using System.Collections.Generic;

namespace CharCreator.Races
{
    public enum RaceName
    {
        HillDwarf,
        MountainDwarf,
        Elf,
        Human,
    }

    public static class AvailableRaces
    {
        public static Dictionary<RaceName, Type> RaceDictionary = new Dictionary<RaceName, Type>
        {
            {RaceName.HillDwarf, typeof(HillDwarf)},
            {RaceName.MountainDwarf, typeof(MountainDwarf)},
            {RaceName.Elf, typeof(Elf)},
            {RaceName.Human, typeof(Human)},
        };

    }
}
