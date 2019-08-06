using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.IO;

using GH.Nexus.GameCard;

namespace GH.Nexus.Test
{
    [CreateAssetMenu(menuName = "TestCards/TestCard")]
    public class CardTest : ScriptableObject
    {
        public CardDataTest[] data;
        public CardVizTest viz;

        public void propertySetting(CardVizTest viz)
        {

        }
    }


}