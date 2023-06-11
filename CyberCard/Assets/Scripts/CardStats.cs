using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStats : MonoBehaviour
{

    //TODO: Colocar aqui todas as propriedades da carta
    public int attack;
    public int defense;
    public string cardType;
    public string cardModel;
    public string cardMaterial;

    public CardStats(int attack, int defense, string cardType, string cardModel, string cardMaterial)
    {
        this.attack = attack;
        this.defense = defense;
        this.cardType = cardType;
        this.cardModel = cardModel;
        this.cardMaterial = cardMaterial;
    }

}
