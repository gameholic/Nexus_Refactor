using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GH.Sample.GameCard
{
    public class CardPhysicalInstance : MonoBehaviour
    {
        private Card _OriginCard;

        public Card originCard
        {
            set
            {
                _OriginCard = value;
                _OriginCard.instance = this;
            }
            get
            {
                return _OriginCard;
            }
        }

        public void Highlight()
        {
            transform.localScale = new Vector3(1.5f, 1.7f, 0.01f);
        }
        
        public void DeHighlight()
        {
            transform.localScale = new Vector3(1f, 1.5f, 0.01f);
        }

    }
}
