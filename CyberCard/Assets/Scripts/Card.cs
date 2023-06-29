using UnityEngine;

public class Card
{
    public int attack;
    public int defense;
    public string cardType;
    public string cardModel;
    public string cardMaterial;

    public Card(int attack, int defense, string cardType, string cardModel, string cardMaterial)
    {
        this.attack = attack;
        this.defense = defense;
        this.cardType = cardType;
        this.cardModel = cardModel;
        this.cardMaterial = cardMaterial;
    }
}
