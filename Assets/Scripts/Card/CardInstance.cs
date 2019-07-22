using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GH.Sample.GameCard
{
    public class CardInstance : MonoBehaviour
    {
        public Card originCard;

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
