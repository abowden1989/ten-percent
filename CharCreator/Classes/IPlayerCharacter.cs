using CharCreator.Races;

namespace CharCreator.Classes
{
    public interface IPlayerCharacter
    {
        ClassName Class { get; }

        RaceName Race { get; set; }

        string PlayerName { get; set; }

        int Strength { get; set; }
        int Dexterity { get; set; }
        int Constitution { get; set; }
        int Intelligence { get; set; }
        int Wisdom { get; set; }
        int Charisma { get; set; }

        int Speed { get; }

        void SetAttributes(int[] attributeArray);
    }
}