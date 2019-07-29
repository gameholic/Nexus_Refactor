using UnityEngine;


using GH.Sample.GameCard.Property;


namespace GH.Sample.GameCard
{
    [CreateAssetMenu(menuName ="Cards/Card")]
    public abstract class Card : ScriptableObject
    {
        public RuntimeValues runtime;
        private CardPhysicalInstance _Instance;
            
        [SerializeField]
        private CardProperty_String _CardName;
        
        [SerializeField]
        private CardProperty_Sprite _Art;


        #region Constructors/GetSet
        public string cardName
        {
            get { return _CardName.stringValue; }
        }

        #endregion
        public CardPhysicalInstance instance
        {
            set { _Instance = value; }
            get { return _Instance; }
        }

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
