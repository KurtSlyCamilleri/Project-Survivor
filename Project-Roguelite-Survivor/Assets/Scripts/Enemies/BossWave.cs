using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWave : MonoBehaviour
{
    public static float bulletVelocity = 1.5f;
    //public GameObject TheBoss;
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        //TheBoss = GameObject.FindWithTag("Boss");
        //transform.rotation = TheBoss.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletVelocity * Time.deltaTime;
    }
}
