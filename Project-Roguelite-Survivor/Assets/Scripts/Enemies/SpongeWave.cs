using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpongeWave : MonoBehaviour
{

    public GameObject Sponge;
    public static float bulletVelocity = 2.0f;

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        Sponge = GameObject.FindWithTag("Sponge");
        transform.rotation = Sponge.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletVelocity * Time.deltaTime;
    }
}
