using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CardEditor : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI menuAttackText;
    [SerializeField] private TextMeshProUGUI menuDefenseText;
    private int attackInput;
    private int defenseInput;
    public DisplayCardStats cardStats;
    public DropdownController dropdownController;
    public Deck deck;

    void Start()
    {
        attackInput = 1;
        defenseInput = 1;
        menuAttackText.text = attackInput.ToString();
        menuDefenseText.text = defenseInput.ToString();
    }

    public void IncreaseAttack()
    {
        if (attackInput < 5)
        {
            attackInput++;
            cardStats.UpdateAttackText(attackInput);
            menuAttackText.text = attackInput.ToString();
        }
    }

    public void DecreaseAttack()
    {
        if (attackInput > 1)
        {
            attackInput--;
            cardStats.UpdateAttackText(attackInput);
            menuAttackText.text = attackInput.ToString();
        }
    }

    public void IncreaseDefense()
    {
        if(defenseInput < 5)
        {
            defenseInput++;
            cardStats.UpdateDefenseText(defenseInput);
            menuDefenseText.text = defenseInput.ToString();
        }
    }

    public void DecreaseDefense()
    {
        if (defenseInput > 1)
        {
            defenseInput--;
            cardStats.UpdateDefenseText(defenseInput);
            menuDefenseText.text = defenseInput.ToString();
        }
    }

    public void SaveCardIntoDeck()
    {
        if (deck != null && cardStats != null)
        {
            deck.cardList.Add(new Card(cardStats.attack, cardStats.defense, cardStats.cardType, cardStats.cardModel, cardStats.cardMaterial));
        }
        else
        {
            Debug.LogError("Deck Object or Card Prefab is not assigned!");
        }
    }

    public void OnClickSaveButton()
    {
        SaveCardIntoDeck();
    }
}
