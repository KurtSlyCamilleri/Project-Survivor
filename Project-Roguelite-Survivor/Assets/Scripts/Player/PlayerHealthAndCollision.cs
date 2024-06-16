using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEngine.UI;

public class PlayerHealthAndCollision : MonoBehaviour
{
    public int PlayerHealth = 100;
    public int MaximumPlayerHealth = 100;
    public int HealingDiff = 0;
    public int HealthDiff = 0;
    public TextMeshProUGUI PlayerHealthUI;
    public TextMeshProUGUI PlayerShieldUI;
    public GameObject PlayerShieldBar;
    ShieldGen ShieldG;
    public Slider healthSlider;
    public Slider shieldSlider;
    public AudioClip Death;


    void Start()
    {
        SetHealth(MaximumPlayerHealth);
        SetUpShield();
    }


    void Update()
    {

        
        if (PlayerHealth <= 0)
        {
            GetComponent<AudioSource>().clip = Death;
            GetComponent<AudioSource>().Play();
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }

        SetUpShield();
        if (ShieldG != null)
        {
            PlayerShieldUI.SetText("Shield: " + ShieldG.ShieldLevel);
        }
        PlayerHealthUI.SetText("Health: " + PlayerHealth);

        HealthDiff = MaximumPlayerHealth - 20;
    }

    void OnTriggerEnter(Collider targetObj)
    {
        var damage = 0;
        switch (targetObj.gameObject.tag)
        {
            case "BossShot": damage = 30; break;
            case "BossWave": damage = 2; break;
            case "BossFire": damage = 15; break;
            case "BossRage": damage = 10; break;
        }

        if (ShieldG != null)
        {

            // Deducts points from the shield and returns the leftover
            damage = ShieldG.Damage(damage);
            SetUpShield();
        }
        else
        {
            SetHealth(PlayerHealth - damage);
        }
        
    }

        void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag == "Teleporter")
        {
            transform.position = new Vector3(-17.18f, 0.2f, -40.347f);
        }

        
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
            case "Boss": damage = 60; break;
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
                }
                else
                {
                    HealingDiff = MaximumPlayerHealth - PlayerHealth;
                    SetHealth(PlayerHealth + HealingDiff);
                    HealingDiff = 0;
                }
            }
            SetHealth(PlayerHealth - damage);
        }
        else
        {
            SetHealth(PlayerHealth - damage);
        }

        if (targetObj.gameObject.tag == "Heal")
        {
            
            if (PlayerHealth < HealthDiff)
            {
                SetHealth(PlayerHealth + heal);
            }
            else
            {
                HealingDiff = MaximumPlayerHealth - PlayerHealth;
                SetHealth(PlayerHealth + HealingDiff);
                HealingDiff = 0;
            }
        }

    }
    


    // Updates the health points and the related UI
    private void SetHealth(int value)
    {
        PlayerHealth = value;
        PlayerHealthUI.SetText("Health: " + PlayerHealth);
        healthSlider.value = PlayerHealth / (float)MaximumPlayerHealth;
    }

    // Stores a reference to the ShieldGen script 
    public void SetShield(ShieldGen shield)
    {
        ShieldG = shield;
        PlayerShieldBar.gameObject.SetActive(true);
        PlayerShieldUI.SetText("Shield: " + ShieldG.ShieldLevel);
    }

    public void SetUpShield()
    {
        
        shieldSlider.value = ShieldG.ShieldLevel / (float)ShieldG.ShieldCapacity;
    }
}