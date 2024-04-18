using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldGen : MonoBehaviour
{
    PlayerHealthAndCollision PlayerShield;
    public int ShieldLevel = 20;
    public int RegenSpeed = 3;
    public int ShieldCapacity = 20;
    public bool ShieldEquipped = false;

    // Start is called before the first frame update
    void Start()
    {
        ShieldEquipped = true;
        PlayerShield = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealthAndCollision>();
        StartCoroutine(ShieldRegenCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        ShieldLevel = PlayerShield.PlayerShield;
    }

    IEnumerator ShieldRegenCoroutine()
    {
        while (true)
        {
            if (ShieldLevel < ShieldCapacity)
            {
                ShieldLevel++;
            }
            yield return new WaitForSeconds(RegenSpeed);
        }
    }
}
