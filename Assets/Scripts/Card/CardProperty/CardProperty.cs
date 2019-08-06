using UnityEngine;
using UnityEditor;

using GH.Nexus.GameCard.CardElements;
namespace GH.Nexus.GameCard.Property
{
    [System.Serializable]
    public class CardProperty
    {        
        private string stringValue;
        private int intValue;
        private Sprite sprite;

        public string StringValue
        {
            set { stringValue = value; }
            get { return stringValue; }
        }
        public int IntValue
        {
            set { intValue = value; }
            get { return intValue; }
        }
        public Sprite SpriteValue
        {
            set { sprite = value; }
            get { return sprite; }
        }
        public ElementType elementType;

    }

}