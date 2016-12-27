using System.Collections.Generic;

namespace CharCreator.Feats
{
    public enum FeatName
    {
        DwarvenResilience,
    }

    class AvailableFeats
    {
        public static Dictionary<FeatName, string> ClassDictionary = new Dictionary<FeatName, string>
        {
            {FeatName.DwarvenResilience, "Advantage on saving throws vs poison; resistance vs poison damage."},
        };

    }
}
