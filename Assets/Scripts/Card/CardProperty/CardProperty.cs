using UnityEngine;
using UnityEditor;

namespace GH.Nexus.GameCard.Property
{
    [System.Serializable]
    public class CardProperty
    {
        public CardElements.Element elementName;

        public int intValue;
        public string stringValue;
        public Sprite sprite;
    }

}