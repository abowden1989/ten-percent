namespace CharCreator
{
    public interface IPlayerCharacter
    {
        string Class { get; }

        string PlayerName { get; set; }

        int Strength { get; set; }
        int Dexterity { get; set; }
        int Constitution { get; set; }
        int Intelligence { get; set; }
        int Wisdom { get; set; }
        int Charisma { get; set; }

        void SetAttributes(int[] attributeArray);
    }
}