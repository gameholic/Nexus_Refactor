using UnityEngine;


namespace GH.Sample.GameCard
{
    public abstract class Card : ScriptableObject
    {
        public RuntimeValues runtime;
        private CardPhysicalInstance _Instance;

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
