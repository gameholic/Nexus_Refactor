using UnityEngine;
using UnityEditor;
using GH.Nexus.Test;
public class CardEditor : EditorWindow
{
    Vector2 scrollPos;
    string cardName;
    //public CardMirror targetCard =new CardMirror();
    public CardDataTest cardData =null;
    public CardTest currentCard;
    private bool addingMode = false;
    [MenuItem("Editor/Card Editor")]
    static void Init()
    {
        //create new 'GameDataEditor' window using 'EditorWindow' 
        CardEditor window = (CardEditor)EditorWindow.GetWindow(typeof(CardEditor), true, "CardEditor");
        window.Show();
    }
    private void OnGUI()
    {
        Event e = Event.current;
        EditorGUILayout.BeginHorizontal();
        scrollPos = EditorGUILayout.BeginScrollView(scrollPos);

        GUILayout.Label("Type the card you are trying to search");
        cardName = EditorGUILayout.TextField(cardName);
        SerializedObject serializedObject = new SerializedObject(this);

        if (cardData != null)
        {
            SerializedProperty serializedProperty = serializedObject.FindProperty("cardData");

            EditorGUILayout.PropertyField(serializedProperty, true);
            serializedObject.ApplyModifiedProperties();
        }

        Debug.Log(addingMode);
        if (GUILayout.Button("Search") || e.keyCode == KeyCode.Return)
        {
            SearchCard(cardName);
        }

        if (GUILayout.Button("ClearData"))
        {
            ClearCard();
        }

        if (!addingMode)
        {
            if (GUILayout.Button("DeleteCard"))
            {
                DeleteCard(currentCard);
            }
            if (GUILayout.Button("AddCard"))
            {
                cardData = new CardDataTest();
                currentCard = CreateInstance<CardTest>();

                addingMode = true;
            }

        }
        else      
        {
            if (GUILayout.Button("SaveCard"))
            {


                currentCard = CreateInstance<CardTest>();
                currentCard.data = new CardDataTest[1];
                currentCard.data[0] = cardData;
                AssetDatabase.CreateAsset(currentCard, "Assets/Resources/Card/" + currentCard.data[0].name + ".asset");
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
        }
        
        EditorGUILayout.EndScrollView();
    }

    private void addCard()
    {

    }
    public  void DeleteCard(CardTest c)
    {

    }
    public void ClearCard()
    {
        cardData = null;
        currentCard = null;
        addingMode = true;
    }

    private void SearchCard(string str)
    {

        CardTest c = Resources.Load<CardTest>("Card/"+str);
        if (c != null)
        {
            currentCard = c;
            cardData = c.data[0]; ;
        }
        else
        {

        }
    }
}