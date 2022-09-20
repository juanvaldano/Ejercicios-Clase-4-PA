using System.Collections;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    int totalShots;

    const int maxShots = 6;
    const float reloadTime = 1f;

    private void Start()
    {
        totalShots = maxShots;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && totalShots > 0)
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R) && totalShots < maxShots)
        {
            StartCoroutine("Reload");
        }
    }

    private void Shoot()
    {
        StopCoroutine("Reload");

        if (totalShots > 0)
        {
            totalShots--;
            Debug.Log("Boom! The gun now has " + totalShots + " in its barrel");

            if (totalShots == 0)
            {
                StartCoroutine("Reload");
            }
        }
    }

    private IEnumerator Reload()
    {
        yield return new WaitForSeconds(reloadTime);

        totalShots++;
        Debug.Log("The gun is now loaded with " + totalShots + " bullets");

        if (totalShots < maxShots)
        {
            StartCoroutine("Reload");
        }
    }
}
