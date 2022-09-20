using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModValuesList : MonoBehaviour
{
    private const string baseText = "Total: ";

    private int modValuesSum;

    private Text modValuesText;

    void Start()
    {
        modValuesSum = 0;

        modValuesText = GetComponent<Text>();
        modValuesText.text = baseText + modValuesSum;

        ModifierToggle.ChangeBonus += UpdateText;
    }

    private void UpdateText(bool isOn, Modifier modifier)
    {
        modValuesSum += isOn ? modifier.GetValue() : -modifier.GetValue();
        modValuesText.text = baseText + modValuesSum;
    }

    private void OnDisable()
    {
        ModifierToggle.ChangeBonus -= UpdateText;
    }
}
