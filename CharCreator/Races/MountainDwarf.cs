using System.Collections.Generic;
using CharCreator.Talents;

namespace CharCreator.Races
{
    internal class MountainDwarf : IRace
    {
        public int RaceSpeed => 5;

        public int StrBonus => 2;
        public int DexBonus => 0;
        public int ConBonus => 2;
        public int IntBonus => 0;
        public int WisBonus => 0;
        public int ChaBonus => 0;

        public VisionType Vision => VisionType.Darkvision;

        public IEnumerable<FeatName> RacialFeats => new List<FeatName> {FeatName.DwarvenResilience};

        public IEnumerable<WeaponProficiency> RacialWeaponProficiencies => new List<WeaponProficiency>
        {
            WeaponProficiency.BattleAxe,
            WeaponProficiency.HandAxe,
            WeaponProficiency.ThrowingHammer,
            WeaponProficiency.WarHammer,
        };

        public IEnumerable<ArmorProficiency> RacialArmorProficiencies => new List<ArmorProficiency>
        {
            ArmorProficiency.Light,
            ArmorProficiency.Medium,
        };

        public IEnumerable<Language> RacialLanguages => new List<Language>
        {
            Language.Common,
            Language.Dwarvish
        };


    }
}
