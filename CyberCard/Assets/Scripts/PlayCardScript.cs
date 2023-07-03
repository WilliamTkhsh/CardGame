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
                    PlayCard();
                }
            }
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

    //public void DiscardCard()
    //{
    //    for (int i = 0; i < gameManager.availableHandSlots.Length; i++)
    //    {
    //        Destroy(cardObject);
    //        gameManager.availableHandSlots[i] = true;
    //    }
        
    //}

    public void MoveCardToTableSlot(Transform transform)
    {
        cardObject.transform.SetParent(transform);
        cardObject.transform.localPosition = new Vector3(2f, 0f, -6f);
        cardObject.transform.localRotation = Quaternion.Euler(0, -90, 0);
        var assetModel = cardObject.GetComponent<DisplayCardStatsTable>().cardModel;
        var assetTexture = cardObject.GetComponent<DisplayCardStatsTable>().cardMaterial;
        Debug.Log("Prefabs/" + assetModel);
        var hologramTransform = transform;
        var yOffset = 0.75f; // Distância adicional no eixo Y
        var positionOffset = new Vector3(0f, yOffset, 0f);
        var hologram = Instantiate(Resources.Load("Prefabs/" + assetModel + "_" + assetTexture), hologramTransform.position + positionOffset, hologramTransform.rotation) as GameObject;
        hologram.transform.SetParent(transform);
    }
}
