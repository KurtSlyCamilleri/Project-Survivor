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

    }

    // Update is called once per frame
    void Update()
    {
        
        if (PlayerShield < 0)
        {
            PlayerShield = 0;
        }
        PlayerHealthUI.SetText("Health: " + PlayerHealth.ToString());
        PlayerShieldUI.SetText("Shield: " + PlayerShield.ToString());
        Debug.Log("1");
        ShieldG = GameObject.FindGameObjectWithTag("ShieldGen").GetComponent<ShieldGen>();
        Debug.Log("2");
        ShieldStatus = ShieldG.ShieldEquipped;
        Debug.Log("3");
        PlayerShield = ShieldG.ShieldLevel;
        Debug.Log("4");


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
                    PlayerShield -= 10;
                }
                if (targetObj.gameObject.tag == "Charger")
                {
                    PlayerShield -= 5;
                }
                if (targetObj.gameObject.tag == "Sponge")
                {
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
