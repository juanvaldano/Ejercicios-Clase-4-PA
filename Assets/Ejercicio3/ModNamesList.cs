using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModNamesList : MonoBehaviour
{
    private const string baseText = "Modifiers: ";

    private Text modNamesText;
    private List<string> modifiers;

    private void Start()
    {
        modNamesText = GetComponent<Text>();
        modifiers = new List<string>();

        ModifierToggle.ChangeBonus += UpdateText;
    }

    private void UpdateText(bool isOn, Modifier modifier)
    {
        if(isOn)
        {
            modifiers.Add(modifier.GetName());            
        }
        else
        {
            int itemToRemove = modifiers.IndexOf(modifier.GetName());
            modifiers.RemoveAt(itemToRemove);
        }

        modNamesText.text = AddAllNames(modifiers);
    }

    private string AddAllNames(List<string> nameList)
    {
        string result = baseText;
        nameList.ForEach(name => result += name + " ");

        return result;
    }

    private void OnDisable()
    {
        ModifierToggle.ChangeBonus -= UpdateText;
    }
}
