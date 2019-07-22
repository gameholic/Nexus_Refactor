using UnityEngine;

using GH.Sample.GameCard;


namespace GH.Sample.Manager
{
    public class TestManager : MonoBehaviour
    {
        public Card targetCard;
        private void Start()
        {
            targetCard = Instantiate(targetCard);
            targetCard.InitCard();

        }


    }

}
