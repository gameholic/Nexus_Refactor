using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

using GH.Nexus.GameCard;


namespace GH.Nexus.GamePlayerHolder
{
    [System.Serializable]
    public class PlayerProfile 
    {
        [SerializeField]
        public string uniqueId;
        [SerializeField]
        public string name;
        [SerializeField]
        private Sprite playerAvatar;
        [SerializeField]
        public ProfileData_Deck[] deckList;
       

    }

}