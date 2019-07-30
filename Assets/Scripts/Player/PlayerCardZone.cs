using UnityEngine;
using System.Collections;


namespace GH.Nexus.GamePlayerHolder
{
    [CreateAssetMenu(menuName = "PlayerData/CardZone")]
    public class PlayerCardZone : ScriptableObject
    {
        [SerializeField]
        private GameObject _Graveyard;
        [SerializeField]
        private GameObject _HandZone;
        [SerializeField]
        private GameObject[] _FieldZone;
        [SerializeField]
        private GameObject _AttackZone;
        [SerializeField]
        private GameObject _DefendZone;

        

        public Transform graveyard
        {
            get { return _Graveyard.transform; }
        }
        public Transform handZone
        {
            get { return _HandZone.transform; }
        }
        public Transform fieldZone(int i)
        {
            return _FieldZone[i].transform;
        }
        public Transform attackZone
        {
            get { return _AttackZone.transform; }
        }
        public Transform defendZone
        {
            get { return _DefendZone.transform; }
        }

    }

}
