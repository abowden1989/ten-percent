using System;
using System.Collections.Generic;
using CharCreator.Feats;
using CharCreator.Races;

namespace CharCreator.Classes
{
    public abstract class PlayerCharacter : IPlayerCharacter
    {
        public ClassName Class { get; set; }
        public RaceName Race { get; set; }

        public string PlayerName { get; set; }

        internal int BaseStr;
        internal int BaseDex;
        internal int BaseCon;
        internal int BaseInt;
        internal int BaseWis;
        internal int BaseCha;

        public int Strength()
        {
            return BaseStr + GetRaceInstance().StrBonus;
        }

        public int Dexterity()
        {
            return BaseDex + GetRaceInstance().DexBonus;
        }

        public int Constitution()
        {
            return BaseCon + GetRaceInstance().ConBonus;
        }

        public int Intelligence()
        {
            return BaseInt + GetRaceInstance().IntBonus;
        }

        public int Wisdom()
        {
            return BaseWis + GetRaceInstance().WisBonus;
        }

        public int Charisma()
        {
            return BaseCha + GetRaceInstance().ChaBonus;
        }

        public int Speed => GetRaceInstance().RaceSpeed;
        public VisionType Vision => GetRaceInstance().Vision;

        public IEnumerable<FeatName> Feats()
        {
            return GetRaceInstance().RacialFeats;
        }

        public void SetAttributes(int[] attributeArray)
        {
            if (attributeArray.Length != 6)
            {
                throw new ArgumentException("Wrong number of parameters");
            }

            BaseStr = attributeArray[0];
            BaseDex = attributeArray[1];
            BaseCon = attributeArray[2];
            BaseInt = attributeArray[3];
            BaseWis = attributeArray[4];
            BaseCha = attributeArray[5];
        }

        public IRace GetRaceInstance()
        {
            return (IRace)Activator.CreateInstance(AvailableRaces.RaceDictionary[Race]); //TODO: wtf is the right way to do this?
        }
    }
}
