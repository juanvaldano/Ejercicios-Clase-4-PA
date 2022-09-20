using UnityEngine;

public class DiceRoller : MonoBehaviour
{
    [SerializeField] int dieFaces = 20;

    private int totalBonus;

    private void Start()
    {
        totalBonus = 0;
        ModifierToggle.ChangeBonus += ModifyBonus;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RollDie();
        }
    }

    private void RollDie()
    {
        int randomValue = Random.Range(0, dieFaces) + 1 + totalBonus;
        Debug.Log("Result: " + randomValue + " | Current bonus: " + totalBonus);
    }

    private void ModifyBonus(bool isOn, Modifier modifier)
    {
        totalBonus += isOn ? modifier.GetValue() : -modifier.GetValue();
    }

    private void OnDisable()
    {
        ModifierToggle.ChangeBonus -= ModifyBonus;
    }
}
