using System.Collections.Generic;
using CharCreator.Talents;

namespace CharCreator.Races
{
    public class Elf : IRace
    {
        public int RaceSpeed => 6;

        public int StrBonus => 0;
        public int DexBonus => 0;
        public int ConBonus => 0;
        public int IntBonus => 0;
        public int WisBonus => 0;
        public int ChaBonus => 0;

        public VisionType Vision => VisionType.Darkvision;

        public IEnumerable<FeatName> RacialFeats => new List<FeatName> {};

        public IEnumerable<WeaponProficiency> RacialWeaponProficiencies => new List<WeaponProficiency> {};

        public IEnumerable<Language> RacialLanguages => new List<Language> {};
    }
}
