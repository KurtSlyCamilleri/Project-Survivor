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
    public int HealingDiff = 0;
    public int HealthDiff = 0;
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

        HealthDiff = MaximumPlayerHealth - 20;
    }


    void OnCollisionEnter(Collision targetObj)
    {
        // Might as well 
        Debug.Log("Hit by " + targetObj.gameObject.tag);

        // Each character has a specific amount of damage to make.
        // Consider moving these to a dedicated script instead.
        var damage = 0;
        var heal = 0;
        switch (targetObj.gameObject.tag)
        {
            case "Charger": damage = 5; break;
            case "Sponge": damage = 25; break;
            case "Swarmer": damage = 10; break;
            case "ChargerB": damage = 8; break;
            case "SpongeB": damage = 35; break;
            case "SwarmerB": damage = 15; break;
            case "ChargerC": damage = 10; break;
            case "SpongeC": damage = 45; break;
            case "SwarmerC": damage = 20; break;
            case "Heal": heal = 20; break;
            case "BossShot": damage = 40; break;
            case "BossWave": damage = 5; break;
        }

        // Apply damage to the shield first, if we have one
        if (ShieldG != null)
        {

            // Deducts points from the shield and returns the leftover
            damage = ShieldG.Damage(damage);
            
            if (targetObj.gameObject.tag == "Heal")
            {
                
                if (PlayerHealth < HealthDiff)
                {
                    SetHealth(PlayerHealth + heal);
                    Debug.Log("Healed for" + heal);
                }
                else
                {
                    HealingDiff = MaximumPlayerHealth - PlayerHealth;
                    SetHealth(PlayerHealth + HealingDiff);
                    Debug.Log("Healed for" + HealingDiff);
                    HealingDiff = 0;
                }
            }
            
            SetHealth(PlayerHealth - damage);
        }

        if (targetObj.gameObject.tag == "Heal")
        {
            
            if (PlayerHealth < HealthDiff)
            {
                SetHealth(PlayerHealth + heal);
                Debug.Log("Healed for" + heal);
            }
            else
            {
                HealingDiff = MaximumPlayerHealth - PlayerHealth;
                SetHealth(PlayerHealth + HealingDiff);
                Debug.Log("Healed for" + HealingDiff);
                HealingDiff = 0;
            }
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