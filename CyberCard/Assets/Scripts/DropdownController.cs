using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DropdownController : MonoBehaviour
{
    public TMP_Dropdown tipoDropdown;
    public TMP_Dropdown modeloDropdown;
    public TMP_Dropdown materialDropdown;
    public CardStats cardStats;

    public string[] armaModelos;
    public string[] veiculoModelos;
    public string[] personagemModelos;

    private void Start()
    {
        // Define as opções iniciais do dropdown "Tipo"
        tipoDropdown.ClearOptions();
        tipoDropdown.AddOptions(new List<string> { "Arma", "Veículo", "Personagem" });

        // Define as opções iniciais do dropdown "Modelo" para Arma
        SetModeloDropdownOptions(armaModelos);
    }

    public void OnTipoDropdownValueChanged()
    {
        switch (tipoDropdown.value)
        {
            case 0: // Arma
                SetModeloDropdownOptions(armaModelos);
                break;
            case 1: // Veículo
                SetModeloDropdownOptions(veiculoModelos);
                break;
            case 2: // Personagem
                SetModeloDropdownOptions(personagemModelos);
                break;
        }
        SetCardTipoValue(tipoDropdown.options[tipoDropdown.value].text);
        Debug.Log(cardStats.cardType);
    }

    public void OnModeloDropdownValueChanged()
    {
        SetCardModeloValue(modeloDropdown.options[modeloDropdown.value].text);
        Debug.Log(cardStats.cardModel);
    }
    public void OnMaterialDropdownValueChanged()
    {
        SetCardMaterialValue(materialDropdown.options[materialDropdown.value].text);
        Debug.Log(cardStats.cardMaterial);
    }

    private void SetModeloDropdownOptions(string[] options)
    {
        modeloDropdown.ClearOptions();
        modeloDropdown.AddOptions(new List<string>(options));
    }

    private void SetCardTipoValue(string type)
    {
        cardStats.cardType = type;
    }

    private void SetCardModeloValue(string modelo)
    {
        cardStats.cardModel = modelo;
    }

    private void SetCardMaterialValue(string material)
    {
        cardStats.cardMaterial = material;
    }
}
