using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.IO;


namespace GH.Nexus.Test
{
    [CreateAssetMenu(menuName = "TestCards/TestCard")]
    public class CardTest : ScriptableObject
    {
        public CardDataTest[] data;
        public CardVizTest viz;


    }

    /*
    [System.Serializable]
    public class CardMirror
    {

        [SerializeField]
        public CardTest card;
    }
    */




}