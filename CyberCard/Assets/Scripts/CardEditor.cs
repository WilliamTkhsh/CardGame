using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardEditor : MonoBehaviour
{
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI defenseText;
    public int attackInput = 1;
    public int defenseInput = 1;
    public CardStats cardStats;
    public DropdownController dropdownController;

    public void IncreaseAttack()
    {
        if (attackInput < 5)
        {
            attackInput++;
            UpdateAttack();
        }
    }

    public void DecreaseAttack()
    {
        if (attackInput > 1)
        {
            attackInput--;
            UpdateAttack();
        }
    }

    public void IncreaseDefense()
    {
        if(defenseInput < 5)
        {
            defenseInput++;
            UpdateDefense();
        }
    }

    public void DecreaseDefense()
    {
        if (defenseInput > 1)
        {
            defenseInput--;
            UpdateDefense();
        }
    }

    private void UpdateAttack()
    {
        attackText.text = attackInput.ToString();
        SetAttack(attackInput);
    }

    private void UpdateDefense()
    {
        defenseText.text = defenseInput.ToString();
        SetDefense(defenseInput);
    }
    private void SetAttack(int attack)
    {
        cardStats.attack = attack;
    }

    private void SetDefense(int defense)
    {
        cardStats.defense = defense;
    }

    public void SaveCard()
    { 
        //TODO: Salvar a carta no deck e ir para outra cena
    }
}
