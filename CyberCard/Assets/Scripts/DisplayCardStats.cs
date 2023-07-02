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
    public GameObject cardEdge;
    public List<Material> materials;
    public List<GameObject> typeIcon;


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


    public void Awake()
    {
        attack = 1;
        defense = 1;
        cardType = "Arma";
        cardModel = "Arma 1";
        cardMaterial = "Bronze";
        attackText.text = attack.ToString();
        defenseText.text = defense.ToString();
    }

    public void UpdateAttackText()
    {
        attackText.text = attack.ToString();
    }

    public void UpdateDefenseText()
    {
        defenseText.text = defense.ToString();
    }

    public void UpdateCardMaterial()
    {
        switch (cardMaterial)
        {
            case "Bronze": // Bronze
                cardEdge.GetComponent<MeshRenderer>().material = materials[0];
                break;
            case "Silver": // Silver
                cardEdge.GetComponent<MeshRenderer>().material = materials[1];
                break;
            case "Gold": // Gold
                cardEdge.GetComponent<MeshRenderer>().material = materials[2];
                break;
        }
    }

    public void UpdateCardTypeIcon()
    {
        switch (cardType)
        {
            case "Arma": // Arma
                typeIcon[0].gameObject.SetActive(true);
                typeIcon[1].gameObject.SetActive(false);
                typeIcon[2].gameObject.SetActive(false);
                break;
            case "Veículo": // Veículo
                typeIcon[0].gameObject.SetActive(false);
                typeIcon[1].gameObject.SetActive(true);
                typeIcon[2].gameObject.SetActive(false);
                break;
            case "Personagem": // Personagem
                typeIcon[0].gameObject.SetActive(false);
                typeIcon[1].gameObject.SetActive(false);
                typeIcon[2].gameObject.SetActive(true);
                break;
        }
    }

    public void DisplayAll()
    {
        UpdateAttackText();
        UpdateDefenseText();
        UpdateCardTypeIcon();
        UpdateCardMaterial();
    }
}
