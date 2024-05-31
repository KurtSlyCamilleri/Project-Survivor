using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldBar : MonoBehaviour
{
    public int maxshield;
    public int currentshield;
    public Image slider;
    ShieldGen ShieldScript;
    // Start is called before the first frame update
    void Start()
    {
        maxshield = ShieldScript.ShieldCapacity;
        currentshield = ShieldScript.ShieldLevel;
    }

    // Update is called once per frame
    void Update()
    {
        maxshield = ShieldScript.ShieldCapacity;
        currentshield = ShieldScript.ShieldLevel;
        GetCurrentShield();
    }
    void GetCurrentShield()
    {
        float shAmount = (float)currentshield / (float)maxshield;
        slider.fillAmount = shAmount;
    }
    }
