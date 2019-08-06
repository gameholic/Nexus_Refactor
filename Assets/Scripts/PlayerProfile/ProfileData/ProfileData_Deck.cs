using UnityEngine;
using UnityEditor;
using GH.Nexus.GameCard;
using System;
using System.Collections.Generic;

[System.Serializable]
public class ProfileData_Deck 
{
    public string DeckListName ;
    public string[] Cards = new string[30];

    public static implicit operator ProfileData_Deck(Dictionary<CardDeck, string> v)
    {
        throw new NotImplementedException();
    }
}