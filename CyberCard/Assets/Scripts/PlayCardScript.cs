using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCardScript : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject cardPlane;
    public GameObject cardObject;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == cardPlane)
                {
                    Debug.Log("Carta Jogada");

                }
            }
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            PlayCard();
        }
    }

    public void PlayCard()
    {
        for (int i = 0; i < gameManager.availableTableSlots.Length; i++)
        {
            if (gameManager.availableTableSlots[i] == true)
            {
                MoveCardToTableSlot(gameManager.tableSlots[i].transform);
                gameManager.availableTableSlots[i] = false;
                gameManager.availableHandSlots[i] = true;
                return;
            }
        }
    }

    public void MoveCardToTableSlot(Transform transform)
    {

        cardObject.transform.SetParent(transform);
        cardObject.transform.localPosition = new Vector3(2f, 0f, -1f);
        cardObject.transform.localRotation = Quaternion.Euler(0, -90, 0);
    }

}