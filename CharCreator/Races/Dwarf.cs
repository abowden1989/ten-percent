﻿using System.Collections.Generic;
using CharCreator.Talents;

namespace CharCreator.Races
{
    internal class Dwarf : IRace
    {
        public int RaceSpeed => 5;

        public int StrBonus => 0;
        public int DexBonus => 0;
        public int ConBonus => 0;
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

        public IEnumerable<Language> RacialLanguages => new List<Language>
        {
            Language.Common,
            Language.Dwarvish
        };


    }
}
