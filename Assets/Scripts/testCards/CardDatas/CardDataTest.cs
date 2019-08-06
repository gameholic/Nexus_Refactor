using GH.Nexus.GameCard;
using UnityEngine;

using GH.Nexus.GameCard.Property;

namespace GH.Nexus.Test

{
    [System.Serializable]
    public class CardDataTest
    { 
        public string name;
        public string description;
        public string ability;
        public string region;
        public string _class;

        public int mana;
        public int attack;  
        public int defend;
        public CardType cardType;
        public Sprite art;
    }

}

