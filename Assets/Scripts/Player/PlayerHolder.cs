using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using GH.Sample.GameCard;

namespace GH.Sample.GamePlayerHolder
{
    [CreateAssetMenu(menuName ="PlayerData/PlayerHolder")]
    public class PlayerHolder : ScriptableObject
    {
        public string playerId;

        [SerializeField]
        private CardZone _CardZone;
        /// I think startingCards is not needed as List, but as function.
        ///Card deck is better be dictionary with integer and string (Card name).
        ///Integer is to pick new card from deck randomly.
        private Dictionary<int, string> _CardDeck = new Dictionary<int, string>();
        private PlayerCardData _CardData = new PlayerCardData();
        

        public PlayerCardData cardData
        {
            set { _CardData = value; }
            get { return _CardData; }
        }

        public CardZone cardZone
        {

            set { _CardZone = value; }
            get { return _CardZone; }
        }


        public void Init()
        {
            cardData.Init(this);
        }
        public string PickNewCardFromDeck()
        {
            System.Random rand = new System.Random();
            string newCardName = null;
            int deckSize = _CardDeck.Count;
            int cardId = rand.Next(0, deckSize);

            if(deckSize==0)
            {
                Debug.LogWarningFormat("PickNewCardFromDeck: {0} don't have card in deck anymore.", playerId);
                return null;
            }

            _CardDeck.TryGetValue(cardId, out newCardName);
            _CardDeck.Remove(cardId);


            if (_CardDeck.ContainsKey(cardId))
            {
                Debug.LogWarning("Picked Card Isn't removed from list");
            }
            return newCardName;
        }
    }

}
