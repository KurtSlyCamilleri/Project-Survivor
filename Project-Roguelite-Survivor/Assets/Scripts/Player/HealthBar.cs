using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public int maxhp;
    public int currenthp;
    public Image slider;
    PlayerHealthAndCollision HealthScript;

    // Start is called before the first frame update
    void Start()
    {
        maxhp = HealthScript.MaximumPlayerHealth;
        currenthp = HealthScript.PlayerHealth;
    }

    // Update is called once per frame
    void Update()
    {
        maxhp = HealthScript.MaximumPlayerHealth;
        currenthp = HealthScript.PlayerHealth;
        GetCurrentHP();
    }

    void GetCurrentHP()
    {
        float hpAmount = (float)currenthp/ (float) maxhp;
        slider.fillAmount = hpAmount;
    }
}
