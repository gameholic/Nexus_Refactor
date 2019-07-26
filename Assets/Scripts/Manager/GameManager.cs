using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GH.Sample.GamePlayerHolder;
using GH.Sample.GameCard;

namespace GH.Sample.Manager
{
    public enum GameOperation
    {
        pickNewCard
    }       

    public class GameManager : MonoBehaviour
    {
        #region Variables
        #region Public Variables

        public PlayerHolder currentPlayer;
        public GameObject cardPrefab;
        public PositionHandler positionHandler;
        #endregion
        #region Private Variables

        private Dictionary<string, PlayerHolder> allPlayers = new Dictionary<string, PlayerHolder>();
        private static ResourceManager _ResourceManager;
        private static GameManager _Singleton;

        #endregion
        #endregion

        #region Constructors
        public static GameManager singleton { get { return _Singleton; } }
        public static ResourceManager resourceManager
        {
            get
            {
                if (_ResourceManager == null)
                {
                    _ResourceManager = Resources.Load("ResourceManager") as ResourceManager;
                    _ResourceManager.Init();
                }
                return _ResourceManager;
            }
        }
        public PlayerHolder GetPlayer(string id)
        {
            PlayerHolder p = null;
            allPlayers.TryGetValue(id, out p);
            if (p == null)
            {
                Debug.LogWarning("GetPlayerError: We can't find player in dictionary");
            }
            return p;
        }
        #endregion

        #region Initialization
        public void InitPlayer(PlayerHolder p)
        {
            allPlayers.Add(p.playerId, p);
            p.Init();
        }
        private void Awake()
        {
            _Singleton = this;
            positionHandler = new PositionHandler();
        }
        private void Start()
        {
            InitPlayer(currentPlayer);
            GameOperationFromPlayer(currentPlayer.playerId, GameOperation.pickNewCard);
        }
        #endregion

        #region GameOperation
        private void PlayerPicksNewCard(PlayerHolder p)
        {
            string cardName = p.PickNewCardFromDeck();

            if (cardName == null)
            {
                return;
            }
            Card newCard = resourceManager.GetCardAsInstance(cardName);

            GameObject go = Instantiate(cardPrefab) as GameObject;
            CardPhysicalInstance cardphys = go.GetComponentInChildren<CardPhysicalInstance>();
            cardphys.originCard = newCard;


        }
        #endregion

        public void GameOperationFromPlayer(string playerId, GameOperation operation)
        {
            PlayerHolder p = GetPlayer(playerId);

            switch(operation)
            {
                case GameOperation.pickNewCard:
                    PlayerPicksNewCard(p);
                    break;


                default:
                    break;
            }

        }


    }

}