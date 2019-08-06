using UnityEngine;
using System.Collections;
using GH.Nexus.GamePlayerHolder;
using GH.Nexus.GameCard;
using System.Collections.Generic;
using System.IO;


/// <summary>
/// Make New PlayerProfile
/// </summary>
public class TestPlayerProfile : MonoBehaviour
{
    private void Awake()
    {
        ProfileData_Deck[] tmpDeckLists = new ProfileData_Deck[5] ;
        System.Random rand = new System.Random();


        for(int i  =0;i< tmpDeckLists.Length; i++)
        {
            tmpDeckLists[i] = new ProfileData_Deck();
            tmpDeckLists[i].DeckListName = "DeckList " + i;
            for(int j=0;j< tmpDeckLists[i].Cards.Length; j++)
            {
                tmpDeckLists[i].Cards[j] = "Card " + rand.Next();
            }
        }

        PlayerProfile playerProfile = new PlayerProfile();
        playerProfile.name = "TestSucess";
        playerProfile.uniqueId = "Gameholic";
        playerProfile.deckList = tmpDeckLists;


        string json = JsonUtility.ToJson(playerProfile);
        using (FileStream fs = new FileStream("Assets/StreamingAssets/playerProfile.json", FileMode.Create))
        {
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(json);
                Debug.Log(json);
            }
        }
        UnityEditor.AssetDatabase.Refresh();
    }
}
