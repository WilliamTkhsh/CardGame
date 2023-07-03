using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Deck deck;
    public GameObject cardTemplate;
    public Transform[] handSlots;
    public bool[] availableHandSlots;
    public Transform[] tableSlots;
    public bool[] availableTableSlots;

    public void StartGame()
    {
        for (int i = 0; i < 5; i++)
            DrawCard();
    }
    public void DrawCard()
    {
        if (deck.cardList.Count >= 1)
        {
            for (int i = 0; i < availableHandSlots.Length; i++)
            {
                if(availableHandSlots[i] == true)
                {
                    InstantiateNewCardAndRemoveFromDeck(handSlots[i].transform);
                    availableHandSlots[i] = false;
                    return;
                }
            }
        }
    }

    public void CleanTable()
    {
        for (int i = 0; i < availableTableSlots.Length; i++)
        {
            if (availableTableSlots[i] == false)
            {
                Destroy(tableSlots[i].GetChild(0).gameObject);
                Destroy(tableSlots[i].GetChild(1).gameObject);
                availableTableSlots[i] = true;
            }
        }
    }

    public void InstantiateNewCardAndRemoveFromDeck(Transform transform)
    {
        Card card = deck.cardList[Random.Range(0, deck.cardList.Count)];
        cardTemplate.transform.localPosition = new Vector3(0, 0, 0);
        cardTemplate.transform.localRotation = Quaternion.Euler(0, 0, 0);
        GameObject newCard = Instantiate(cardTemplate, transform);
        newCard.GetComponent<DisplayCardStatsTable>().attack = card.attack;
        newCard.GetComponent<DisplayCardStatsTable>().defense = card.defense;
        newCard.GetComponent<DisplayCardStatsTable>().cardType = card.cardType;
        newCard.GetComponent<DisplayCardStatsTable>().cardModel = card.cardModel;
        newCard.GetComponent<DisplayCardStatsTable>().cardMaterial = card.cardMaterial;
        newCard.GetComponent<DisplayCardStatsTable>().DisplayAll();
        deck.cardList.Remove(card);
    }
}
