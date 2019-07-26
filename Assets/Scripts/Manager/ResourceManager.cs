using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GH.Sample.GameCard;

namespace GH.Sample.Manager
{
    [CreateAssetMenu]
    public class ResourceManager : ScriptableObject
    {
        [SerializeField]
        private Card[] _AllCards;
        private Dictionary<string, Card> _CardDict = new Dictionary<string, Card>();

        public Dictionary<string, Card> cardDict { get { return _CardDict; } }

        public void Init()
        {
            cardDict.Clear();
            for (int i = 0; i < _AllCards.Length; i++)
            {
                cardDict.Add(_AllCards[i].name, _AllCards[i]);
            }
        }

        private Card GetCardOrigin(string id)
        {
            Card card = null;
            cardDict.TryGetValue(id, out card);
            return card;
        }

        public Card GetCardAsInstance(string id)
        {
            Card originalCard = Instantiate(GetCardOrigin(id));
            originalCard.name = id;
            return originalCard;

        }
    }
}