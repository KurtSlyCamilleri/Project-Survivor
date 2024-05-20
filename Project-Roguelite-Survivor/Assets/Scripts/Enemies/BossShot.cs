using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShot : MonoBehaviour
{
    public GameObject TheBoss;
    public static float bulletVelocity = 3.0f;
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        TheBoss = GameObject.FindWithTag("Boss");
        transform.rotation = TheBoss.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletVelocity * Time.deltaTime;
    }
}
