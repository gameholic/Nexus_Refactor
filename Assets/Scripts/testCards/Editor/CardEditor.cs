using UnityEngine;
using UnityEditor;
using GH.Nexus.Test;
public class CardEditor : EditorWindow
{
    Vector2 scrollPos;
    string cardName;
    //public CardMirror targetCard =new CardMirror();
    public CardDataTest cardData = null;
    public CardTest currentCard = null;

    SerializedObject serializedObject;
    SerializedProperty serializedProperty;


    bool initialised = false;
    private bool addingMode = false;

     [MenuItem("Editor/Card Editor")]
    private static void Init()
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
        if (currentCard != null)
        {
            if (!initialised)
            {
                Debug.Log("hey");
                serializedObject = new SerializedObject(currentCard);
                serializedProperty = serializedObject.FindProperty("data");
                initialised = true;
            }
            //serializedObject.Update();
            EditorGUILayout.PropertyField(serializedProperty, true);

            // serializedObject.ApplyModifiedProperties();         //working

            if (GUILayout.Button("Test"))
            {
                serializedObject.ApplyModifiedProperties(); //still Notworking
            }
        }
        if (!addingMode)
        {
            if (GUILayout.Button("Search") || e.keyCode == KeyCode.Return)
            {
                SearchCard(cardName);
            }
            if (GUILayout.Button("AddCard"))
            {
                ResetCardNData();
               addingMode = true;
            }
            if (GUILayout.Button("DeleteCard"))
            {
                DeleteCard(currentCard);
            }

        }
        else      
        {
            if (GUILayout.Button("SaveCard"))
            {
                SaveCard();
                addingMode = false;
            }
        }

        if (GUILayout.Button("ClearData"))
        {
            ClearCard();
        }

        EditorGUILayout.EndScrollView();
    }

    private void ResetCardNData()
    {
        cardData = new CardDataTest();
        currentCard = CreateInstance<CardTest>();
        currentCard.data = new CardDataTest[1];

    }
    private void SaveCard()
    {
        currentCard.data[0] = cardData;
        AssetDatabase.CreateAsset(currentCard, "Assets/Resources/Card/" + currentCard.data[0].name + ".asset");
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        addingMode = false;
    }
    public  void DeleteCard(CardTest c)
    {

        AssetDatabase.DeleteAsset("Assets/Resources/Card/" + c.data[0].name + ".asset");
        AssetDatabase.Refresh();

        Popup popup = CreateInstance<Popup>();
        popup.Init();

        ClearCard();
    }

    public void ClearCard()
    {
        cardData = null;
        currentCard = null;
    }

    private void SearchCard(string str)
    {

        CardTest c = Resources.Load<CardTest>("Card/"+str);
        if (c != null)
        {
            currentCard = c;
            cardData = c.data[0]; 
        }
        else
        {
            Debug.LogWarning("FailToSearch " + str);
        }
    }
}
public class Popup : EditorWindow
{
    public void Init()
    {
        Popup window = ScriptableObject.CreateInstance<Popup>();
        window.position = new Rect(Screen.width / 2, Screen.height / 2, 250, 150);
        window.ShowPopup();
    }

    void OnGUI()
    {
        EditorGUILayout.LabelField("This is an example of EditorWindow.ShowPopup", EditorStyles.wordWrappedLabel);
        GUILayout.Space(70);
        if (GUILayout.Button("Agree!")) this.Close();
    }
}