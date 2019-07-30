using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using GH.Nexus.GameCard;

namespace GH.Nexus.GamePlayerHolder
{
    [CreateAssetMenu(menuName ="PlayerData/PlayerHolder")]
    public class PlayerHolder : ScriptableObject
    {

        public string playerId;
        [SerializeField]
        private PlayerCardZone _CardZone;
        /// I think startingCards is not needed as List, but as function.
        ///Card deck is better be dictionary with integer and string (Card name).
        ///Integer is to pick new card from deck randomly.
        private Dictionary<int, Card> _CardDeck = new Dictionary<int, Card>();
        private PlayerCardData _CardData = new PlayerCardData();
        private PlayerProfile profile = new PlayerProfile();
        public Dictionary<int, Card> cardDeck
        {
            get { return _CardDeck; }
        }
        public PlayerCardData cardData
        {
            set { _CardData = value; }
            get { return _CardData; }
        }

        public PlayerCardZone cardZone
        {

            set { _CardZone = value; }
            get { return _CardZone; }
        }


        public void Init()
        {
            cardData.Init(this);
            playerId = profile.playerId;
        }
        public string PickNewCardFromDeck()
        {
            System.Random rand = new System.Random();
            Card tmp = null;
            string newCardName = null;
            int deckSize = _CardDeck.Count;
            int cardId = rand.Next(0, deckSize);

            if(deckSize==0)
            {
                Debug.LogWarningFormat("PickNewCardFromDeck: {0} don't have card in deck anymore.", playerId);
                return null;
            }

            _CardDeck.TryGetValue(cardId, out tmp);
            //newCardName = tmp.cardName.stringValue;
            _CardDeck.Remove(cardId);


            if (_CardDeck.ContainsKey(cardId))
            {
                Debug.LogWarning("Picked Card Isn't removed from list");
            }
            return newCardName;
        }
    }

}
