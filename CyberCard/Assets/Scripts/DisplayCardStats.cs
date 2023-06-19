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
