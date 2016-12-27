using System.Collections.Generic;
using CharCreator.Feats;
using CharCreator.Races;

namespace CharCreator.Classes
{
    public interface IPlayerCharacter
    {
        ClassName Class { get; }

        RaceName Race { get; set; }

        string PlayerName { get; set; }

        int Strength();
        int Dexterity();
        int Constitution();
        int Intelligence();
        int Wisdom();
        int Charisma();
 
        int Speed { get; }
        VisionType Vision { get; }

        IEnumerable<FeatName> Feats();

        void SetAttributes(int[] attributeArray);
    }
}