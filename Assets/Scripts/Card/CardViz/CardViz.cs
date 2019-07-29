#pragma warning disable CS0108

using UnityEngine;
using System.Collections;


namespace GH.Sample.GameCard.Viz
{

    public class CardViz : MonoBehaviour
    {
        public Card originCard;

        #region SerializeField

        [SerializeField]
        private CardVizProperties[] properties;
        

        #endregion

        #region GetSerializedVariable

        public string GetCardName
        {
            get { return name; }
        }
        #endregion
        public void LoadCard(Card c)
        {

        }

        public void DisableCard()
        {

        }

    }

}
#pragma warning restore CS0108
