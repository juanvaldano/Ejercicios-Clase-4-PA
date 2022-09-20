using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

public class Ejercicio1 : MonoBehaviour
{
    [SerializeField] InputField weaponInput;

    List<GameObject> weapons;
    IEnumerable<string> weaponNames;

    private void Start()
    {
        weapons = Resources.LoadAll<GameObject>("Armas").ToList();
        weaponNames = weapons.Select(weapon => weapon.name);
    }

    public void SpawnWeapon()
    {
        if (!weaponNames.Contains(weaponInput.textComponent.text.ToLower()))
        {
            Instantiate(Resources.Load<GameObject>("Armas/espada"), transform.position, transform.rotation);
            return;
        }

        string route = "Armas/" + weaponInput.textComponent.text;
        Instantiate(Resources.Load<GameObject>(route), transform.position, transform.rotation);
    }
}
