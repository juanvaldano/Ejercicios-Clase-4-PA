using UnityEngine;
using UnityEngine.UI;
using System;

public class ModifierToggle : MonoBehaviour
{
    [SerializeField] int modValue;
    [SerializeField] string modName;

    public static event Action<bool, Modifier> ChangeBonus;

    private Toggle thisToggle;
    private Modifier modifier;

    void Start()
    {
        thisToggle = GetComponent<Toggle>();
        thisToggle.isOn = false;

        modifier = new Modifier(modValue, modName);
    }

    public void ToggleBonus()
    {
        ChangeBonus?.Invoke(thisToggle.isOn, modifier);
    }
}
