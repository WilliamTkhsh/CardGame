using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DropdownController : MonoBehaviour
{
    public TMP_Dropdown tipoDropdown;
    public TMP_Dropdown modeloDropdown;
    public TMP_Dropdown materialDropdown;
    public DisplayCardStats cardStats;

    public string[] armaModelos;
    public string[] veiculoModelos;
    public string[] personagemModelos;

    private void Start()
    {
        // Define as opções iniciais do dropdown "Tipo"
        tipoDropdown.ClearOptions();
        tipoDropdown.AddOptions(new List<string> { "Arma", "Veículo", "Personagem" });

        materialDropdown.ClearOptions();
        materialDropdown.AddOptions(new List<string> { "Bronze", "Silver", "Gold" });

        // Define as opções iniciais do dropdown "Modelo" para Arma
        SetModeloDropdownOptions(armaModelos);
    }

    public void OnTipoDropdownValueChanged()
    {
        string[] options;
        switch (tipoDropdown.value)
        {
            case 0: // Arma
                options = armaModelos;
                SetModeloDropdownOptions(options);
                SetCardModeloValue(options[0]);
                break;
            case 1: // Veículo
                options = veiculoModelos;
                SetModeloDropdownOptions(options);
                SetCardModeloValue(options[0]);
                break;
            case 2: // Personagem
                options = personagemModelos;
                SetModeloDropdownOptions(options);
                SetCardModeloValue(options[0]);
                break;
        }
        SetCardTipoValue(tipoDropdown.options[tipoDropdown.value].text);
        cardStats.UpdateCardTypeIcon();
    }

    public void OnModeloDropdownValueChanged()
    {
        SetCardModeloValue(modeloDropdown.options[modeloDropdown.value].text);
    }
    public void OnMaterialDropdownValueChanged()
    {
        SetCardMaterialValue(materialDropdown.options[materialDropdown.value].text);
        cardStats.UpdateCardMaterial();
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
