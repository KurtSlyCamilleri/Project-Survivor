using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag == "Player")
        {
           Destroy(gameObject);
        }
       
    }
}
