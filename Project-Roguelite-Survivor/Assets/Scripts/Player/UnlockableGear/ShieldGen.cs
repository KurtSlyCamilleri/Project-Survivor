using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShieldGen : MonoBehaviour
{
    PlayerHealthAndCollision PlayerShieldScript;
    public int ShieldLevel = 20;
    public int ShieldRegen = 20;
    public int RegenSpeed = 3;
    public int ShieldCapacity = 20;
    public bool ShieldEquipped = false;
 

    // Start is called before the first frame update
    void Start()
    {
        ShieldEquipped = true;
        PlayerShieldScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealthAndCollision>();
        StartCoroutine(ShieldRegenCoroutine());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ShieldRegenCoroutine()
    {
        Debug.Log("1");
        while (true)
        {
            ShieldLevel = PlayerShieldScript.PlayerShield;
            Debug.Log("2");
            if (ShieldLevel < ShieldCapacity)
            {
                Debug.Log("3");
                ShieldLevel += 1;
                Debug.Log("4");
                ShieldRegen = ShieldLevel;
                Debug.Log("6");
                PlayerShieldScript.PlayerShield = ShieldRegen;
                Debug.Log("7");
            }
            Debug.Log("8");
            yield return new WaitForSeconds(RegenSpeed);
        }
    }
}
