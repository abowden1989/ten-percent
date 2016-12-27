using System.Collections.Generic;
using CharCreator.Talents;

namespace CharCreator.Races
{
    public interface IRace
    {
        int RaceSpeed { get; }

        int StrBonus { get; }
        int DexBonus { get; }
        int ConBonus { get; }
        int IntBonus { get; }
        int WisBonus { get; }
        int ChaBonus { get; }

        VisionType Vision { get; }

        IEnumerable<FeatName> RacialFeats { get; }

        IEnumerable<WeaponProficiency> RacialWeaponProficiencies { get; }

    }
}
