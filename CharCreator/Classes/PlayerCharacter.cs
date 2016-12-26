using System;
using System.Collections;
using CharCreator.Races;

namespace CharCreator.Classes
{
    public abstract class PlayerCharacter : IPlayerCharacter
    {
        public ClassName Class { get; set; }
        public RaceName Race { get; set; }

        public string PlayerName { get; set; }

        public int Strength { get; set; } = 10;
        public int Dexterity { get; set; } = 10;
        public int Constitution { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public int Wisdom { get; set; } = 10;
        public int Charisma { get; set; } = 10;

        public int Speed
        {
            get
            {
                var race = (IRace) Activator.CreateInstance(AvailableRaces.RaceDictionary[Race]); //TODO: wtf is the right way to do this?
                return race.RaceSpeed;
            }
        }

        public void SetAttributes(int[] attributeArray)
        {
            if (attributeArray.Length != 6)
            {
                throw new System.ArgumentException("Wrong number of parameters");
            }

            Strength = attributeArray[0];
            Dexterity = attributeArray[1];
            Constitution = attributeArray[2];
            Intelligence = attributeArray[3];
            Wisdom = attributeArray[4];
            Charisma = attributeArray[5];
        }
    }
}
