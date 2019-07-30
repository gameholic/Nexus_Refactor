using UnityEngine;

using GH.Nexus.GameCard.Ability;

namespace GH.Nexus.GameCard
{
    [CreateAssetMenu(menuName ="Cards/CreatureCard")]
    public class CreatureCard : Card
    {
        #region Serialized

        public CardAbility cardAbility;

        #endregion

        #region Properties



        #endregion

        private int fieldIndex;
        public void setFieldIndex(int index)
        {
            fieldIndex = index;
        }
       
        private void Awake()
        {
            //_CardType.stringValue = CardType.Creature.ToString();
            //Debug.Log(_CardType.stringValue);
        }

        public override bool CanDropCard()
        {
            /// TODO: Check Player Condition
            /// 1: Player is at 'PlayerControlState'
            /// 2: Player have enough mana remaining.
            /// 3: Is there any condition to fulfill for this card

            return false;

        }

        public override bool CanUseCard()
        {
            /// TODO: Check The Card is Tapped or not. This is determined by conditions
            /// 1: Card can't attack as soon as it is placed on field
            /// 2: Card can't attack twice at same turn
            /// 3. Card can't attack if it is locked by other card's ability.
            return true;
        }


        public override bool UseCard()
        {
            /// TODO: Put creature to attack state.
            /// 1: Move creature card to battle line
            /// 2: Add card on 'attackingCards' list of playerholder
            return true;
        }
    }


}