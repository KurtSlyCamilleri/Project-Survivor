using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealthAndCollision : MonoBehaviour
{
    public int PlayerHealth = 100;
    public int PlayerShield = 20;
    public TextMeshProUGUI PlayerHealthUI;
    public TextMeshProUGUI PlayerShieldUI;
    ShieldGen ShieldG;
    public bool ShieldStatus = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShieldSetting());
    }

    // Update is called once per frame
    void Update()
    {
        
        
        PlayerHealthUI.SetText("Health: " + PlayerHealth.ToString());
        PlayerShieldUI.SetText("Shield: " + PlayerShield.ToString());

        ShieldG = GameObject.FindGameObjectWithTag("ShieldGen").GetComponent<ShieldGen>();

        ShieldStatus = ShieldG.ShieldEquipped;
        if (ShieldStatus == true)
        {
            PlayerShieldUI.gameObject.SetActive(true);
        }
    }

    IEnumerator ShieldSetting()
    {
        while (true)
        {
            if (PlayerShield <= -1)
            {
                PlayerShield = 0;
            }
            yield return new WaitForSeconds(1);
        }

            
    }
        void OnCollisionEnter(Collision targetObj)
    {
        if(ShieldStatus == true)
        {
            if (PlayerShield <= 0)
            {
                if (targetObj.gameObject.tag == "Swarmer")
                {
                    PlayerHealth -= 10;
                }
                if (targetObj.gameObject.tag == "Charger")
                {
                    PlayerHealth -= 5;
                }
                if (targetObj.gameObject.tag == "Sponge")
                {
                    PlayerHealth -= 25;
                }
            }
            else
            {
                if (targetObj.gameObject.tag == "Swarmer")
                {
                    Debug.Log("Swarmer Hit");
                    PlayerShield -= 10;
                }
                if (targetObj.gameObject.tag == "Charger")
                {
                    Debug.Log("Charger Hit");
                    PlayerShield -= 5;
                }
                if (targetObj.gameObject.tag == "Sponge")
                {
                    Debug.Log("Sponge Hit");
                    PlayerShield -= 25;
                }
            }
        }
        else
        {
            if (targetObj.gameObject.tag == "Swarmer")
            {
                PlayerHealth -= 10;
            }
            if (targetObj.gameObject.tag == "Charger")
            {
                PlayerHealth -= 5;
            }
            if (targetObj.gameObject.tag == "Sponge")
            {
                PlayerHealth -= 25;
            }
        }
       
        
    }

}
