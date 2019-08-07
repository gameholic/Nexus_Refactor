using UnityEngine;
using UnityEditor;
using GH.Nexus.Test;
public class CardEditor : EditorWindow
{
    Vector2 scrollPos;
    string cardName;

    [MenuItem("Editor/Card Editor")]
    static void Init()
    {
        //create new 'GameDataEditor' window using 'EditorWindow' 
        CardEditor window = (CardEditor)EditorWindow.GetWindow(typeof(CardEditor), true, "CardEditor");
        window.Show();
    }
    private void OnGUI()
    {
        EditorGUILayout.BeginHorizontal();
        scrollPos = EditorGUILayout.BeginScrollView(scrollPos);


        GUILayout.Label("Type the card you are trying to search");
        //cardName = EditorGUILayout.TextField("CardName");
        cardName = GUILayout.TextField(cardName);


        if (GUILayout.Button("Search"))
        {
            SearchCard(cardName);
        }

        EditorGUILayout.EndScrollView();
    }
    private void SearchCard(string str)
    {
        Debug.Log(str);

        CardTest c = Resources.Load<CardTest>("Card/"+str);
        if (c != null)
            Debug.Log(c);

    }
}