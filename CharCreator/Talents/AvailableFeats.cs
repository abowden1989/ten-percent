using System.Collections.Generic;

namespace CharCreator.Talents
{
    public enum FeatName
    {
        DwarvenResilience,
        Stonecunning,
    }

    class AvailableFeats
    {
        public static Dictionary<FeatName, string> ClassDictionary = new Dictionary<FeatName, string>
        {
            //The following are racial feats
            {FeatName.DwarvenResilience, "Advantage on saving throws vs poison; resistance vs poison damage."},
            {FeatName.Stonecunning, "Whenever you make a History check about stonework, add double your proficiency bonus."}
        };

    }
}
