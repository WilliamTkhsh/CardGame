using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayCardStatsTable : MonoBehaviour
{

    public int attack;
    public int defense;
    public string cardType;
    public string cardModel;
    public string cardMaterial;
    public TextMeshPro attackText;
    public TextMeshPro defenseText;
    public GameObject cardEdge;
    public GameObject cardSpritePlane;
    public List<Material> materials;
    public List<GameObject> typeIcon;
    public List<Material> models;
    public string assetModelPath;

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

    public void UpdateCardSprite()
    {
        switch (cardModel)
        {
            case "Laser Rifle":
                cardSpritePlane.GetComponent<MeshRenderer>().material = models[0];
                break;
            case "Sniper":
                cardSpritePlane.GetComponent<MeshRenderer>().material = models[1];
                break;
            case "Gl1tch":
                cardSpritePlane.GetComponent<MeshRenderer>().material = models[2];
                break;
            case "Enforcer":
                cardSpritePlane.GetComponent<MeshRenderer>().material = models[3];
                break;
            case "Voltor":
                cardSpritePlane.GetComponent<MeshRenderer>().material = models[4];
                break;
            case "T-Armata":
                cardSpritePlane.GetComponent<MeshRenderer>().material = models[5];
                break;
        }
    }

    public void UpdateCardModel()
    {
        assetModelPath = cardModel;
    }

    public void DisplayAll()
    {
        UpdateAttackText();
        UpdateDefenseText();
        UpdateCardSprite();
        UpdateCardModel();
        UpdateCardTypeIcon();
        UpdateCardMaterial();
    }
}
