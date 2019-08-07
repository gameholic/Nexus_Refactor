using UnityEngine;

using GH.Nexus.GameCard;
using GH.Nexus.Test;

namespace GH.Nexus.Manager
{
    public class TestManager : MonoBehaviour
    {
        public CardTest targetCard;
        [SerializeField]
        private GameObject _CardPrefab;
        private void Start()
        {
            //targetCard = Instantiate(targetCard);
            //targetCard.InitCard();
        }
        public void LoadCard()
        {
            GameObject go = Instantiate(_CardPrefab) as GameObject;
            CardVizTest v = go.GetComponent<CardVizTest>();
            if(v!=null)
            {
                v.LoadCard(targetCard);
                go.transform.localPosition = Vector3.zero;
                go.transform.localScale = new Vector3(0.4f, 0.5f, 0.5f);

            }
        }
    }
}
