using UnityEngine;
using System.Collections;


namespace GH.Sample.GameCard
{
    public class CardDeck
    {
        private readonly int _MaxNumber = 30;
        private Card[] _CardDeck;

        public Card[] _Deck
        {
            get
            {
                if(_CardDeck ==null)
                {
                    _CardDeck = new Card[30];
                }
                return _CardDeck;
            }
        }

    }


}