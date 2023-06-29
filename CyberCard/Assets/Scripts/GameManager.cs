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

    public void InstantiateNewCardAndRemoveFromDeck(Transform transform)
    {
        Card card = deck.cardList[Random.Range(0, deck.cardList.Count)];
        cardTemplate.transform.localPosition = new Vector3(0, 0, 0);
        cardTemplate.transform.localRotation = Quaternion.Euler(0, 0, 0);
        GameObject newCard = Instantiate(cardTemplate, transform);
        newCard.GetComponent<DisplayCardStats>().attackText.text = card.attack.ToString();
        newCard.GetComponent<DisplayCardStats>().defenseText.text = card.defense.ToString();
        deck.cardList.Remove(card);
    }
}