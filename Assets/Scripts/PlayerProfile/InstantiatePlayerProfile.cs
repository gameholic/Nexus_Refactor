using UnityEngine;
using UnityEditor;
using GH.Nexus.GamePlayerHolder;

public class InstantiatePlayerProfile:MonoBehaviour
{
    private static PlayerProfile playerProfile;
    private void Awake()
    {
        if(playerProfile == null)
        {
            //playerProfile = Resources.Load("PlayerProfile") as PlayerProfile;
            //Debug.Log("Loading PlayerProfile through Resources success");
        }
        
    }
}