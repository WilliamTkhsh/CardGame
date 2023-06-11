using TMPro;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CardEditor : MonoBehaviour
{
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI defenseText;
    public int attackInput = 1;
    public int defenseInput = 1;
    public CardStats cardStats;
    public GameObject deckObject;
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

    public void SaveCardIntoDeck()
    {
        if (deckObject != null && cardStats != null)
        {
            CardStats newCard = Instantiate(cardStats);
            newCard.transform.parent = deckObject.transform;
        }
        else
        {
            Debug.LogError("Deck Object or Card Prefab is not assigned!");
        }
    }

    public void MoveToDeckScene()
    {
        Scene deckScene = SceneManager.GetSceneByName("DeckEditor");
        SceneManager.LoadScene("DeckEditor");
        
        if (deckScene.IsValid())
        {
            SceneManager.MoveGameObjectToScene(deckObject, SceneManager.GetActiveScene());
        }
    }

    public void OnClickSaveButton()
    {
        SaveCardIntoDeck();
        //MoveToDeckScene();
    }
}
