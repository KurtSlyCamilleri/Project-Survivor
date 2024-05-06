using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class PlayerHealthAndCollision : MonoBehaviour
{
    public int PlayerHealth = 100;
    public int MaximumPlayerHealth = 100;
    public TextMeshProUGUI PlayerHealthUI;
    public TextMeshProUGUI PlayerShieldUI;
    ShieldGen ShieldG;


    void Start()
    {
        PlayerHealth = 100;
    }


    void Update()
    {
        if(PlayerHealth <= 0)
        {
            SceneManager.LoadScene("Coding_Testing_Grounds");
        }

        if (ShieldG != null)
        {
            PlayerShieldUI.SetText("Shield: " + ShieldG.ShieldLevel);
        }
        PlayerHealthUI.SetText("Health: " + PlayerHealth);
    }


    void OnCollisionEnter(Collision targetObj)
    {
        // Might as well 
        Debug.Log("Hit by " + targetObj.gameObject.tag);

        // Each character has a specific amount of damage to make.
        // Consider moving these to a dedicated script instead.
        var damage = 0;
        switch (targetObj.gameObject.tag)
        {
            case "Charger": damage = 5; break;
            case "Sponge": damage = 25; break;
            case "Swarmer": damage = 10; break;
        }

        // Apply damage to the shield first, if we have one
        if (ShieldG != null)
        {

            // Deducts points from the shield and returns the leftover
            damage = ShieldG.Damage(damage);
            
        }
        SetHealth(PlayerHealth - damage);



    }
    


    // Updates the health points and the related UI
    private void SetHealth(int value)
    {
        PlayerHealth = value;
        PlayerHealthUI.SetText("Health: " + PlayerHealth);
    }

    // Stores a reference to the ShieldGen script 
    public void SetShield(ShieldGen shield)
    {
        ShieldG = shield;
        PlayerShieldUI.gameObject.SetActive(true);
        PlayerShieldUI.SetText("Shield: " + ShieldG.ShieldLevel);
    }
}