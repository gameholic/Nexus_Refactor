using UnityEngine;
using UnityEditor;

using GH.Sample.GameCard;
namespace GH.Sample.Manager
{
    public class PositionHandler : ScriptableObject
    {
        /// <summary>
        /// Move Target To Dest
        /// </summary>
        /// <param name="target"></param>
        /// <param name="dest"></param>
        public void MoveCard(Transform target, Transform dest)
        {

        }
        /// <summary>
        /// Move Card To Field
        /// </summary>
        public void MoveCard(CreatureCard target, Transform fieldTransform)
        {

        }
        /// <summary>
        /// Move Card To Attack
        /// </summary>
        public void MoveCard(Card attackingCard, Transform battleLine)
        {
            
        }
        /// <summary>
        /// Move Card To Defend
        /// </summary>
        public void MoveCard(Transform defCard, Transform atkCard, Transform defendLine, Vector3 blockPosition)
        {

        }

    }

}