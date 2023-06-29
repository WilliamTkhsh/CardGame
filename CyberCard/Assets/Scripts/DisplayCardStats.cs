using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayCardStats : MonoBehaviour
{

    public int attack;
    public int defense;
    public string cardType;
    public string cardModel;
    public string cardMaterial;
    public TextMeshPro attackText;
    public TextMeshPro defenseText;

    public DisplayCardStats(int attack, int defense, string cardType, string cardModel, string cardMaterial)
    {
        this.attack = attack;
        this.defense = defense;
        this.cardType = cardType;
        this.cardModel = cardModel;
        this.cardMaterial = cardMaterial;
        this.attackText.text = attack.ToString();
        this.defenseText.text = defense.ToString();
    }


    public void Start()
    {
        attack = 1;
        defense = 1;
        cardType = "Arma";
        cardModel = "Arma 1";
        cardMaterial = "Material 1";
        attackText.text = attack.ToString();
        defenseText.text = defense.ToString();
    }

    public void UpdateAttackText(int attackInput)
    {
        attackText.text = attackInput.ToString();
        attack = attackInput;
    }

    public void UpdateDefenseText(int defenseInput)
    {
        defenseText.text = defenseInput.ToString();
        defense = defenseInput;
    }

}
