using System.Collections.Generic;

using UnityEngine;

using GH.Sample.GameCard;
using GH.Sample.Manager;

namespace GH.Sample.GamePlayerHolder
{
    public class PlayerCardData:PlayerHolder
    {
        private List<Card> _CardOnHand = new List<Card>();
        private List<Card> _CardOnField = new List<Card>();
        private List<Card> _AttackingCard = new List<Card>();
        private List<Card> _DeadCard = new List<Card>();

        public void Init(PlayerHolder p)
        {
            cardData = p.cardData;
            cardZone = p.cardZone;
        }
        private PositionHandler position = new PositionHandler();
        public void AddCardOnHand(Card targetCard)
        {
            _CardOnHand.Add(targetCard);
            targetCard.instance.transform.SetParent(cardZone.handZone);
        }
        public void MoveCardToField(CreatureCard targetCard, int fieldIndex)
        {
            _CardOnHand.Remove(targetCard);
            _CardOnField.Add(targetCard);
            targetCard.setFieldIndex(fieldIndex);
            position.MoveCard(targetCard.instance.transform, cardZone.fieldZone(fieldIndex).transform);
            //SetParent to Fieldzone and move card
        }
        /// <summary>
        /// Move card to attack position
        /// </summary>
        /// <param name="targetCard"></param>
        public void MoveCardToAttack(Card targetCard, Transform t)
        {
            _AttackingCard.Add(targetCard);
            _CardOnField.Remove(targetCard);

        }
    }

}