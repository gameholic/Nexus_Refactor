using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace GH.Nexus.GameCard.Viz
{
    [System.Serializable]
    public class CardVizProperties
    {
        public TextMesh text;
        public SpriteRenderer renderer;
        public CardElements.Element element;
    }

}
