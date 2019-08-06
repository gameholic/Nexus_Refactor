using UnityEngine;

using GH.Nexus.GameCard;


namespace GH.Nexus.Manager
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
