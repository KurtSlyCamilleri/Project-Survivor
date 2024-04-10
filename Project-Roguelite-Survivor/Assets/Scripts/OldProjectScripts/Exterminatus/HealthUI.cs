using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthUI : MonoBehaviour
{
    public static int hp = 3;
    public TextMeshProUGUI health;
    
    // Start is called before the first frame update
    void Start()
    {
        hp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        health.SetText("Health: " + hp.ToString());
    }
}
