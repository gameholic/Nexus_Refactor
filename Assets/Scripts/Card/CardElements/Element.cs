using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GH.Nexus.GameCard.CardElements
{
    public enum ElementType
    {
        Art, Name, Descript, Ability, Mana, Attack, Defend, CardType, Region, Class
    }
    public abstract class Element : ScriptableObject
    {
        public ElementType type;
    }

    /// <summary>
    /// Below Elements are made for test purpose
    /// </summary>
    
}