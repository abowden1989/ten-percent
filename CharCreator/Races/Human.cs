﻿using System.Collections.Generic;
using CharCreator.Feats;

namespace CharCreator.Races
{
    public class Human : IRace
    {
        public int RaceSpeed => 6;

        public int StrBonus => 0;
        public int DexBonus => 0;
        public int ConBonus => 0;
        public int IntBonus => 0;
        public int WisBonus => 0;
        public int ChaBonus => 0;

        public VisionType Vision => VisionType.Normal;
        public IEnumerable<FeatName> RacialFeats => new List<FeatName> {};
    }
}
