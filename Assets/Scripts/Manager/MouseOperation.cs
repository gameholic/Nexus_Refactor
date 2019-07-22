using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


using GH.Sample.GameCard;
namespace GH.Sample.Manager
{
    public class MouseOperation : MonoBehaviour
    {
        private CardInstance currentCard = null;

        private void Update()
        {
            HandleMouse();
        }


        private void HandleMouse()
        {
            bool isMouseDown = Input.GetMouseButton(0);
            
            if(!isMouseDown)
            {
                HandleCardDetection();
            }
            else
            {
                HandleMouseDrag();
            }
        }
        private void HandleMouseDrag()
        {
            if (currentCard != null)
            {
                currentCard.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
                currentCard.transform.SetAsLastSibling();
            }

        }
        private void HandleCardClick()
        {
            bool isMouseDown = Input.GetMouseButtonDown(0);

            if (!isMouseDown)
            {
                if (currentCard != null)
                {
                    //TODO: Check current state / phase and perform action
                }
            }
        }
        private void HandleCardDetection()
        {
            RaycastHit[] hits = GetUIObjs();
            CardInstance detectedCard = null;
            for (int i = 0; i < hits.Length; i++)
            {
                detectedCard = hits[i].transform.gameObject.GetComponentInParent<CardInstance>();
                
                //If dectected card isn't current card
                if (detectedCard!=null)
                {                 
                    //If there is card instance in 'currentCard', break
                    break;
                }
            }

            if (detectedCard != null)
            {
                if (currentCard != null)
                {
                    currentCard.DeHighlight();
                }
                currentCard = detectedCard;
                currentCard.Highlight();
            }
            else
            {
                if(currentCard!=null)
                {
                    currentCard.DeHighlight();
                    currentCard = null;
                }
            }

        }

        public static RaycastHit[] GetUIObjs()
        {
            Camera mainCam = Camera.main;
            Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit[] ray = Physics.RaycastAll(cameraRay, 100.0f);

            return ray;
        }

    }


}