using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealthAndCollision : MonoBehaviour
{
    public int PlayerHealth = 100;
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
    void OnCollisionEnter(Collision targetObj)
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
