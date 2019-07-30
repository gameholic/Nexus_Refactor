using UnityEngine;


using GH.Nexus.GameCard.Property;
using GH.Nexus.GameCard.Viz;

namespace GH.Nexus.GameCard
{

    public enum CardType
    {
        Creature,Spell
    }
    [CreateAssetMenu(menuName ="Cards/Card")]
    public abstract class Card : ScriptableObject
    {
        #region Variables

        public RuntimeValues runtime;


        private CardPhysicalInstance _Instance;
        private CardViz _Viz;

        [SerializeField]
        private CardProperty[] _Properties;
        [SerializeField]
        private CardType _CardType;

        #endregion
        #region Constructors/GetSet

        public CardProperty[] property
        {
            get { return _Properties; }        
        }
        public CardViz viz
        {
            set { _Viz = value; }
            get { return _Viz; }
        }
        public CardType cardType
        {
            get { return _CardType; }
        }
        public CardPhysicalInstance instance
        {
            set { _Instance = value; }
            get { return _Instance; }
        }

        #endregion

        public virtual void InitCard()
        {
            Debug.Log("INIT");
            runtime = new RuntimeValues();
        }

        public abstract bool CanUseCard();
        public abstract bool CanDropCard();
        public abstract bool UseCard();
    }
    public class RuntimeValues
    {
        private int instId;
    }

}
