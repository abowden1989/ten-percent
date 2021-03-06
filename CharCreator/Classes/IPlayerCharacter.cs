﻿using System.Collections.Generic;
using CharCreator.Races;
using CharCreator.Talents;

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

        int Hitpoints();
 
        int Speed { get; }

        VisionType Vision { get; }

        IEnumerable<FeatName> Feats();

        IEnumerable<WeaponProficiency> WeaponProficiencies();

        IEnumerable<ArmorProficiency> ArmorProficiencies();
        
        IEnumerable<Language> Languages();

        void SetAttributes(int[] attributeArray);
    }
}