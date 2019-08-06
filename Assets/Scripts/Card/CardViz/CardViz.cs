#pragma warning disable CS0108

using UnityEngine;
using System.Collections;

using GH.Nexus.GameCard.Property;
using GH.Nexus.GameCard.CardElements;
namespace GH.Nexus.GameCard.Viz
{

    public class CardViz : MonoBehaviour
    {
        public Card originCard;

        #region SerializeField

        [SerializeField]
        private CardVizProperties[] properties;

        [SerializeField]
        private CardVizProperties cardType;

        #endregion

        #region GetSerializedVariable

        public string GetCardName
        {
            get { return name; }
        }
        #endregion
        //public void LoadCard(Card c)
        //{
        //    if (c == null)
        //        return;
        //    originCard = c;
        //    c.viz = this;
        //    cardType.text.text = c.cardType.ToString();
        //    for (int i = 0; i < c.property.Length; i++)
        //    {
        //        CardProperty cp = c.property[i];
        //        CardVizProperties p = GetProperty(cp.elementName);

        //        if (p == null)
        //            continue;
        //        if (cp.elementName is ElementInt)
        //        {
        //            p.text.text = cp.intValue.ToString();
        //            p.text.gameObject.SetActive(true);
        //        }
        //        else if (cp.elementName is ElementText)
        //        {
        //            p.text.text = cp.stringValue;
        //            p.text.gameObject.SetActive(true);
        //        }
        //        else if (cp.elementName is ElementImage)
        //        {
        //            p.renderer.sprite = cp.sprite;
        //            p.renderer.gameObject.SetActive(true);
        //        }
        //    }


        //}

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
