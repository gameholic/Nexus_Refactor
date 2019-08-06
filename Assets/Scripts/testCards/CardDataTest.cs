using GH.Nexus.GameCard;
using UnityEngine;

namespace GH.Nexus.Test

{
    [System.Serializable]
    public class CardDataTest
    {
 
        public string name;
        public string description;
        public string ability;
        public int mana;
        public int attack;  
        public int defend;
        public CardType cardType;

        public testProperty[] propertyTest;

        public int dataLength;
    }

}