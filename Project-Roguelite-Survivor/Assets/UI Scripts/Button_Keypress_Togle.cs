using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Keypress_Togle : MonoBehaviour
{

    public GameObject Upgrade_Basic_Pannel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Upgrade_Basic_Pannel.gameObject.SetActive(!Upgrade_Basic_Pannel.gameObject.activeSelf);
        }

    }
}
