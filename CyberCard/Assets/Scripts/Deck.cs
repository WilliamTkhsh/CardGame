using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    [SerializeField] public List<Card> cardList = new List<Card>();

    private void Awake()
    {
        cardList.Add(new Card(1, 1, "Arma", "Arma 1", "Material 1"));
    }

}
