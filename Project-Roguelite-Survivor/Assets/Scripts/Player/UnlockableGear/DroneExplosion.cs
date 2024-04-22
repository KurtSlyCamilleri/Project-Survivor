using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneExplosion : MonoBehaviour
{
    public float droneExplosionLasting = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DroneFade());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DroneFade()
    {
        yield return new WaitForSeconds(droneExplosionLasting);
        Destroy(gameObject);
    }
}
