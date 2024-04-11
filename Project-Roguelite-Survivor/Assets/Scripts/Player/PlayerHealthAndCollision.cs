using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealthAndCollision : MonoBehaviour
{
    public static int PlayerHealth = 100;
    public TextMeshProUGUI PlayerHealthUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerHealthUI.SetText("Health: " + PlayerHealth.ToString());
    }
}
