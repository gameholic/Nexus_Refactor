#pragma warning disable CS0108

using UnityEngine;
using System.Collections;

using GH.Nexus.GameCard.Property;
using GH.Nexus.GameCard.CardElements;
using GH.Nexus.GameCard.Viz;

using GH.Nexus.GameCard;

namespace GH.Nexus.Test
{

    public class CardVizTest : MonoBehaviour
    {
        public CardTest originCard;

        #region SerializeField

        public CardVizProperties[] properties;

        [SerializeField]
        private CardVizProperties cardType;

        #endregion

        #region GetSerializedVariable

        public string GetCardName
        {
            get { return name; }
        }
        #endregion
        public void LoadCard(CardTest c)
        {
            if (c == null)
                return;
            originCard = c;
            c.viz = this;
            cardType.text.text = c.data[0].cardType.ToString();
            CardDataTest data = c.data[0];
            for (int i = 0; i < properties.Length; i++)
            {
                CardVizProperties p = properties[i];
                
                if (p == null)
                    continue;
                ApplyText(p, data);

            }
        }

        public void ApplyText(CardVizProperties p, CardDataTest data)
        {
            ElementType e = p.element.type;
            switch (e)
            {
                case ElementType.Art:
                    p.renderer.sprite = data.art;
                    p.renderer.gameObject.SetActive(true);
                    break;
                case ElementType.Name:
                    p.text.text = data.name;
                    break;
                case ElementType.Descript:
                    p.text.text = data.description;
                    break;
                case ElementType.Ability:
                    p.text.text = data.ability;
                    break;
                case ElementType.Mana:
                    p.text.text = data.mana.ToString();
                    break;
                case ElementType.Attack:
                    p.text.text = data.attack.ToString();
                    break;
                case ElementType.Defend:
                    p.text.text = data.defend.ToString();
                    break;
                case ElementType.CardType:
                    p.text.text = data.cardType.ToString();
                    break;
                case ElementType.Region:
                    p.text.text = data.region;
                    break;
                case ElementType.Class:
                    p.text.text = data._class;
                    break;

                default:
                    break;
            }
            if (e != ElementType.Art)
                p.text.gameObject.SetActive(true);
        }

        public void DisableCard()
        {
            foreach (CardVizProperties p in properties)
            {
                if (p.renderer != null)
                    p.renderer.gameObject.SetActive(false);
                if (p.text != null)
                    p.text.gameObject.SetActive(false);

            }
        }
        /// <summary>
        /// Find VizProperty that is using same element with Card Property
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public CardVizProperties GetProperty(Element e)
        {
            CardVizProperties result = null;

            for (int i = 0; i < properties.Length; i++)
            {
                if (properties[i].element == e)
                {
                    result = properties[i];
                    break;
                }
            }
            return result;
        }
    }
}
#pragma warning restore CS0108
