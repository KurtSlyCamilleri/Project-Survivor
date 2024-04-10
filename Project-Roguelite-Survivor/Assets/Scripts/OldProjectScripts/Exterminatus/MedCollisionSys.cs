using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedCollisionSys : MonoBehaviour
{
    public float dropSpeed = 1f;
    public GameObject MedKit;
    public HealthUI hpUI;


    void OnBecameInvisible() 
    {
        Destroy(gameObject);
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        HealthUI.hp += 2;
        Destroy(gameObject);
    }*/
     void Update () {
        transform.position += -transform.up * dropSpeed * Time.deltaTime;
    }
    
}